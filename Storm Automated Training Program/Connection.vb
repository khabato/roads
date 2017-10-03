Imports System.Data.SqlClient
Public Class Connection
    Public Shared Function getConnection() As SqlConnection
        Return New SqlConnection(ConfigurationManager.ConnectionStrings("DefaultConnection").ConnectionString)
    End Function
End Class