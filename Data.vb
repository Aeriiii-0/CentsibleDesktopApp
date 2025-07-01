Imports System.Data.SqlClient

Public Class SqlServerConnector
    Private ReadOnly connectionString As String

    Public Sub New(server As String, database As String, useIntegratedSecurity As Boolean, Optional userId As String = "", Optional password As String = "")
        If useIntegratedSecurity Then
            connectionString = $"Server={server};Database={database};Integrated Security=True;"
        Else
            connectionString = $"Server={server};Database={database};User Id={userId};Password={password};"
        End If
    End Sub

    Public Function GetConnection() As SqlConnection
        Return New SqlConnection(connectionString)
    End Function

    Public Function ExecuteScalar(query As String, parameters As Dictionary(Of String, Object)) As Object
        Using conn As SqlConnection = GetConnection()
            Using cmd As New SqlCommand(query, conn)
                If parameters IsNot Nothing Then
                    For Each param In parameters
                        cmd.Parameters.AddWithValue(param.Key, param.Value)
                    Next
                End If
                conn.Open()
                Return cmd.ExecuteScalar()
            End Using
        End Using
    End Function

    Public Sub ExecuteNonQuery(query As String, parameters As Dictionary(Of String, Object))
        Using conn As SqlConnection = GetConnection()
            Using cmd As New SqlCommand(query, conn)
                If parameters IsNot Nothing Then
                    For Each param In parameters
                        cmd.Parameters.AddWithValue(param.Key, param.Value)
                    Next
                End If
                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Function ExecuteReader(query As String, parameters As Dictionary(Of String, Object)) As DataTable
        Using conn As SqlConnection = GetConnection()
            Using cmd As New SqlCommand(query, conn)
                If parameters IsNot Nothing Then
                    For Each param In parameters
                        cmd.Parameters.AddWithValue(param.Key, param.Value)
                    Next
                End If
                conn.Open()
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    Dim dt As New DataTable()
                    dt.Load(reader)
                    Return dt
                End Using
            End Using
        End Using
    End Function
End Class
