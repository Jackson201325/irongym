Imports MySql.Data.MySqlClient
Public Class frmclientes
    Dim adaptador As MySqlDataAdapter
    Dim comando As MySqlCommand
    Dim datos As DataSet

    Private Sub frmclientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call cargarGrilla("")
    End Sub

    Public Sub cargarGrilla(condicion As String)
        Dim sql As String = "select * from clientes " & condicion

        Try
            Call abrirConexion()
            adaptador = New MySqlDataAdapter(sql, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "xclientes")
            grilla.DataSource = datos.Tables(0)

            Call cerrarConexion()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        operacionABM = "nuevo"
        codigoABM = ""
        frmclientesedicion.Show()

    End Sub

    Private Sub btneditar_Click(sender As Object, e As EventArgs) Handles btneditar.Click
        operacionABM = "editar"
        codigoABM = grilla.Item(0, grilla.CurrentRow.Index).Value

        frmclientesedicion.Show()

    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        Dim sql As String = ""
        datos = New DataSet
        codigoABM = grilla.Item(0, grilla.CurrentRow.Index).Value

        If MsgBox("Desea eliminar", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                Call abrirConexion()
                sql = "delete from clientes where idcliente= " & codigoABM
                comando = New MySqlCommand(sql, conexion)
                comando.ExecuteNonQuery()
                Call cerrarConexion()
                MsgBox("Eliminado")
                Call cargarGrilla("")
            Catch ex As Exception
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

    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        Call cargarGrilla("where Nombre like '%" & txtbuscar.Text & "%'")
    End Sub

    Private Sub btncerrar_Click(sender As Object, e As EventArgs)
        If MsgBox("¿Desea Salir?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            frmMenu.Show()
            Me.Close()

        End If
    End Sub

    Private Sub btncerrar_Click_1(sender As Object, e As EventArgs) Handles btncerrar.Click
        If MsgBox("¿Desea Salir?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            frmMenu.Show()
            Me.Close()

        End If
    End Sub
End Class