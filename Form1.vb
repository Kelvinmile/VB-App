Public Class Login
    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        Dim user As String
        Dim pass As String

        user = "admin"
        pass = "admin"

        If (user = TextBoxUsername.Text And pass = TextBoxPassword.Text) Then
            MsgBox("Login successful", MsgBoxStyle.Information)
            Form4.Show()
            Me.Hide()
        Else
            MsgBox("Oops,try again!! ", MsgBoxStyle.Exclamation)
            TextBoxPassword.Clear()
            TextBoxUsername.Clear()

        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub

End Class
