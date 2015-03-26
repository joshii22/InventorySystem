Public Class Menu

    Private Sub menstrp_Click(sender As System.Object, e As System.EventArgs) Handles menstrp.Click
        Dim stck As Stock
        stck = New Stock
        stck.Show()
        Me.Hide()
    End Sub

    Private Sub mentrip_logout_Click(sender As System.Object, e As System.EventArgs) Handles mentrip_logout.Click
        Dim Lgin As Login
        Lgin = New Login
        Lgin.Show()
        Me.Hide()
    End Sub

    Private Sub tsmi_category_Click(sender As System.Object, e As System.EventArgs) Handles tsmi_category.Click
        Me.Hide()
        Category.Show()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles tsmi_subcat.Click
        Me.Hide()
        SubCategory.Show()
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As System.Object, e As System.EventArgs) Handles menu_search.Click
        Dim serc As Search
        serc = New Search
        serc.Show()
        Me.Hide()
    End Sub
End Class