<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Stock
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtStock_ID = New System.Windows.Forms.TextBox()
        Me.txtS_name = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_qty = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.combo_subcat = New System.Windows.Forms.ComboBox()
        Me.combo_category = New System.Windows.Forms.ComboBox()
        Me.asd = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_gotom = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_insert = New System.Windows.Forms.Button()
        Me.TBCategoryBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DB_InventoryDataSet1 = New InventorySystem.DB_InventoryDataSet1()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.grid_stocks = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DB_InventoryDataSet = New InventorySystem.DB_InventoryDataSet()
        Me.TBCategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TB_CategoryTableAdapter = New InventorySystem.DB_InventoryDataSetTableAdapters.TB_CategoryTableAdapter()
        Me.TB_CategoryTableAdapter1 = New InventorySystem.DB_InventoryDataSet1TableAdapters.TB_CategoryTableAdapter()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.TBCategoryBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DB_InventoryDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_stocks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DB_InventoryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBCategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Stock ID"
        '
        'txtStock_ID
        '
        Me.txtStock_ID.Location = New System.Drawing.Point(129, 63)
        Me.txtStock_ID.MaxLength = 15
        Me.txtStock_ID.Name = "txtStock_ID"
        Me.txtStock_ID.Size = New System.Drawing.Size(100, 20)
        Me.txtStock_ID.TabIndex = 1
        '
        'txtS_name
        '
        Me.txtS_name.Location = New System.Drawing.Point(129, 96)
        Me.txtS_name.MaxLength = 20
        Me.txtS_name.Name = "txtS_name"
        Me.txtS_name.Size = New System.Drawing.Size(177, 20)
        Me.txtS_name.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Stock Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Category"
        '
        'txt_qty
        '
        Me.txt_qty.Location = New System.Drawing.Point(129, 196)
        Me.txt_qty.MaxLength = 6
        Me.txt_qty.Name = "txt_qty"
        Me.txt_qty.Size = New System.Drawing.Size(51, 20)
        Me.txt_qty.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(25, 199)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Quantity"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.combo_subcat)
        Me.GroupBox1.Controls.Add(Me.combo_category)
        Me.GroupBox1.Controls.Add(Me.asd)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.txtStock_ID)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_qty)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtS_name)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(314, 364)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Stock Details"
        '
        'combo_subcat
        '
        Me.combo_subcat.FormattingEnabled = True
        Me.combo_subcat.Location = New System.Drawing.Point(129, 165)
        Me.combo_subcat.Name = "combo_subcat"
        Me.combo_subcat.Size = New System.Drawing.Size(121, 21)
        Me.combo_subcat.TabIndex = 18
        '
        'combo_category
        '
        Me.combo_category.FormattingEnabled = True
        Me.combo_category.Location = New System.Drawing.Point(129, 130)
        Me.combo_category.Name = "combo_category"
        Me.combo_category.Size = New System.Drawing.Size(121, 21)
        Me.combo_category.TabIndex = 17
        '
        'asd
        '
        Me.asd.AutoSize = True
        Me.asd.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.asd.Location = New System.Drawing.Point(27, 167)
        Me.asd.Name = "asd"
        Me.asd.Size = New System.Drawing.Size(96, 17)
        Me.asd.TabIndex = 16
        Me.asd.Text = "Sub-Category"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btn_clear)
        Me.Panel1.Controls.Add(Me.btn_gotom)
        Me.Panel1.Controls.Add(Me.btn_delete)
        Me.Panel1.Controls.Add(Me.btn_update)
        Me.Panel1.Controls.Add(Me.btn_insert)
        Me.Panel1.Location = New System.Drawing.Point(18, 264)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(277, 79)
        Me.Panel1.TabIndex = 13
        '
        'btn_clear
        '
        Me.btn_clear.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clear.Location = New System.Drawing.Point(8, 43)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(75, 23)
        Me.btn_clear.TabIndex = 4
        Me.btn_clear.Text = "Clear"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'btn_gotom
        '
        Me.btn_gotom.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_gotom.Location = New System.Drawing.Point(192, 43)
        Me.btn_gotom.Name = "btn_gotom"
        Me.btn_gotom.Size = New System.Drawing.Size(75, 23)
        Me.btn_gotom.TabIndex = 3
        Me.btn_gotom.Text = "Back"
        Me.btn_gotom.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.Location = New System.Drawing.Point(192, 10)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(75, 23)
        Me.btn_delete.TabIndex = 2
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_update
        '
        Me.btn_update.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.Location = New System.Drawing.Point(101, 10)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(75, 23)
        Me.btn_update.TabIndex = 1
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'btn_insert
        '
        Me.btn_insert.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_insert.Location = New System.Drawing.Point(8, 10)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(75, 23)
        Me.btn_insert.TabIndex = 0
        Me.btn_insert.Text = "Insert"
        Me.btn_insert.UseVisualStyleBackColor = True
        '
        'TBCategoryBindingSource1
        '
        Me.TBCategoryBindingSource1.DataMember = "TB_Category"
        Me.TBCategoryBindingSource1.DataSource = Me.DB_InventoryDataSet1
        '
        'DB_InventoryDataSet1
        '
        Me.DB_InventoryDataSet1.DataSetName = "DB_InventoryDataSet1"
        Me.DB_InventoryDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Silver
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 18)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Stock Entry"
        '
        'grid_stocks
        '
        Me.grid_stocks.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.grid_stocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_stocks.Location = New System.Drawing.Point(334, 48)
        Me.grid_stocks.Name = "grid_stocks"
        Me.grid_stocks.Size = New System.Drawing.Size(743, 356)
        Me.grid_stocks.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Silver
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(331, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 18)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Current Stock"
        '
        'DB_InventoryDataSet
        '
        Me.DB_InventoryDataSet.DataSetName = "DB_InventoryDataSet"
        Me.DB_InventoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TBCategoryBindingSource
        '
        Me.TBCategoryBindingSource.DataMember = "TB_Category"
        Me.TBCategoryBindingSource.DataSource = Me.DB_InventoryDataSet
        '
        'TB_CategoryTableAdapter
        '
        Me.TB_CategoryTableAdapter.ClearBeforeFill = True
        '
        'TB_CategoryTableAdapter1
        '
        Me.TB_CategoryTableAdapter1.ClearBeforeFill = True
        '
        'Stock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1088, 413)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.grid_stocks)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Stock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stock"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.TBCategoryBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DB_InventoryDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_stocks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DB_InventoryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBCategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtStock_ID As System.Windows.Forms.TextBox
    Friend WithEvents txtS_name As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_qty As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents grid_stocks As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents btn_update As System.Windows.Forms.Button
    Friend WithEvents btn_insert As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btn_gotom As System.Windows.Forms.Button
    Friend WithEvents btn_clear As System.Windows.Forms.Button
    Friend WithEvents asd As System.Windows.Forms.Label
    Friend WithEvents DB_InventoryDataSet As InventorySystem.DB_InventoryDataSet
    Friend WithEvents TBCategoryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TB_CategoryTableAdapter As InventorySystem.DB_InventoryDataSetTableAdapters.TB_CategoryTableAdapter
    Friend WithEvents DB_InventoryDataSet1 As InventorySystem.DB_InventoryDataSet1
    Friend WithEvents TBCategoryBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents TB_CategoryTableAdapter1 As InventorySystem.DB_InventoryDataSet1TableAdapters.TB_CategoryTableAdapter
    Friend WithEvents combo_subcat As System.Windows.Forms.ComboBox
    Friend WithEvents combo_category As System.Windows.Forms.ComboBox
End Class
