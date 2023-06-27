<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.ClientButton = New System.Windows.Forms.Button()
        Me.AdminButton = New System.Windows.Forms.Button()
        Me.PropertyButton = New System.Windows.Forms.Button()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ContractButton = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ClientButton
        '
        Me.ClientButton.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.ClientButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClientButton.Location = New System.Drawing.Point(849, 69)
        Me.ClientButton.Name = "ClientButton"
        Me.ClientButton.Size = New System.Drawing.Size(144, 42)
        Me.ClientButton.TabIndex = 0
        Me.ClientButton.Text = "CLIENTS"
        Me.ClientButton.UseVisualStyleBackColor = False
        '
        'AdminButton
        '
        Me.AdminButton.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.AdminButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminButton.Location = New System.Drawing.Point(849, 161)
        Me.AdminButton.Name = "AdminButton"
        Me.AdminButton.Size = New System.Drawing.Size(144, 42)
        Me.AdminButton.TabIndex = 1
        Me.AdminButton.Text = "ADMINISTRATORS"
        Me.AdminButton.UseVisualStyleBackColor = False
        '
        'PropertyButton
        '
        Me.PropertyButton.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.PropertyButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PropertyButton.Location = New System.Drawing.Point(849, 255)
        Me.PropertyButton.Name = "PropertyButton"
        Me.PropertyButton.Size = New System.Drawing.Size(144, 42)
        Me.PropertyButton.TabIndex = 2
        Me.PropertyButton.Text = "PROPERTY"
        Me.PropertyButton.UseVisualStyleBackColor = False
        '
        'CancelButton
        '
        Me.CancelButton.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.CancelButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelButton.Location = New System.Drawing.Point(849, 443)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(144, 42)
        Me.CancelButton.TabIndex = 4
        Me.CancelButton.Text = "SIGN  OUT"
        Me.CancelButton.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(33, 69)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(757, 416)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkRed
        Me.Label1.Location = New System.Drawing.Point(72, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(847, 25)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "WELCOME TO VILLA CARE SALES AND MARKETING MANAGEMENT SYSTEM"
        '
        'ContractButton
        '
        Me.ContractButton.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.ContractButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContractButton.Location = New System.Drawing.Point(849, 350)
        Me.ContractButton.Name = "ContractButton"
        Me.ContractButton.Size = New System.Drawing.Size(144, 42)
        Me.ContractButton.TabIndex = 7
        Me.ContractButton.Text = "CONTRACT"
        Me.ContractButton.UseVisualStyleBackColor = False
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1005, 531)
        Me.Controls.Add(Me.ContractButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.PropertyButton)
        Me.Controls.Add(Me.AdminButton)
        Me.Controls.Add(Me.ClientButton)
        Me.Name = "Form4"
        Me.Text = "Home"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ClientButton As Button
    Friend WithEvents AdminButton As Button
    Friend WithEvents PropertyButton As Button
    Friend WithEvents CancelButton As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ContractButton As Button
End Class
