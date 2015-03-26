<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Search
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
        Me.txtb_search = New System.Windows.Forms.TextBox()
        Me.dgrid_search = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.combo_sefrom = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_back = New System.Windows.Forms.Button()
        CType(Me.dgrid_search, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtb_search
        '
        Me.txtb_search.Location = New System.Drawing.Point(241, 28)
        Me.txtb_search.Name = "txtb_search"
        Me.txtb_search.Size = New System.Drawing.Size(315, 23)
        Me.txtb_search.TabIndex = 0
        '
        'dgrid_search
        '
        Me.dgrid_search.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgrid_search.Location = New System.Drawing.Point(40, 72)
        Me.dgrid_search.Name = "dgrid_search"
        Me.dgrid_search.Size = New System.Drawing.Size(743, 356)
        Me.dgrid_search.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Search By:"
        '
        'combo_sefrom
        '
        Me.combo_sefrom.FormattingEnabled = True
        Me.combo_sefrom.Items.AddRange(New Object() {"Stock Name", "Category Name", "Sub-Category Name"})
        Me.combo_sefrom.Location = New System.Drawing.Point(132, 44)
        Me.combo_sefrom.Name = "combo_sefrom"
        Me.combo_sefrom.Size = New System.Drawing.Size(121, 21)
        Me.combo_sefrom.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_back)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtb_search)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(18, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(787, 433)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search Details"
        '
        'btn_back
        '
        Me.btn_back.Location = New System.Drawing.Point(690, 30)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(75, 23)
        Me.btn_back.TabIndex = 1
        Me.btn_back.Text = "Back"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'Search
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(823, 460)
        Me.Controls.Add(Me.combo_sefrom)
        Me.Controls.Add(Me.dgrid_search)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Search"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Search"
        CType(Me.dgrid_search, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtb_search As System.Windows.Forms.TextBox
    Friend WithEvents dgrid_search As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents combo_sefrom As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_back As System.Windows.Forms.Button
End Class
