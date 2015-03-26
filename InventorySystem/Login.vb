Public Class Login
    Private SQL As New LoginSQL
    Private AuthUser As String
    Dim m As Menu
    
    Private Sub btn_login_Click(sender As System.Object, e As System.EventArgs) Handles btn_login.Click
        If SQL.HasConnection = True Then
            If Auth() = True Then
                AuthUser = txtb_uname.Text
                MsgBox("Login Success!")
                m = New Menu
                m.Show()
                Me.Hide()

            End If
        End If
    End Sub

    Private Function Auth() As Boolean
        If SQL.Das IsNot Nothing Then
            SQL.Das.Clear()
        End If

        SQL.Run("SELECT Count(Username) As UserCount " & _
                "FROM TB_Login " & _
                "WHERE Username ='" & txtb_uname.Text & "' " & _
                " AND Password ='" & txtb_pass.Text & "'COLLATE SQL_Latin1_General_CP1_CS_AS ")

        If SQL.Das.Tables(0).Rows(0).Item("UserCount") = 1 Then
            Return True
        End If
        MsgBox("Invalid User Credentials.", MsgBoxStyle.Critical, "Login Failed")
        Return False
    End Function
End Class