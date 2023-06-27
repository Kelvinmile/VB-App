<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin
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
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DesignationLabel = New System.Windows.Forms.Label()
        Me.DesignationTextBox = New System.Windows.Forms.TextBox()
        Me.DepartmentLabel = New System.Windows.Forms.Label()
        Me.DepartmentTextBox = New System.Windows.Forms.TextBox()
        Me.StaffLabel = New System.Windows.Forms.Label()
        Me.StaffTextBox = New System.Windows.Forms.TextBox()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.DisplayButton = New System.Windows.Forms.Button()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.TelephoneTextBox = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CancelButton
        '
        Me.CancelButton.BackColor = System.Drawing.Color.Firebrick
        Me.CancelButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelButton.Location = New System.Drawing.Point(875, 387)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(108, 115)
        Me.CancelButton.TabIndex = 0
        Me.CancelButton.Text = "SIGN OUT"
        Me.CancelButton.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(440, 25)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(543, 261)
        Me.DataGridView1.TabIndex = 2
        '
        'DesignationLabel
        '
        Me.DesignationLabel.AutoSize = True
        Me.DesignationLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DesignationLabel.Location = New System.Drawing.Point(12, 167)
        Me.DesignationLabel.Name = "DesignationLabel"
        Me.DesignationLabel.Size = New System.Drawing.Size(132, 25)
        Me.DesignationLabel.TabIndex = 26
        Me.DesignationLabel.Text = "Designation:"
        '
        'DesignationTextBox
        '
        Me.DesignationTextBox.Location = New System.Drawing.Point(167, 167)
        Me.DesignationTextBox.Multiline = True
        Me.DesignationTextBox.Name = "DesignationTextBox"
        Me.DesignationTextBox.Size = New System.Drawing.Size(241, 25)
        Me.DesignationTextBox.TabIndex = 25
        '
        'DepartmentLabel
        '
        Me.DepartmentLabel.AutoSize = True
        Me.DepartmentLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DepartmentLabel.Location = New System.Drawing.Point(12, 102)
        Me.DepartmentLabel.Name = "DepartmentLabel"
        Me.DepartmentLabel.Size = New System.Drawing.Size(129, 25)
        Me.DepartmentLabel.TabIndex = 24
        Me.DepartmentLabel.Text = "Department:"
        '
        'DepartmentTextBox
        '
        Me.DepartmentTextBox.Location = New System.Drawing.Point(167, 102)
        Me.DepartmentTextBox.Multiline = True
        Me.DepartmentTextBox.Name = "DepartmentTextBox"
        Me.DepartmentTextBox.Size = New System.Drawing.Size(241, 25)
        Me.DepartmentTextBox.TabIndex = 23
        '
        'StaffLabel
        '
        Me.StaffLabel.AutoSize = True
        Me.StaffLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StaffLabel.Location = New System.Drawing.Point(12, 38)
        Me.StaffLabel.Name = "StaffLabel"
        Me.StaffLabel.Size = New System.Drawing.Size(124, 25)
        Me.StaffLabel.TabIndex = 22
        Me.StaffLabel.Text = "Staff Name:"
        '
        'StaffTextBox
        '
        Me.StaffTextBox.Location = New System.Drawing.Point(167, 38)
        Me.StaffTextBox.Multiline = True
        Me.StaffTextBox.Name = "StaffTextBox"
        Me.StaffTextBox.Size = New System.Drawing.Size(241, 25)
        Me.StaffTextBox.TabIndex = 21
        '
        'AddButton
        '
        Me.AddButton.BackColor = System.Drawing.Color.LimeGreen
        Me.AddButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddButton.Location = New System.Drawing.Point(42, 450)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(140, 52)
        Me.AddButton.TabIndex = 27
        Me.AddButton.Text = "Add Admin"
        Me.AddButton.UseVisualStyleBackColor = False
        '
        'DisplayButton
        '
        Me.DisplayButton.BackColor = System.Drawing.Color.LightYellow
        Me.DisplayButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisplayButton.Location = New System.Drawing.Point(367, 450)
        Me.DisplayButton.Name = "DisplayButton"
        Me.DisplayButton.Size = New System.Drawing.Size(140, 52)
        Me.DisplayButton.TabIndex = 28
        Me.DisplayButton.Text = "Display Admins"
        Me.DisplayButton.UseVisualStyleBackColor = False
        '
        'UpdateButton
        '
        Me.UpdateButton.BackColor = System.Drawing.Color.DarkKhaki
        Me.UpdateButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateButton.Location = New System.Drawing.Point(199, 450)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(140, 52)
        Me.UpdateButton.TabIndex = 42
        Me.UpdateButton.Text = "Update Admin"
        Me.UpdateButton.UseVisualStyleBackColor = False
        '
        'DeleteButton
        '
        Me.DeleteButton.BackColor = System.Drawing.Color.Red
        Me.DeleteButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteButton.Location = New System.Drawing.Point(539, 450)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(140, 52)
        Me.DeleteButton.TabIndex = 41
        Me.DeleteButton.Text = " Delete Admin"
        Me.DeleteButton.UseVisualStyleBackColor = False
        '
        'SearchButton
        '
        Me.SearchButton.BackColor = System.Drawing.Color.DarkCyan
        Me.SearchButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchButton.Location = New System.Drawing.Point(699, 450)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(140, 52)
        Me.SearchButton.TabIndex = 43
        Me.SearchButton.Text = "Search Admin"
        Me.SearchButton.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 234)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 25)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "Telephone:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 306)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 25)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Address:"
        '
        'AddressTextBox
        '
        Me.AddressTextBox.Location = New System.Drawing.Point(166, 306)
        Me.AddressTextBox.Multiline = True
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(241, 25)
        Me.AddressTextBox.TabIndex = 44
        '
        'TelephoneTextBox
        '
        Me.TelephoneTextBox.Location = New System.Drawing.Point(166, 240)
        Me.TelephoneTextBox.Multiline = True
        Me.TelephoneTextBox.Name = "TelephoneTextBox"
        Me.TelephoneTextBox.Size = New System.Drawing.Size(241, 25)
        Me.TelephoneTextBox.TabIndex = 51
        '
        'Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumAquamarine
        Me.ClientSize = New System.Drawing.Size(995, 537)
        Me.Controls.Add(Me.TelephoneTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(Me.SearchButton)
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.DisplayButton)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.DesignationLabel)
        Me.Controls.Add(Me.DesignationTextBox)
        Me.Controls.Add(Me.DepartmentLabel)
        Me.Controls.Add(Me.DepartmentTextBox)
        Me.Controls.Add(Me.StaffLabel)
        Me.Controls.Add(Me.StaffTextBox)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.CancelButton)
        Me.Name = "Admin"
        Me.Text = "Admin"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CancelButton As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DesignationLabel As Label
    Friend WithEvents DesignationTextBox As TextBox
    Friend WithEvents DepartmentLabel As Label
    Friend WithEvents DepartmentTextBox As TextBox
    Friend WithEvents StaffLabel As Label
    Friend WithEvents StaffTextBox As TextBox
    Friend WithEvents AddButton As Button
    Friend WithEvents DisplayButton As Button
    Friend WithEvents UpdateButton As Button
    Friend WithEvents DeleteButton As Button
    Friend WithEvents SearchButton As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents TelephoneTextBox As TextBox
End Class
