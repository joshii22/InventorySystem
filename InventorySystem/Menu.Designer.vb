<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.menstrp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mentrip_logout = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi_category = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi_subcat = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_search = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menstrp, Me.ToolStripMenuItem1, Me.menu_search, Me.mentrip_logout})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(392, 73)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'menstrp
        '
        Me.menstrp.Image = Global.InventorySystem.My.Resources.Resources.Box
        Me.menstrp.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.menstrp.Name = "menstrp"
        Me.menstrp.Size = New System.Drawing.Size(62, 69)
        Me.menstrp.Text = "Stocks"
        Me.menstrp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'mentrip_logout
        '
        Me.mentrip_logout.Image = Global.InventorySystem.My.Resources.Resources.logout
        Me.mentrip_logout.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mentrip_logout.Name = "mentrip_logout"
        Me.mentrip_logout.Size = New System.Drawing.Size(62, 69)
        Me.mentrip_logout.Text = "Logout"
        Me.mentrip_logout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmi_category, Me.tsmi_subcat})
        Me.ToolStripMenuItem1.Image = Global.InventorySystem.My.Resources.Resources.bhe
        Me.ToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(75, 69)
        Me.ToolStripMenuItem1.Text = "Categories"
        Me.ToolStripMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsmi_category
        '
        Me.tsmi_category.Name = "tsmi_category"
        Me.tsmi_category.Size = New System.Drawing.Size(145, 22)
        Me.tsmi_category.Text = "Category"
        '
        'tsmi_subcat
        '
        Me.tsmi_subcat.Name = "tsmi_subcat"
        Me.tsmi_subcat.Size = New System.Drawing.Size(145, 22)
        Me.tsmi_subcat.Text = "Sub Category"
        '
        'menu_search
        '
        Me.menu_search.Image = Global.InventorySystem.My.Resources.Resources.seer
        Me.menu_search.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.menu_search.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.menu_search.Name = "menu_search"
        Me.menu_search.Size = New System.Drawing.Size(62, 69)
        Me.menu_search.Text = "Search"
        Me.menu_search.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(392, 321)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents menstrp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mentrip_logout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmi_category As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmi_subcat As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menu_search As System.Windows.Forms.ToolStripMenuItem
End Class
