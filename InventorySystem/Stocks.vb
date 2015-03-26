Public Class Stocks
    Private SQL As New CatSQL
    Private Sub Stocks_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        GetCategory()
    End Sub

    Private Sub GetCategory()
        SQL.ExecQuery("SELECT [Category Name] FROM TB_Category")

        If SQL.RecordCount > 0 Then
            For Each Rw As DataRow In SQL.Das.Tables(0).Rows
                combo_category.Items.Add(Rw("Category Name"))
            Next
            combo_category.SelectedIndex = 0
        ElseIf SQL.Exception <> "" Then
            MsgBox(SQL.Exception)
        End If
    End Sub
End Class