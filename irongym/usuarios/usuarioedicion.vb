Imports MySql.Data.MySqlClient
Public Class usuarioedicion
    Dim adaptador As MySqlDataAdapter
    Dim datos As DataSet
    Dim comando As MySqlCommand

    Private Sub usuarioedicion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If operacionABM = "nuevo" Then
            txtid.Text = "0"
            txtuser.Text = ""
            txtcontraseña.Text = ""
        ElseIf operacionABM = "editar" Then
            Call cargarRegistros(codigoABM)

        End If
    End Sub
    Public Sub cargarRegistros(codigo As String)
        Dim sql As String = ""
        datos = New DataSet
        sql = "select * from usuario where idusuario= " & codigo
        Try
            Call abrirConexion()
            adaptador = New MySqlDataAdapter(sql, conexion)
            adaptador.Fill(datos, "xusuario")
            txtid.Text = datos.Tables("xusuario").Rows(0).Item("idusuario")
            txtuser.Text = datos.Tables("xusuario").Rows(0).Item("user")
            txtcontraseña.Text = datos.Tables("xusuario").Rows(0).Item("password")
            txtnombre.Text = datos.Tables("xusuario").Rows(0).Item("nombre")
            codigoABM = codigo
            Call cerrarConexion()

        Catch ex As MySqlException
            MsgBox(ex.Message)


        End Try
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Dim sql As String = ""
        If operacionABM = "nuevo" Then
            sql = "insert into usuario (user, password, nombre) values (@us, @pas, @no)"
        ElseIf operacionABM = "editar" Then
            sql = "update usuario set user= @us, password= @pas ,nombre= @no where idusuario= @id"

        End If
        Try
            Call abrirConexion()
            comando = New MySqlCommand(sql, conexion)
            comando.Parameters.AddWithValue("@us", txtuser.Text)
            comando.Parameters.AddWithValue("@pas", txtcontraseña.Text)
            comando.Parameters.AddWithValue("@no", txtnombre.Text)
            comando.Parameters.AddWithValue("@id", txtid.Text)
            comando.ExecuteNonQuery()
            MsgBox("Guardado")
            usuariolista.cargarLista("")
            Me.Close()

        Catch ex As MySqlException
            MsgBox(ex.Message)


        End Try
    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Me.Close()

    End Sub
End Class