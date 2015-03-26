Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class Search
    Dim SQL As New SQLControl
    Public Con As New SqlConnection With {.ConnectionString = "Server = JOSHII-PC\SQLEXPRESS; Database = DB_Inventory; Trusted_Connection = Yes;"}
    Public Cmd As SqlCommand
    Public Dap As SqlDataAdapter
    Public Das As DataSet
    Dim dr As SqlDataReader
    Private Sub txtb_searc_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtb_search.TextChanged
        If combo_sefrom.Text = "Stock Name" Then

            Cmd = New SqlCommand("Select * from TB_Stock WHERE [Stock Name]LIKE '" + txtb_search.Text + "%'", Con)
            Dap = New SqlDataAdapter(Cmd)
            Das = New DataSet()
            Dap.Fill(Das, "DB_Inventory")

            Con.Open()
            dgrid_search.DataSource = Das.Tables("DB_Inventory").DefaultView
            Con.Close()

        ElseIf combo_sefrom.Text = "Category Name" Then
            Cmd = New SqlCommand("Select * from TB_Stock WHERE [Category]LIKE '" + txtb_search.Text + "%'", Con)
            Dap = New SqlDataAdapter(Cmd)
            Das = New DataSet()
            Dap.Fill(Das, "DB_Inventory")

            Con.Open()
            dgrid_search.DataSource = Das.Tables("DB_Inventory").DefaultView
            Con.Close()

        ElseIf combo_sefrom.Text = "Sub-Category Name" Then
            Cmd = New SqlCommand("Select * from TB_Stock WHERE [Sub-Category]LIKE '" + txtb_search.Text + "%'", Con)
            Dap = New SqlDataAdapter(Cmd)
            Das = New DataSet()
            Dap.Fill(Das, "DB_Inventory")

            Con.Open()
            dgrid_search.DataSource = Das.Tables("DB_Inventory").DefaultView
            Con.Close()
        End If
    End Sub

    Private Sub btn_back_Click(sender As System.Object, e As System.EventArgs) Handles btn_back.Click
        Dim M As New Menu
        Me.Hide()
        M.Show()
    End Sub
End Class