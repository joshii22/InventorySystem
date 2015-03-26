Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class SQLControl
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

    Public Sub RunQuery(Query As String)
        Try
            Con.Open()

            Cmd = New SqlCommand(Query, Con)

            ' LOAD SQL RECORDS FOR DATAGRID
            Dap = New SqlDataAdapter(Cmd)
            Das = New DataSet
            Dap.Fill(Das)
            ' READ DIRECTLY FROM DATABASE
            'Dim R As SqlDataReader = Cmd.ExecuteReader

            'While R.Read
            'MsgBox(R.GetName(0) & ": " & R(0))
            'End While

            Con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)

            If Con.State = ConnectionState.Open Then
                Con.Close()
            End If
        End Try
    End Sub

    'Public Sub DataInsert(StockID As Integer, StockName As String, Category As String, Quantity As Integer, Dat As String, Time As Integer)
    '    Try
    '        Dim AddVal As String = "INSERT INTO TB_Stocks([Stock ID], [Stock Name], Category, Quantity) VALUES ('" & StockID & "', '" & StockName & "', '" & Category & "', '" & Quantity & "', '" & Dat & "', '" & Time & "')"
    '        MsgBox(AddVal)

    '        Con.Open()
    '        Cmd = New SqlCommand(AddVal, Con)

    '        Cmd.ExecuteNonQuery()
    '        Con.Close()
    '    Catch ex As Exception

    '    End Try

    'End Sub

    Public Sub DataDelete(Command As String)

        Try
            Con.Open()

            Cmd = New SqlCommand(Command, Con)

            Dim ChangeCount As Integer = Cmd.ExecuteNonQuery

            Con.Close()

            'REPORT(RESULTS)

            If ChangeCount = 0 Then

                MsgBox("The Item you want to update could not be found.")

            Else

                MsgBox(ChangeCount & " Record(s) Affected! ")

            End If

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
    End Sub

    Public Function DataUpdate(Command As String) As Integer

        Try
            Con.Open()

            Cmd = New SqlCommand(Command, Con)

            Dim ChangeCount As Integer = Cmd.ExecuteNonQuery

            Con.Close()
            Return ChangeCount

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
        Return 0
    End Function
End Class
