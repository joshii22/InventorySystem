Imports System.Data
Imports System.Data.SqlClient

Public Class CatSQL
    ' SQL CONNECTION
    Private Con As New SqlConnection With {.ConnectionString = "Server = JOSHII-PC\SQLEXPRESS; Database = DB_Inventory; Trusted_Connection = Yes;"}
    Private Cmd As SqlCommand

    ' SQL DATA
    Public Dap As SqlDataAdapter
    Public Das As DataSet

    ' QUERY PARAMETERS
    Public Params As New List(Of SqlParameter)

    ' QUERY STATISTICS
    Public RecordCount As Integer
    Public Exception As String

    Public Sub ExecQuery(Query As String)
        ' RESET EXCEPTIONS AND RECORD COUNT FOR NEW QUERY
        RecordCount = 0
        Exception = ""

        Try
            Con.Open()

            ' CREATE SQL COMMAND
            Cmd = New SqlCommand(Query, Con)

            ' LOAD PARAMETERS INTO SQL COMMAND
            Params.ForEach(Sub(x) Cmd.Parameters.Add(x))

            ' CLEAR PARAMETER LIST
            Params.Clear()

            ' EXECUTE COMMAND AND FILL DATASET
            Das = New DataSet
            Dap = New SqlDataAdapter(Cmd)
            RecordCount = Dap.Fill(Das)

            Con.Close()
        Catch ex As SqlException
            Exception = ex.Message
        End Try

        If Con.State = ConnectionState.Open Then Con.Close()
    End Sub

    Public Sub AddParam(Name As String, Value As Object)
        Dim NewParam As New SqlParameter(Name, Value)
        Params.Add(NewParam)
    End Sub
End Class
