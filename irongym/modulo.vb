Imports MySql.Data.MySqlClient
Module modulo
    Public operacionABM As String
    Public codigoABM As String
    Public conexion As MySqlConnection

    Public Sub abrirConexion()
        Dim url As String
        url = "server= localhost; user= root; password= ; database= gimnasio "

        Try
            conexion = New MySqlConnection
            conexion.ConnectionString = url
            conexion.Open()

        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub cerrarConexion()
        Try
            conexion.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try
    End Sub

End Module

