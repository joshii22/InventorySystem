Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class Category
    Dim SQL As New SQLControl
    Public Con As New SqlConnection With {.ConnectionString = "Server = JOSHII-PC\SQLEXPRESS; Database = DB_Inventory; Trusted_Connection = Yes;"}
    Public Cmd As SqlCommand
    Public Dap As SqlDataAdapter
    Public Das As DataSet
    Dim dr As SqlDataReader

    Private Sub btn_insert_Click(sender As System.Object, e As System.EventArgs) Handles btn_insert.Click
        Dim timeToday = DateTime.Now.ToLongTimeString()
        Dim dateToday = DateTime.Now.ToShortDateString()

        Con.Open()
        Cmd = New SqlCommand("INSERT INTO TB_Category values('" + txtb_CatID.Text + "', '" + txtb_CatNam.Text + "')", Con)
        Dap = New SqlDataAdapter(Cmd)
        Das = New DataSet()
        Dap.Fill(Das, "DB_Inventory")
        Con.Close()

        ViewCategory()
        Clear()
    End Sub

    Public Sub ViewCategory()

        Cmd = New SqlCommand("Select * from TB_Category", Con)
        Dap = New SqlDataAdapter(Cmd)
        Das = New DataSet()
        Dap.Fill(Das, "DB_Inventory")

        Con.Open()
        grid_category.DataSource = Das.Tables("DB_Inventory").DefaultView
        Con.Close()
    End Sub

    Private Sub Category_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ViewCategory()
    End Sub

    Private Sub btn_delete_Click(sender As System.Object, e As System.EventArgs) Handles btn_delete.Click
        Con.Open()

        If txtb_CatID.Text <> "" Then
            If MsgBox("Do you really wish to delete " & txtb_CatID.Text & " ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

                SQL.DataDelete("DELETE FROM TB_Category WHERE [Category ID] ='" & txtb_CatID.Text & "' ")
            End If
        End If
        Con.Close()
        ViewCategory()
        Clear()
    End Sub

    Private Sub btn_gotom_Click(sender As System.Object, e As System.EventArgs) Handles btn_gotom.Click
        Dim b As New Menu
        b.Show()
        Me.Hide()
    End Sub

    Private Sub btn_clear_Click(sender As System.Object, e As System.EventArgs) Handles btn_clear.Click
        txtb_CatID.Text = ""
        txtb_CatNam.Text = ""
    End Sub

    Private Sub btn_update_Click(sender As System.Object, e As System.EventArgs) Handles btn_update.Click

        If txtb_CatID.Text <> "" Then
            If txtb_CatNam.Text.Length < 21 Then
                Dim UpdateCmd As String = "UPDATE TB_Category SET [Category Name] = '" + txtb_CatNam.Text + "' WHERE [Category ID] = '" + txtb_CatID.Text + "' "

                If SQL.DataUpdate(UpdateCmd) = 0 Then
                    MsgBox("The specified values could not be found.")
                Else
                    MsgBox("Values succesfuly change for ID " & txtb_CatID.Text & ".")
                End If
            Else
                MsgBox("Inputed values is too short")
            End If
        Else
            MsgBox("You must provide updated values")
        End If

        ViewCategory()
        Clear()
    End Sub
    Public Sub Clear()
        txtb_CatID.Text = ""
        txtb_CatNam.Text = ""
    End Sub
End Class