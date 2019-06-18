Imports MySql.Data.MySqlClient

Public Class frmclientesedicion
    Dim datos As DataSet
    Dim adaptador As MySqlDataAdapter
    Dim comando As MySqlCommand

    Private Sub frmclientesedicion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call verificarOperacion()
    End Sub

    Public Sub verificarOperacion()
        If operacionABM = "nuevo" Then
            txtid.Text = "0"
            txtnombre.Text = ""
            txttelefono.Text = ""
            txtruc.Text = ""



        ElseIf operacionABM = "editar" Then
            Dim sql = "select * from clientes where idcliente = " & codigoABM
            Try
                Call abrirConexion()
                adaptador = New MySqlDataAdapter(sql, conexion)
                datos = New DataSet
                adaptador.Fill(datos, "xclientes")
                txtid.Text = datos.Tables("xclientes").Rows(0).Item("idcliente")
                txtnombre.Text = datos.Tables("xclientes").Rows(0).Item("nombre")
                txttelefono.Text = datos.Tables("xclientes").Rows(0).Item("telefono")
                txtruc.Text = datos.Tables("xclientes").Rows(0).Item("ruc")




                Call cerrarConexion()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Dim sql As String
        If operacionABM = "nuevo" Then
            sql = "insert into clientes(nombre,telefono,ruc) values " & "(@n,@t,@r)"
            Call abrirConexion()
            comando = New MySqlCommand(sql, conexion)
            comando.Parameters.AddWithValue("@n", txtnombre.Text)
            comando.Parameters.AddWithValue("@t", txttelefono.Text)
            comando.Parameters.AddWithValue("@r", txtruc.Text)




        ElseIf operacionABM = "editar" Then
            sql = "update clientes set nombre= @n,telefono= @t, ruc= @r " & "where idcliente=@id"
            Call abrirConexion()
            comando = New MySqlCommand(sql, conexion)
            comando.Parameters.AddWithValue("@n", txtnombre.Text)
            comando.Parameters.AddWithValue("@t", txttelefono.Text)
            comando.Parameters.AddWithValue("@r", txtruc.Text)

            comando.Parameters.AddWithValue("@id", txtid.Text)
        End If
        comando.ExecuteNonQuery()
        MsgBox("Guardado")
        frmclientes.cargarGrilla("")
        Call cerrarConexion()
        Me.Close()

    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Dispose()
    End Sub


End Class