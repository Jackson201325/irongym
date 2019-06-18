Imports MySql.Data.MySqlClient
Public Class usuariolista
    Dim adaptador As MySqlDataAdapter
    Dim datos As DataSet
    Dim comando As MySqlCommand
    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        If MsgBox("¿Desea Salir?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            frmMenu.Show()
            Me.Close()

        End If
    End Sub

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        If MsgBox("¿Desea Salir?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            frmMenu.Show()
            Me.Close()

        End If
    End Sub

    Private Sub usuariolista_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarLista("")
    End Sub
    Public Sub cargarLista(condicion As String)
        Dim sql As String
        datos = New DataSet
        sql = "select * from usuario " & condicion

        Try
            Call abrirConexion()
            adaptador = New MySqlDataAdapter(sql, conexion)
            adaptador.Fill(datos, "xusuario")
            grilla.DataSource = datos.Tables("xusuario")
            Call cerrarConexion()

        Catch ex As MySqlException
            MsgBox(ex.Message)


        End Try

    End Sub

    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        Call cargarLista("where nombre like '%" & txtbuscar.Text & "%'")

    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        operacionABM = "nuevo"
        codigoABM = "0"
        usuarioedicion.Show()

    End Sub

    Private Sub btneditar_Click(sender As Object, e As EventArgs) Handles btneditar.Click
        operacionABM = "editar"
        codigoABM = grilla.Item(0, grilla.CurrentRow.Index).Value
        usuarioedicion.Show()

    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        Dim sql As String = ""
        datos = New DataSet
        codigoABM = grilla.Item(0, grilla.CurrentRow.Index).Value
        If MsgBox("¿Desea eliminar?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                Call abrirConexion()
                sql = "delete from usuario where idusuario= " & codigoABM
                comando = New MySqlCommand(sql, conexion)
                comando.ExecuteNonQuery()
                Call cerrarConexion()
                MsgBox("Eliminado")
                Call cargarLista("")
            Catch ex As MySqlException
                MsgBox(ex.Message)


            End Try

        End If
    End Sub
End Class