Imports MySql.Data.MySqlClient
Public Class frmmarcaedicion
    Dim adaptador As MySqlDataAdapter
    Dim datos As DataSet
    Dim comando As MySqlCommand

    Private Sub frmmarcaedicion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If operacionABM = "nuevo" Then
            txtid.Text = "0"
            txtdescripcion.Text = ""

        ElseIf operacionABM = "editar" Then
            Call cargarRegistros(codigoABM)

        End If

    End Sub
    Public Sub cargarRegistros(codigo As String)
        Dim sql As String = ""
        datos = New DataSet
        sql = "select * from marca where id= " & codigo

        Try

            Call abrirConexion()
            adaptador = New MySqlDataAdapter(sql, conexion)
            adaptador.Fill(datos, "xmarca")
            txtid.Text = datos.Tables("xmarca").Rows(0).Item("id")
            txtdescripcion.Text = datos.Tables("xmarca").Rows(0).Item("descripcion")
            codigoABM = codigo
            Call cerrarConexion()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            cerrarConexion()

        End Try



    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Dim sql As String = ""
        If operacionABM = "nuevo" Then
            sql = "insert into marca(descripcion) values (@des) "
        ElseIf operacionABM = "editar" Then
            sql = "update marca set descripcion= @des where id= @id"

        End If
        Try
            Call abrirConexion()
            comando = New MySqlCommand(sql, conexion)
            comando.Parameters.AddWithValue("@des", txtdescripcion.Text)
            comando.Parameters.AddWithValue("@id", txtid.Text)
            comando.ExecuteNonQuery()
            MsgBox("Guardado")
            conexion.Close()
            Me.Close()
            frmmarca.Show()
            frmmarca.cargarLista("")
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Me.Close()

    End Sub
End Class