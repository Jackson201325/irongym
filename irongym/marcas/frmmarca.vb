Imports MySql.Data.MySqlClient
Public Class frmmarca
    Dim adaptador As MySqlDataAdapter
    Dim comando As MySqlCommand
    Dim datos As DataSet

    Private Sub frmmarca_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call cargarLista("")
    End Sub
    Public Sub cargarLista(condicion As String)
        Dim sql As String
        datos = New DataSet
        sql = "select * from marca " & condicion

        Try
            Call abrirConexion()
            adaptador = New MySqlDataAdapter(sql, conexion)
            adaptador.Fill(datos, "xmarca")
            grilla.DataSource = datos.Tables("xmarca")
            Call cerrarConexion()

        Catch ex As MySqlException
            MsgBox(ex.Message)

        End Try

    End Sub
    Private Sub cargarcondicion()
        Dim condicion As String
        condicion = ""

        If (cbo.SelectedItem = "Descripcion") Then
            condicion = " where descripcion like '%" & txtbuscar.Text & "%'"

        ElseIf (cbo.SelectedItem = "Proveedor") Then
            condicion = " where proveedor like '%" & txtbuscar.Text & "%'"
        End If
        Call cargarLista(condicion)
    End Sub

    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        Call cargarcondicion()
    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        operacionABM = "nuevo"
        codigoABM = "0"
        frmmarcaedicion.Show()

    End Sub

    Private Sub btneditar_Click(sender As Object, e As EventArgs) Handles btneditar.Click
        operacionABM = "editar"
        codigoABM = grilla.Item(0, grilla.CurrentRow.Index).Value
        frmmarcaedicion.Show()
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        Dim sql As String = ""
        datos = New DataSet
        codigoABM = grilla.Item(0, grilla.CurrentRow.Index).Value

        If MsgBox("Desea eliminar", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                Call abrirConexion()
                sql = "delete from marca where id= " & codigoABM
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

    Private Sub grilla_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grilla.CellContentClick

    End Sub
End Class