Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class Stock
    Private SQL As New SQLControl
    Private SQLCat As New CatSQL
    Public Con As New SqlConnection With {.ConnectionString = "Server = JOSHII-PC\SQLEXPRESS; Database = DB_Inventory; Trusted_Connection = Yes;"}
    Public Cmd As SqlCommand
    Public Dap As SqlDataAdapter
    Public Das As DataSet
    Dim dr As SqlDataReader

    Private Sub btn_insert_Click(sender As System.Object, e As System.EventArgs) Handles btn_insert.Click
        Dim timeToday = DateTime.Now.ToLongTimeString()
        Dim dateToday = DateTime.Now.ToShortDateString()

        Con.Open()
        Cmd = New SqlCommand("Insert into TB_Stock values('" + txtStock_ID.Text + "', '" + txtS_name.Text + "', '" + combo_category.Text + "', '" + combo_subcat.Text + "', '" + txt_qty.Text + "', '" + dateToday + "', '" + timeToday + "')", Con)
        Dap = New SqlDataAdapter(Cmd)
        Das = New DataSet()
        Dap.Fill(Das, "DB_Inventory")
        Con.Close()

        'SQL.RunQuery("SELECT * FROM TB_Stocks WHERE [Stock ID] = '" & txtStock_ID.Text & "' , [Stock Name] = '" & txtS_name.Text & "', Category = '" & combo_category.Text & "' , Quantity = '" & txt_qty.Text & "' , Date = '" & dateToday & "' Time = '" & timeToday & "' ")

        'If SQL.Das.Tables(0).Rows.Count > 0 Then
        '    MsgBox("Stock ID or Stock Name already exist!")
        '    Exit Sub
        'Else
        '    AddValu()
        'End If
        ViewStocks()
        ClearText()

    End Sub
    'Public Sub AddValu()
    '    Dim timeToday = DateTime.Now.ToLongTimeString()
    '    Dim dateToday = DateTime.Now.ToShortDateString()

    '    If Len(txtStock_ID) < 20 And Len(txtS_name) < 20 And Len(combo_category) < 20 And Len(txt_qty) < 20 Then

    '        SQL.DataInsert(txtStock_ID.Text, txtS_name.Text, combo_category.Text, txt_qty.Text, dateToday, timeToday)
    '    Else
    '        MsgBox("Inputed values is too short")
    '    End If

    'End Sub

    Public Sub ClearText()
        txtStock_ID.Text = ""
        txtS_name.Text = ""
        txt_qty.Text = ""
        combo_category.Text = ""
        combo_subcat.Text = ""
    End Sub

    Public Sub ViewStocks()

        Cmd = New SqlCommand("Select * from TB_Stock", Con)
        Dap = New SqlDataAdapter(Cmd)
        Das = New DataSet()
        Dap.Fill(Das, "DB_Inventory")

        Con.Open()
        grid_stocks.DataSource = Das.Tables("DB_Inventory").DefaultView
        Con.Close()
    End Sub

    Public Sub ComboCategory()
        combo_category.Items.Clear()
        SQLCat.ExecQuery("SELECT [Category Name] FROM TB_Category")

        If String.IsNullOrEmpty(SQLCat.Exception) Then
            For Each Rw As DataRow In SQLCat.Das.Tables(0).Rows
                combo_category.Items.Add(Rw("Category Name"))
            Next
            combo_category.SelectedIndex = 0
        Else
            MsgBox(SQLCat.Exception, MsgBoxStyle.Critical, "SQL ERROR!")
        End If
    End Sub

    Public Sub GetSub()
        combo_subcat.Items.Clear()
        SQLCat.AddParam("@CatName", combo_category.Text)
        SQLCat.ExecQuery("SELECT DISTINCT [Sub Name] FROM TB_SubCategory WHERE [Category Name] = @CatName")

        If String.IsNullOrEmpty(SQLCat.Exception) Then
            For Each Rw As DataRow In SQLCat.Das.Tables(0).Rows
                combo_subcat.Items.Add(Rw("Sub Name"))
            Next

            ' SET THE COMBOBOX TO FIRST RECORD
            combo_subcat.SelectedIndex = 0
        Else
            MsgBox(SQLCat.Exception, MsgBoxStyle.Critical, "SQL ERROR!")
        End If
    End Sub

    Private Sub combo_category_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles combo_category.SelectedIndexChanged
        ' IF A FOOD TYPE IS SELECTED SEARCH FOR MATCHING FOODS
        If Not String.IsNullOrEmpty(combo_category.Text) Then GetSub()
    End Sub

    Private Sub btn_gotom_Click(sender As System.Object, e As System.EventArgs) Handles btn_gotom.Click
        Dim M As Menu
        M = New Menu
        M.Show()
        Me.Hide()
    End Sub

    Private Sub btn_delete_Click(sender As System.Object, e As System.EventArgs) Handles btn_delete.Click
        Con.Open()

        If txtStock_ID.Text <> "" Then
            If MsgBox("Do you really wish to delete ID " & txtStock_ID.Text & " ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

                SQL.DataDelete("DELETE FROM TB_Stock WHERE [Stock ID] ='" & txtStock_ID.Text & "' ")
            End If
        End If
        Con.Close()
        ViewStocks()
        ClearText()
    End Sub

    Private Sub btn_clear_Click(sender As System.Object, e As System.EventArgs) Handles btn_clear.Click
        ClearText()
    End Sub

    Private Sub btn_update_Click(sender As System.Object, e As System.EventArgs) Handles btn_update.Click
        Dim uptimeToday = DateTime.Now.ToLongTimeString()
        Dim updateToday = DateTime.Now.ToShortDateString()

        If txtStock_ID.Text <> "" Then
            If txtS_name.Text.Length < 21 And combo_category.Text.Length < 21 And combo_subcat.Text.Length < 21 And txt_qty.Text.Length < 7 Then
                Dim UpdateCmd As String = "UPDATE TB_Stock SET [Stock Name] = '" + txtS_name.Text + "',Category = '" + combo_category.Text + "',[Sub-Category] = '" + combo_subcat.Text + "',Quantity = '" + txt_qty.Text + "',Date = '" + updateToday + "',Time = '" + uptimeToday + "' WHERE [Stock ID] = '" + txtStock_ID.Text + "' "

                If SQL.DataUpdate(UpdateCmd) = 0 Then
                    MsgBox("The specified values could not be found.")
                Else
                    MsgBox("Values succesfuly change for ID " & txtStock_ID.Text & ".")
                End If
            Else
                MsgBox("Inputed values is too short")
            End If
        Else
            MsgBox("You must provide updated values")
        End If

        ViewStocks()
        ClearText()
    End Sub

    Private Sub Stock_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ViewStocks()
        ComboCategory()
        ClearText()
    End Sub
End Class
