Friend Class OleDbConnection
    Private v As String

    Public Sub New(v As String)
        Me.v = v
    End Sub

    Friend Sub Open()
        Throw New NotImplementedException()
    End Sub
End Class
