Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class SubCategory
    Dim SQL As New SQLControl
    Public Con As New SqlConnection With {.ConnectionString = "Server = JOSHII-PC\SQLEXPRESS; Database = DB_Inventory; Trusted_Connection = Yes;"}
    Public Cmd As SqlCommand
    Public Dap As SqlDataAdapter
    Public Das As DataSet
    Dim dr As SqlDataReader

    Private Sub btn_insert_Click(sender As System.Object, e As System.EventArgs) Handles btn_insert.Click

        Con.Open()
        Cmd = New SqlCommand("INSERT INTO TB_SubCategory values('" + txtb_SubID.Text + "', '" + combo_catnam.Text + "', '" + txtb_SubName.Text + "')", Con)
        Dap = New SqlDataAdapter(Cmd)
        Das = New DataSet()
        Dap.Fill(Das, "DB_Inventory")
        Con.Close()

        ViewCategory()
        Clear()

    End Sub

    Public Sub ViewCategory()

        Cmd = New SqlCommand("Select * from TB_SubCategory", Con)
        Dap = New SqlDataAdapter(Cmd)
        Das = New DataSet()
        Dap.Fill(Das, "DB_Inventory")

        Con.Open()
        grid_category.DataSource = Das.Tables("DB_Inventory").DefaultView
        Con.Close()
    End Sub

    Private Sub Category_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DB_InventoryDataSet2.TB_Category' table. You can move, or remove it, as needed.
        Me.TB_CategoryTableAdapter1.Fill(Me.DB_InventoryDataSet2.TB_Category)
        Clear()
        ViewCategory()
    End Sub

    Private Sub btn_delete_Click(sender As System.Object, e As System.EventArgs) Handles btn_delete.Click
        Con.Open()

        If txtb_SubID.Text <> "" Then
            If MsgBox("Do you really wish to delete " & txtb_SubID.Text & " ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

                SQL.DataDelete("DELETE FROM TB_SubCategory WHERE [Sub ID] ='" & txtb_SubID.Text & "' ")
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
        Clear()
    End Sub

    Public Sub Clear()
        txtb_SubID.Text = ""
        combo_catnam.Text = ""
        txtb_SubName.Text = ""
    End Sub

    Private Sub btn_update_Click(sender As System.Object, e As System.EventArgs) Handles btn_update.Click
        If txtb_SubID.Text <> "" Then
            If combo_catnam.Text.Length < 21 And txtb_SubName.Text.Length < 21 Then
                Dim UpdateCmd As String = "UPDATE TB_SubCategory SET [Category Name] = '" & combo_catnam.Text & "', [Sub Name] = '" & txtb_SubName.Text & "' WHERE [Sub ID] = '" & txtb_SubID.Text & "' "

                If SQL.DataUpdate(UpdateCmd) = 0 Then
                    MsgBox("The specified values could not be found.")
                Else
                    MsgBox("Values succesfuly change for ID " & txtb_SubID.Text & ".")
                End If
            Else
                MsgBox("Inputed values is too short")
            End If
        Else
            MsgBox("You must provide updated values")
        End If
        Clear()
        ViewCategory()
    End Sub
End Class