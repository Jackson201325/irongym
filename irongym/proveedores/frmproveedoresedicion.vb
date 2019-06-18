Imports MySql.Data.MySqlClient

Public Class frmproveedoresedicion
    Dim adaptador As MySqlDataAdapter
    Dim datos As DataSet
    Dim comando As MySqlCommand

    Private Sub frmproveedoresedicion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If operacionABM = "nuevo" Then
            txtid.Text = "0"
            txtnombre.Text = ""
            txtruc.Text = ""
            txttelefono.Text = ""
        ElseIf operacionABM = "editar" Then
            Call cargarregistros(codigoABM)

        End If
    End Sub
    Private Sub cargarregistros(codigo As String)
        Dim sql As String = ""
        datos = New DataSet
        sql = "select * from proveedor where idproveedor= " & codigo
        Try
            Call abrirConexion()
            adaptador = New MySqlDataAdapter(sql, conexion)
            adaptador.Fill(datos, "xproveedor")
            txtid.Text = datos.Tables("xproveedor").Rows(0).Item("idproveedor")
            txtnombre.Text = datos.Tables("xproveedor").Rows(0).Item("nombre")
            txtruc.Text = datos.Tables("xproveedor").Rows(0).Item("ruc")
            txtdireccion.Text = datos.Tables("xproveedor").Rows(0).Item("direccion")
            txttelefono.Text = datos.Tables("xproveedor").Rows(0).Item("telefono")
            codigoABM = codigo
            Call cerrarConexion()

        Catch ex As MySqlException
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Dim sql As String = ""
        If operacionABM = "nuevo" Then
            sql = "insert into proveedor(nombre, RUC, Direccion, Telefono) values (@n, @r, @d, @t)"

        ElseIf operacionABM = "editar" Then
            sql = "update proveedor set nombre= @n ,RUC= @r ,Direccion= @d ,Telefono= @t where idproveedor= @id"

        End If
        Try
            Call abrirConexion()
            comando = New MySqlCommand(sql, conexion)
            comando.Parameters.AddWithValue("@n", txtnombre.Text)
            comando.Parameters.AddWithValue("@r", txtruc.Text)
            comando.Parameters.AddWithValue("@d", txtdireccion.Text)
            comando.Parameters.AddWithValue("@t", txttelefono.Text)
            comando.Parameters.AddWithValue("@id", txtid.Text)
            comando.ExecuteNonQuery()
            Call cerrarConexion()
            MsgBox("Guardado")
            frmproveedores.cargarlista("")
            Me.Close()



        Catch ex As MySqlException
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Me.Close()

    End Sub


End Class