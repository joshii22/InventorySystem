Public Class Query
        Dim SQL As New SQLControl
    Private Sub Login_Load(sender As System.Object, e As System.EventArgs)
        'If SQL.HasConnection = True Then
        ''MsgBox("Successful Connection!")
        'SQL.RunQuery("SELECT Username FROM TB_Login")
        'End If
    End Sub

        Private Sub btn_Query_Click_1(sender As System.Object, e As System.EventArgs) Handles btn_Query.Click
            If txtb_Query.Text <> "" Then
                If SQL.HasConnection = True Then
                    SQL.RunQuery(txtb_Query.Text)

                    If SQL.Das.Tables.Count > 0 Then
                    grid_query.DataSource = SQL.Das.Tables(0)
                    End If
                End If
            End If
        End Sub
End Class