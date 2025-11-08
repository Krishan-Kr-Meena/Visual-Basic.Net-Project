Friend Class OleDbCommand
    Private query As String
    Private con As OleDbConnection

    Public Sub New(query As String, con As OleDbConnection)
        Me.query = query
        Me.con = con
    End Sub

    Friend Function Parameters() As Object
        Throw New NotImplementedException()
    End Function

    Friend Function ExecuteReader() As OleDbDataReader
        Throw New NotImplementedException()
    End Function
End Class
