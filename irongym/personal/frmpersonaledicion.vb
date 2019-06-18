Imports MySql.Data.MySqlClient

Public Class frmpersonaledicion
    Dim adaptador As MySqlDataAdapter
    Dim datos As DataSet
    Dim comando As MySqlCommand

    Private Sub frmpersonaledicion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If operacionABM = "nuevo" Then
            txtid.Text = "0"
            txtnombre.Text = ""
            txttelefono.Text = ""
            txtdireccion.Text = ""
            txtcargo.Text = ""
        ElseIf operacionABM = "editar" Then
            Call cargarRegistros(codigoABM)

        End If
    End Sub

    Public Sub cargarRegistros(codigo As String)
        Dim sql As String
        datos = New DataSet
        sql = "select * from personal where idpersonal= " & codigo

        Try
            Call abrirConexion()
            adaptador = New MySqlDataAdapter(sql, conexion)
            adaptador.Fill(datos, "xpersonal")
            txtid.Text = datos.Tables("xpersonal").Rows(0).Item("idpersonal")
            txtnombre.Text = datos.Tables("xpersonal").Rows(0).Item("Nombre")
            txttelefono.Text = datos.Tables("xpersonal").Rows(0).Item("Telefono")
            txtdireccion.Text = datos.Tables("xpersonal").Rows(0).Item("Direccion")
            txtcargo.Text = datos.Tables("xpersonal").Rows(0).Item("Cargo")
            codigoABM = codigo
            Call cerrarConexion()

        Catch ex As MySqlException
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Dim sql As String = ""
        If operacionABM = "nuevo" Then
            sql = "insert into personal(Nombre, Telefono, Direccion, Cargo) values (@n, @t, @d, @c)"
        ElseIf operacionABM = "editar" Then
            sql = "update personal set Nombre= @n, Telefono= @t, Direccion= @d, Cargo= @c where idpersonal= @id"

        End If
        Try
            Call abrirConexion()
            comando = New MySqlCommand(sql, conexion)
            comando.Parameters.AddWithValue("@n", txtnombre.Text)
            comando.Parameters.AddWithValue("@t", txttelefono.Text)
            comando.Parameters.AddWithValue("@d", txtdireccion.Text)
            comando.Parameters.AddWithValue("@c", txtcargo.Text)
            comando.Parameters.AddWithValue("@id", txtid.Text)
            comando.ExecuteNonQuery()
            Call cerrarConexion()
            MsgBox("Guardado")
            frmpersonal.cargarlista("")
            Me.Close()

        Catch ex As MySqlException
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Me.Close()
    End Sub
End Class