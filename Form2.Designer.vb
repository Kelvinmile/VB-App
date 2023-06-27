<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Order
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PriceTextBox = New System.Windows.Forms.TextBox()
        Me.ComboBoxP = New System.Windows.Forms.ComboBox()
        Me.PurchaseButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TaxTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Price2TextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AmtTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BalTextBox = New System.Windows.Forms.TextBox()
        Me.ComputeButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ExitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.Location = New System.Drawing.Point(540, 434)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(145, 59)
        Me.ExitButton.TabIndex = 12
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'UsernameLabel
        '
        Me.UsernameLabel.AutoSize = True
        Me.UsernameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameLabel.Location = New System.Drawing.Point(34, 33)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(99, 25)
        Me.UsernameLabel.TabIndex = 9
        Me.UsernameLabel.Text = "Property:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(34, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 25)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Price:"
        '
        'PriceTextBox
        '
        Me.PriceTextBox.Location = New System.Drawing.Point(207, 133)
        Me.PriceTextBox.Multiline = True
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.ReadOnly = True
        Me.PriceTextBox.Size = New System.Drawing.Size(308, 33)
        Me.PriceTextBox.TabIndex = 13
        '
        'ComboBoxP
        '
        Me.ComboBoxP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxP.FormattingEnabled = True
        Me.ComboBoxP.Items.AddRange(New Object() {"Propertyone", "Propertytwo", "ortgas", "joes"})
        Me.ComboBoxP.Location = New System.Drawing.Point(207, 37)
        Me.ComboBoxP.Name = "ComboBoxP"
        Me.ComboBoxP.Size = New System.Drawing.Size(270, 24)
        Me.ComboBoxP.TabIndex = 15
        '
        'PurchaseButton
        '
        Me.PurchaseButton.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PurchaseButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PurchaseButton.Location = New System.Drawing.Point(284, 434)
        Me.PurchaseButton.Name = "PurchaseButton"
        Me.PurchaseButton.Size = New System.Drawing.Size(145, 59)
        Me.PurchaseButton.TabIndex = 33
        Me.PurchaseButton.Text = "Buy"
        Me.PurchaseButton.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(34, 191)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 25)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Tax:"
        '
        'TaxTextBox
        '
        Me.TaxTextBox.Location = New System.Drawing.Point(207, 200)
        Me.TaxTextBox.Multiline = True
        Me.TaxTextBox.Name = "TaxTextBox"
        Me.TaxTextBox.ReadOnly = True
        Me.TaxTextBox.Size = New System.Drawing.Size(308, 33)
        Me.TaxTextBox.TabIndex = 34
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(34, 266)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(141, 25)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Overall Price:"
        '
        'Price2TextBox
        '
        Me.Price2TextBox.Location = New System.Drawing.Point(207, 264)
        Me.Price2TextBox.Multiline = True
        Me.Price2TextBox.Name = "Price2TextBox"
        Me.Price2TextBox.ReadOnly = True
        Me.Price2TextBox.Size = New System.Drawing.Size(308, 33)
        Me.Price2TextBox.TabIndex = 36
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 340)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 25)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Enter Amount:"
        '
        'AmtTextBox
        '
        Me.AmtTextBox.Location = New System.Drawing.Point(207, 332)
        Me.AmtTextBox.Multiline = True
        Me.AmtTextBox.Name = "AmtTextBox"
        Me.AmtTextBox.Size = New System.Drawing.Size(308, 33)
        Me.AmtTextBox.TabIndex = 40
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(565, 340)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 25)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "Balance:"
        '
        'BalTextBox
        '
        Me.BalTextBox.Location = New System.Drawing.Point(724, 332)
        Me.BalTextBox.Multiline = True
        Me.BalTextBox.Name = "BalTextBox"
        Me.BalTextBox.ReadOnly = True
        Me.BalTextBox.Size = New System.Drawing.Size(199, 41)
        Me.BalTextBox.TabIndex = 42
        '
        'ComputeButton
        '
        Me.ComputeButton.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ComputeButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComputeButton.Location = New System.Drawing.Point(570, 21)
        Me.ComputeButton.Name = "ComputeButton"
        Me.ComputeButton.Size = New System.Drawing.Size(268, 84)
        Me.ComputeButton.TabIndex = 44
        Me.ComputeButton.Text = "Compute"
        Me.ComputeButton.UseVisualStyleBackColor = False
        '
        'Order
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkKhaki
        Me.ClientSize = New System.Drawing.Size(944, 527)
        Me.Controls.Add(Me.ComputeButton)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BalTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AmtTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Price2TextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TaxTextBox)
        Me.Controls.Add(Me.PurchaseButton)
        Me.Controls.Add(Me.ComboBoxP)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PriceTextBox)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Name = "Order"
        Me.Text = "Property Purchase"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ExitButton As Button
    Friend WithEvents UsernameLabel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PriceTextBox As TextBox
    Friend WithEvents ComboBoxP As ComboBox
    Friend WithEvents PurchaseButton As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TaxTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Price2TextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents AmtTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents BalTextBox As TextBox
    Friend WithEvents ComputeButton As Button
End Class
