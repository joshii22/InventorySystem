<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Stocks
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
        Me.combo_category = New System.Windows.Forms.ComboBox()
        Me.combo_subcat = New System.Windows.Forms.ComboBox()
        Me.Label = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.combo = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'combo_category
        '
        Me.combo_category.DisplayMember = "Category Name"
        Me.combo_category.FormattingEnabled = True
        Me.combo_category.Location = New System.Drawing.Point(12, 29)
        Me.combo_category.Name = "combo_category"
        Me.combo_category.Size = New System.Drawing.Size(121, 21)
        Me.combo_category.TabIndex = 16
        Me.combo_category.ValueMember = "Category ID"
        '
        'combo_subcat
        '
        Me.combo_subcat.DisplayMember = "Category Name"
        Me.combo_subcat.FormattingEnabled = True
        Me.combo_subcat.Location = New System.Drawing.Point(193, 29)
        Me.combo_subcat.Name = "combo_subcat"
        Me.combo_subcat.Size = New System.Drawing.Size(121, 21)
        Me.combo_subcat.TabIndex = 17
        Me.combo_subcat.ValueMember = "Category ID"
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Location = New System.Drawing.Point(12, 13)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(57, 13)
        Me.Label.TabIndex = 18
        Me.Label.Text = "Categories"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(190, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Sub-Category"
        '
        'combo
        '
        Me.combo.DisplayMember = "Category Name"
        Me.combo.FormattingEnabled = True
        Me.combo.Location = New System.Drawing.Point(193, 29)
        Me.combo.Name = "combo"
        Me.combo.Size = New System.Drawing.Size(121, 21)
        Me.combo.TabIndex = 17
        Me.combo.ValueMember = "Category ID"
        '
        'Stocks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(391, 337)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label)
        Me.Controls.Add(Me.combo_subcat)
        Me.Controls.Add(Me.combo_category)
        Me.Name = "Stocks"
        Me.Text = "Stocks"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents combo_category As System.Windows.Forms.ComboBox
    Friend WithEvents combo_subcat As System.Windows.Forms.ComboBox
    Friend WithEvents Label As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents combo As System.Windows.Forms.ComboBox
End Class
