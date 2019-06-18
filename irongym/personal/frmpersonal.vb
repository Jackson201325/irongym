Imports MySql.Data.MySqlClient
Public Class frmpersonal
    Dim adaptador As MySqlDataAdapter
    Dim comando As MySqlCommand
    Dim datos As DataSet

    Private Sub frmpersonal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarlista("")
    End Sub
    Public Sub cargarlista(condicion As String)
        Dim sql As String
        datos = New DataSet
        sql = "select * from personal " & condicion

        Try
            Call abrirConexion()
            adaptador = New MySqlDataAdapter(sql, conexion)
            adaptador.Fill(datos, "xpersonal")
            grilla.DataSource = datos.Tables("xpersonal")
            Call cerrarConexion()

        Catch ex As MySqlException
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        Call cargarlista("where Nombre like '%" & txtbuscar.Text & "%'")
    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        operacionABM = "nuevo"
        codigoABM = "0"
        frmpersonaledicion.Show()

    End Sub

    Private Sub btneditar_Click(sender As Object, e As EventArgs) Handles btneditar.Click
        operacionABM = "editar"
        codigoABM = grilla.Item(0, grilla.CurrentRow.Index).Value
        frmpersonaledicion.Show()

    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        Dim sql As String = ""
        datos = New DataSet
        codigoABM = grilla.Item(0, grilla.CurrentRow.Index).Value

        If MsgBox("Desea eliminar", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                Call abrirConexion()
                sql = "delete from personal where idpersonal= " & codigoABM
                comando = New MySqlCommand(sql, conexion)
                comando.ExecuteNonQuery()
                Call cerrarConexion()
                MsgBox("Eliminado")
                Call cargarlista("")
            Catch ex As MySqlException
                MsgBox(ex.Message)
            End Try

        End If

    End Sub

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
End Class