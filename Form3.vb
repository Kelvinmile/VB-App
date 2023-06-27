Imports System.Data.SqlClient
Public Class Form3

    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim i As Integer


    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            cmd.CommandText = "insert into Clients values('" + NameTextBox.Text + "','" + TelephoneTextBox.Text + "','" + IDTextBox.Text + "','" + AddressTextBox.Text + "','" + AgeTextBox.Text + "')"
            cmd.ExecuteNonQuery()

            display_data()

            NameTextBox.Clear()
            TelephoneTextBox.Clear()
            IDTextBox.Clear()
            AddressTextBox.Clear()
            AgeTextBox.Clear()

            MsgBox("record inserted successfully")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub

    Public Sub display_data()

        Try
            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select * from Clients"
            cmd.ExecuteNonQuery()
            Dim dt As New DataTable()
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
            DataGridView1.DataSource = dt
        Catch ex As Exception

        End Try

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
            cmd.CommandText = "select * from Clients where Id =" & i & ""
            cmd.ExecuteNonQuery()
            Dim dt As New DataTable()
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
            Dim dr As SqlClient.SqlDataReader
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)

            While dr.Read
                NameTextBox.Text = dr.GetString(1).ToString()
                TelephoneTextBox.Text = dr.GetString(2).ToString()

            End While
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
            cmd.CommandText = "update Clients set Name='" + NameTextBox.Text + "',Telephone='" + TelephoneTextBox.Text + "',IDnumber = '" + IDTextBox.Text + "',Address = '" + AddressTextBox.Text + "',Age = '" + AgeTextBox.Text + "' where Id =" & i & ""
            cmd.ExecuteNonQuery()

            display_data()

            MsgBox("record successfully updated")
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
            cmd.CommandText = "delete * from Clients where Name='" + NameTextBox.Text + "'"
            cmd.ExecuteNonQuery()

            display_data()

            MsgBox("Record successfully deleted")
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
            cmd.CommandText = "select * from Clients where Name='" + NameTextBox.Text + "'"
            cmd.ExecuteNonQuery()
            Dim dt As New DataTable()
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
            DataGridView1.DataSource = dt

        Catch ex As Exception

        End Try

    End Sub

End Class