<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Me.DisplayButton = New System.Windows.Forms.Button()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.DesignationLabel = New System.Windows.Forms.Label()
        Me.PriceTextBox = New System.Windows.Forms.TextBox()
        Me.DepartmentLabel = New System.Windows.Forms.Label()
        Me.SizeTextBox = New System.Windows.Forms.TextBox()
        Me.PropertyLabel = New System.Windows.Forms.Label()
        Me.PropertyTextBox = New System.Windows.Forms.TextBox()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LocationTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CancelButton
        '
        Me.CancelButton.BackColor = System.Drawing.Color.DarkKhaki
        Me.CancelButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelButton.Location = New System.Drawing.Point(603, 445)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(140, 52)
        Me.CancelButton.TabIndex = 0
        Me.CancelButton.Text = "EXIT"
        Me.CancelButton.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(459, 33)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(508, 244)
        Me.DataGridView1.TabIndex = 1
        '
        'DisplayButton
        '
        Me.DisplayButton.BackColor = System.Drawing.Color.Honeydew
        Me.DisplayButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisplayButton.Location = New System.Drawing.Point(335, 357)
        Me.DisplayButton.Name = "DisplayButton"
        Me.DisplayButton.Size = New System.Drawing.Size(140, 52)
        Me.DisplayButton.TabIndex = 36
        Me.DisplayButton.Text = "Display Property"
        Me.DisplayButton.UseVisualStyleBackColor = False
        '
        'AddButton
        '
        Me.AddButton.BackColor = System.Drawing.Color.SeaGreen
        Me.AddButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddButton.Location = New System.Drawing.Point(81, 357)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(140, 52)
        Me.AddButton.TabIndex = 35
        Me.AddButton.Text = "Add Property"
        Me.AddButton.UseVisualStyleBackColor = False
        '
        'DesignationLabel
        '
        Me.DesignationLabel.AutoSize = True
        Me.DesignationLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DesignationLabel.Location = New System.Drawing.Point(22, 171)
        Me.DesignationLabel.Name = "DesignationLabel"
        Me.DesignationLabel.Size = New System.Drawing.Size(67, 25)
        Me.DesignationLabel.TabIndex = 34
        Me.DesignationLabel.Text = "Price:"
        '
        'PriceTextBox
        '
        Me.PriceTextBox.Location = New System.Drawing.Point(180, 171)
        Me.PriceTextBox.Multiline = True
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.Size = New System.Drawing.Size(241, 25)
        Me.PriceTextBox.TabIndex = 33
        '
        'DepartmentLabel
        '
        Me.DepartmentLabel.AutoSize = True
        Me.DepartmentLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DepartmentLabel.Location = New System.Drawing.Point(22, 104)
        Me.DepartmentLabel.Name = "DepartmentLabel"
        Me.DepartmentLabel.Size = New System.Drawing.Size(60, 25)
        Me.DepartmentLabel.TabIndex = 32
        Me.DepartmentLabel.Text = "Size:"
        '
        'SizeTextBox
        '
        Me.SizeTextBox.Location = New System.Drawing.Point(180, 110)
        Me.SizeTextBox.Multiline = True
        Me.SizeTextBox.Name = "SizeTextBox"
        Me.SizeTextBox.Size = New System.Drawing.Size(241, 25)
        Me.SizeTextBox.TabIndex = 31
        '
        'PropertyLabel
        '
        Me.PropertyLabel.AutoSize = True
        Me.PropertyLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PropertyLabel.Location = New System.Drawing.Point(22, 42)
        Me.PropertyLabel.Name = "PropertyLabel"
        Me.PropertyLabel.Size = New System.Drawing.Size(74, 25)
        Me.PropertyLabel.TabIndex = 30
        Me.PropertyLabel.Text = "Name:"
        '
        'PropertyTextBox
        '
        Me.PropertyTextBox.Location = New System.Drawing.Point(180, 48)
        Me.PropertyTextBox.Multiline = True
        Me.PropertyTextBox.Name = "PropertyTextBox"
        Me.PropertyTextBox.Size = New System.Drawing.Size(241, 25)
        Me.PropertyTextBox.TabIndex = 29
        '
        'UpdateButton
        '
        Me.UpdateButton.BackColor = System.Drawing.Color.SteelBlue
        Me.UpdateButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateButton.Location = New System.Drawing.Point(603, 357)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(140, 52)
        Me.UpdateButton.TabIndex = 40
        Me.UpdateButton.Text = "Update Property"
        Me.UpdateButton.UseVisualStyleBackColor = False
        '
        'DeleteButton
        '
        Me.DeleteButton.BackColor = System.Drawing.Color.Firebrick
        Me.DeleteButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteButton.Location = New System.Drawing.Point(81, 445)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(140, 52)
        Me.DeleteButton.TabIndex = 38
        Me.DeleteButton.Text = " Delete Property"
        Me.DeleteButton.UseVisualStyleBackColor = False
        '
        'SearchButton
        '
        Me.SearchButton.BackColor = System.Drawing.Color.Gold
        Me.SearchButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchButton.Location = New System.Drawing.Point(335, 445)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(140, 52)
        Me.SearchButton.TabIndex = 41
        Me.SearchButton.Text = "Search Property"
        Me.SearchButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 236)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 25)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Location:"
        '
        'LocationTextBox
        '
        Me.LocationTextBox.Location = New System.Drawing.Point(180, 242)
        Me.LocationTextBox.Multiline = True
        Me.LocationTextBox.Name = "LocationTextBox"
        Me.LocationTextBox.Size = New System.Drawing.Size(241, 25)
        Me.LocationTextBox.TabIndex = 42
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkCyan
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.MintCream
        Me.Button1.Location = New System.Drawing.Point(827, 357)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(140, 140)
        Me.Button1.TabIndex = 44
        Me.Button1.Text = "LETS GO ORDER !!"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Peru
        Me.ClientSize = New System.Drawing.Size(979, 522)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LocationTextBox)
        Me.Controls.Add(Me.SearchButton)
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.DisplayButton)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.DesignationLabel)
        Me.Controls.Add(Me.PriceTextBox)
        Me.Controls.Add(Me.DepartmentLabel)
        Me.Controls.Add(Me.SizeTextBox)
        Me.Controls.Add(Me.PropertyLabel)
        Me.Controls.Add(Me.PropertyTextBox)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.CancelButton)
        Me.Name = "Form5"
        Me.Text = "Property"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CancelButton As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DisplayButton As Button
    Friend WithEvents AddButton As Button
    Friend WithEvents DesignationLabel As Label
    Friend WithEvents PriceTextBox As TextBox
    Friend WithEvents DepartmentLabel As Label
    Friend WithEvents SizeTextBox As TextBox
    Friend WithEvents PropertyLabel As Label
    Friend WithEvents PropertyTextBox As TextBox
    Friend WithEvents UpdateButton As Button
    Friend WithEvents DeleteButton As Button
    Friend WithEvents SearchButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents LocationTextBox As TextBox
    Friend WithEvents Button1 As Button
End Class
