Imports System.Data.SqlClient
Public Class Admin
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim i As Integer


    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub

    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\KayMile\source\repos\WindowsApp1\Database1.mdf;Integrated Security=True"
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()

        display_data()
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        Try
            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "insert into Administrators values('" + StaffTextBox.Text + "','" + DepartmentTextBox.Text + "','" + DesignationTextBox.Text + "','" + TelephoneTextBox.Text + "','" + AddressTextBox.Text + "')"
            cmd.ExecuteNonQuery()

            display_data()

            MsgBox("record inserted successfully")

            StaffTextBox.Clear()
            DepartmentTextBox.Clear()
            DesignationTextBox.Clear()
            TelephoneTextBox.Clear()
            AddressTextBox.Clear()

        Catch ex As Exception

        End Try
    End Sub

    Public Sub display_data()

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from Administrators"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()
            i = Convert.ToInt32(DataGridView1.SelectedCells.Item(0).Value.ToString())

            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select * from Administators where Id =" & i & ""
            cmd.ExecuteNonQuery()
            Dim dt As New DataTable()
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
            Dim dr As SqlClient.SqlDataReader
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)

            While dr.Read
                StaffTextBox.Text = dr.GetString(1).ToString()
                DepartmentTextBox.Text = dr.GetString(2).ToString()
                DesignationTextBox.Text = dr.GetString(3).ToString()
            End While
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DisplayButton_Click(sender As Object, e As EventArgs) Handles DisplayButton.Click
        display_data()

    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        Try
            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select * from Administrators where StaffName='" + StaffTextBox.Text + "'"
            cmd.ExecuteNonQuery()
            Dim dt As New DataTable()
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
            DataGridView1.DataSource = dt

        Catch ex As Exception

        End Try

    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()

            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "delete * from Administrators where StaffName='" + StaffTextBox.Text + "'"
            cmd.ExecuteNonQuery()

            display_data()

            StaffTextBox.Clear()
            DepartmentTextBox.Clear()
            DesignationTextBox.Clear()
            TelephoneTextBox.Clear()
            AddressTextBox.Clear()

            MsgBox("Record deleted successfully")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()

            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "update Administrators set StaffName='" + StaffTextBox.Text + "', Department ='" + DepartmentTextBox.Text + "',Designation = '" + DesignationTextBox.Text + "',Telephone = '" + TelephoneTextBox.Text + "',Address='" + AddressTextBox.Text + "' where Id =" & i & ""
            cmd.ExecuteNonQuery()

            display_data()

            StaffTextBox.Clear()
            DepartmentTextBox.Clear()
            DesignationTextBox.Clear()
            TelephoneTextBox.Clear()
            AddressTextBox.Clear()

            MsgBox("Record updated successfully")
        Catch ex As Exception

        End Try
    End Sub
End Class