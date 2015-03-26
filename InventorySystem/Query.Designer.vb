<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Query
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
        Me.txtb_Query = New System.Windows.Forms.TextBox()
        Me.btn_Query = New System.Windows.Forms.Button()
        Me.grid_query = New System.Windows.Forms.DataGridView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.grid_query, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtb_Query
        '
        Me.txtb_Query.Location = New System.Drawing.Point(12, 12)
        Me.txtb_Query.Multiline = True
        Me.txtb_Query.Name = "txtb_Query"
        Me.txtb_Query.Size = New System.Drawing.Size(292, 67)
        Me.txtb_Query.TabIndex = 0
        '
        'btn_Query
        '
        Me.btn_Query.Location = New System.Drawing.Point(310, 12)
        Me.btn_Query.Name = "btn_Query"
        Me.btn_Query.Size = New System.Drawing.Size(75, 67)
        Me.btn_Query.TabIndex = 1
        Me.btn_Query.Text = "Run"
        Me.btn_Query.UseVisualStyleBackColor = True
        '
        'grid_query
        '
        Me.grid_query.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_query.Location = New System.Drawing.Point(12, 85)
        Me.grid_query.Name = "grid_query"
        Me.grid_query.Size = New System.Drawing.Size(373, 221)
        Me.grid_query.TabIndex = 2
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 0
        '
        'Query
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(397, 318)
        Me.Controls.Add(Me.grid_query)
        Me.Controls.Add(Me.btn_Query)
        Me.Controls.Add(Me.txtb_Query)
        Me.Name = "Query"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Query"
        CType(Me.grid_query, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtb_Query As System.Windows.Forms.TextBox
    Friend WithEvents btn_Query As System.Windows.Forms.Button
    Friend WithEvents grid_query As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
