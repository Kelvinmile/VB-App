Imports System.Data.SqlClient
Public Class Form5
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim i As Integer

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\KayMile\source\repos\WindowsApp1\Database1.mdf;Integrated Security=True"
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
        display_data()
    End Sub

    Public Sub display_data()

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from Property"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView1.DataSource = dt

    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        Try
            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "insert into Property values('" + PropertyTextBox.Text + "','" + SizeTextBox.Text + "','" + PriceTextBox.Text + "','" + LocationTextBox.Text + "')"
            cmd.ExecuteNonQuery()
            display_data()

            PropertyTextBox.Clear()
            SizeTextBox.Clear()
            PriceTextBox.Clear()
            LocationTextBox.Clear()

            MsgBox("record inserted successfully")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DisplayButton_Click(sender As Object, e As EventArgs) Handles DisplayButton.Click
        display_data()

    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()

            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "update Property set Name ='" + PropertyTextBox.Text + "',Size='" + SizeTextBox.Text + "', Price = '" + PriceTextBox.Text + "',Location= '" + LocationTextBox.Text + "' where Id =" & i & ""
            cmd.ExecuteNonQuery()

            display_data()
            MsgBox("Record updated successfully")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()
            i = Convert.ToInt32(DataGridView1.SelectedCells.Item(0).Value.ToString())

            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select * from Property where Id =" & i & ""
            cmd.ExecuteNonQuery()
            Dim dt As New DataTable()
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
            Dim dr As SqlClient.SqlDataReader
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)

            While dr.Read
                PropertyTextBox.Text = dr.GetString(1).ToString()
                SizeTextBox.Text = dr.GetString(2).ToString()

            End While
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
            cmd.CommandText = "delete * from Property where Name = '" + PropertyTextBox.Text + "'"
            cmd.ExecuteNonQuery()

            display_data()
            MsgBox("Record deleted successful")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        Try
            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select * from Property where Name = '" + PropertyTextBox.Text + "'"
            cmd.ExecuteNonQuery()
            Dim dt As New DataTable()
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
            DataGridView1.DataSource = dt

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Order.Show()
        Me.Hide()
    End Sub

End Class