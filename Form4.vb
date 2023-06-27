Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ClientButton_Click(sender As Object, e As EventArgs) Handles ClientButton.Click
        Form3.Show()


    End Sub

    Private Sub AdminButton_Click(sender As Object, e As EventArgs) Handles AdminButton.Click
        Admin.Show()

    End Sub

    Private Sub PropertyButton_Click(sender As Object, e As EventArgs) Handles PropertyButton.Click
        Form5.Show()

    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub

    Private Sub ContractButton_Click(sender As Object, e As EventArgs) Handles ContractButton.Click
        Order.Show()
    End Sub
End Class