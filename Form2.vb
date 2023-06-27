Imports System.Data.SqlClient
Public Class Order
    Dim onsale As String
    Dim Tax As Double
    Dim Amt As Double
    Dim price As Double
    Dim cost As Double
    Dim bal As Double
    Const rate = 0.15

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub


    Private Sub ComputeButton_Click(sender As Object, e As EventArgs) Handles ComputeButton.Click
        Price2TextBox.Text = price
        TaxTextBox.Text = Tax
        PriceTextBox.Text = cost
        AmtTextBox.Text = Amt
        BalTextBox.Text = bal

        onsale = Convert.ToString(ComboBoxP.Text)


        If (onsale = "joes") Then
            cost = "450578"

        ElseIf (onsale = "ortgas") Then
            cost = "345600"
        ElseIf (onsale = "propertyone") Then
            cost = "397600"
        ElseIf (onsale = "propertytwo") Then
            cost = "205690"
        Else
            MsgBox("invalid input")
        End If

        Tax = rate * cost
        price = Tax + cost

        PriceTextBox.Text = Convert.ToString(cost)
        TaxTextBox.Text = Convert.ToString(Tax)
        Price2TextBox.Text = Convert.ToString(price)
    End Sub


    Private Sub PurchaseButton_Click(sender As Object, e As EventArgs) Handles PurchaseButton.Click
        BalTextBox.Text = Tax
        AmtTextBox.Text = Amt
        Price2TextBox.Text = price
        Price2TextBox.Text = Convert.ToString(price)

        Try
            Amt = Convert.ToDouble(AmtTextBox.Text)

            bal = Amt - price

            BalTextBox.Text = Convert.ToString(bal)

            If (Amt >= price) Then
                MsgBox("purchase successful ", "balance = " + bal)


            ElseIf (Amt < price) Then
                MsgBox("insufficient amount")
            End If
        Catch ex As Exception
            MsgBox("invalid amount input")
        End Try




    End Sub

End Class