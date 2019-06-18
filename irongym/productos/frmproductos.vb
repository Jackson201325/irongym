Imports MySql.Data.MySqlClient
Public Class frmproductos
    Dim datos As New DataSet
    Dim adaptador As MySqlDataAdapter
    Dim comando As MySqlCommand
    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click

        operacionABM = "nuevo"
        frmproductoedicion.Show()
    End Sub

    Private Sub frmproductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call cargarTabla("")
    End Sub
    Public Sub cargarTabla(condicion As String)
        Dim sql As String
        Dim datos As New DataSet
        sql = "select * from vistproductos " & condicion

        Try
            Call abrirConexion()
            adaptador = New MySqlDataAdapter(sql, conexion)
            adaptador.Fill(datos)
            grilla.DataSource = datos.Tables(0)
            Call cerrarConexion()

        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub grilla_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grilla.CellClick
        Dim ruta As String
        Dim codigo As String
        codigo = grilla.Item(0, grilla.CurrentRow.Index).Value
        ruta = "C:/Users/david/source/repos/irongym/irongym/Imagen/" & codigo & ".jpg"

        Try
            picimagen.Image = Image.FromFile(ruta)
        Catch ex As Exception
            ruta = "C:/Users/david/source/repos/irongym/irongym/Imagen/nofoto.jpg"
            picimagen.Image = Image.FromFile(ruta)

        End Try
    End Sub
    Private Sub cargarcondicion()
        Dim condicion As String
        condicion = ""
        If (cbo.SelectedItem = "Codigo") Then
            condicion = " where idproductos='" & txtbuscar.Text & "'"
        ElseIf (cbo.SelectedItem = "Descripcion") Then
            condicion = " where descripcion like '%" & txtbuscar.Text & "%'"
        ElseIf (cbo.SelectedItem = "Marca") Then
            condicion = " where marca like '%" & txtbuscar.Text & "%'"
        ElseIf (cbo.SelectedItem = "Proveedor") Then
            condicion = " where proveedor like '%" & txtbuscar.Text & "%'"
        End If
        Call cargarTabla(condicion)
    End Sub

    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        Call cargarcondicion()
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

    Private Sub btneditar_Click(sender As Object, e As EventArgs) Handles btneditar.Click
        operacionABM = "editar"
        codigoABM = grilla.Item(0, grilla.CurrentRow.Index).Value
        frmproductoedicion.Show()

    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        Dim sql As String
        Dim codigo As Integer
        Dim comando As New MySqlCommand
        codigo = grilla.Item(0, grilla.CurrentRow.Index).Value
        Try
            If MsgBox("¿Desea eliminar?", vbYesNo, "confirmar") = MsgBoxResult.Yes Then
                sql = "delete from productos where idproductos= " & codigo
                abrirConexion()
                comando = New MySqlCommand(sql, conexion)
                comando.ExecuteNonQuery()
                MsgBox("Eliminado")
                Call cargarTabla("")
            End If
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try
    End Sub
End Class