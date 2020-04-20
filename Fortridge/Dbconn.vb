Imports System.Data.SQLite
Public Class Dbconn
    Public Shared connect As SQLiteConnection ' declare the connection
    Public Shared Command As SQLiteCommand
    Public Shared da As SQLiteDataAdapter
    Public Shared dt As DataTable
    Public Shared Sub Connection()
        Try
            connect = New SQLiteConnection("Data Source=footridgedb.db") ' Connection DataSource
            If connect.State = ConnectionState.Closed Then
                connect.Open()
                ' MsgBox("Connection Success!", MsgBoxStyle.Information, "Informations")
            End If
        Catch ex As Exception
            MsgBox("Failed to connect to the  Database", MsgBoxStyle.Information, "Warning")
        End Try
    End Sub
End Class
