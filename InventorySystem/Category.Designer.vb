<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Category
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtb_CatID = New System.Windows.Forms.TextBox()
        Me.txtb_CatNam = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_gotom = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_insert = New System.Windows.Forms.Button()
        Me.grid_category = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.grid_category, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Category ID"
        '
        'txtb_CatID
        '
        Me.txtb_CatID.Location = New System.Drawing.Point(127, 47)
        Me.txtb_CatID.Name = "txtb_CatID"
        Me.txtb_CatID.Size = New System.Drawing.Size(100, 21)
        Me.txtb_CatID.TabIndex = 1
        '
        'txtb_CatNam
        '
        Me.txtb_CatNam.Location = New System.Drawing.Point(127, 87)
        Me.txtb_CatNam.Name = "txtb_CatNam"
        Me.txtb_CatNam.Size = New System.Drawing.Size(138, 21)
        Me.txtb_CatNam.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Category Name"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Silver
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 18)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Categories"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.txtb_CatNam)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtb_CatID)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(15, 42)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(280, 216)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Category Details"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btn_clear)
        Me.Panel1.Controls.Add(Me.btn_gotom)
        Me.Panel1.Controls.Add(Me.btn_delete)
        Me.Panel1.Controls.Add(Me.btn_update)
        Me.Panel1.Controls.Add(Me.btn_insert)
        Me.Panel1.Location = New System.Drawing.Point(14, 124)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(250, 78)
        Me.Panel1.TabIndex = 18
        '
        'btn_clear
        '
        Me.btn_clear.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clear.Location = New System.Drawing.Point(6, 39)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(75, 23)
        Me.btn_clear.TabIndex = 5
        Me.btn_clear.Text = "Clear"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'btn_gotom
        '
        Me.btn_gotom.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_gotom.Location = New System.Drawing.Point(89, 39)
        Me.btn_gotom.Name = "btn_gotom"
        Me.btn_gotom.Size = New System.Drawing.Size(75, 23)
        Me.btn_gotom.TabIndex = 3
        Me.btn_gotom.Text = "Back"
        Me.btn_gotom.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.Location = New System.Drawing.Point(168, 10)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(75, 23)
        Me.btn_delete.TabIndex = 2
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_update
        '
        Me.btn_update.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.Location = New System.Drawing.Point(87, 10)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(75, 23)
        Me.btn_update.TabIndex = 1
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'btn_insert
        '
        Me.btn_insert.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_insert.Location = New System.Drawing.Point(6, 10)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(75, 23)
        Me.btn_insert.TabIndex = 0
        Me.btn_insert.Text = "Insert"
        Me.btn_insert.UseVisualStyleBackColor = True
        '
        'grid_category
        '
        Me.grid_category.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.grid_category.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_category.Location = New System.Drawing.Point(301, 50)
        Me.grid_category.Name = "grid_category"
        Me.grid_category.Size = New System.Drawing.Size(245, 208)
        Me.grid_category.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Silver
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(302, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 18)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Current Categories"
        '
        'Category
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(556, 267)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.grid_category)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Category"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Category"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.grid_category, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtb_CatID As System.Windows.Forms.TextBox
    Friend WithEvents txtb_CatNam As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents grid_category As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn_gotom As System.Windows.Forms.Button
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents btn_update As System.Windows.Forms.Button
    Friend WithEvents btn_insert As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btn_clear As System.Windows.Forms.Button
End Class
