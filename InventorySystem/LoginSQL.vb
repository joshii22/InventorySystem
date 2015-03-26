Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class LoginSQL
    Public Con As New SqlConnection With {.ConnectionString = "Server = JOSHII-PC\SQLEXPRESS; Database = DB_Inventory; Trusted_Connection = Yes;"}
    Public Cmd As SqlCommand
    Public Dap As SqlDataAdapter
    Public Das As DataSet

    Public Function HasConnection() As Boolean
        Try
            Con.Open()

            Con.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Sub Run(Query As String)
        Try
            Con.Open()

            'CREATE COMMAND
            Cmd = New SqlCommand(Query, Con)

            'FILL DATASET
            Dap = New SqlDataAdapter(Cmd)
            Das = New DataSet
            Dap.Fill(Das)
            Con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)

            'MAKE SURE CONNECTION IS CLOSED
            If Con.State = ConnectionState.Open Then
                Con.Close()
            End If

        End Try
    End Sub
End Class
