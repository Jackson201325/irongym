Imports MySql.Data.MySqlClient
Public Class frmproductoedicion
    Dim adaptador As MySqlDataAdapter
    Dim datos As DataSet
    Dim comando As MySqlCommand
    Private Sub frmproductoedicion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If operacionABM = "nuevo" Then

        ElseIf operacionABM = "editar" Then

            Call buscarRegistro(codigoABM)
        End If
    End Sub

    Private Sub buscarRegistro(codigo As String)
        Dim sql As String
        Try
            sql = "select * from productos where idproductos= " & codigo
            abrirConexion()
            adaptador = New MySqlDataAdapter(sql, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "xproductos")
            txtid.Text = datos.Tables("xproductos").Rows(0).Item("idproductos")
            txtdescripcion.Text = datos.Tables("xproductos").Rows(0).Item("descripcion")
            txttipo.Text = datos.Tables("xproductos").Rows(0).Item("tipo")
            txtcosto.Text = datos.Tables("xproductos").Rows(0).Item("costo")
            txtprecio.Text = datos.Tables("xproductos").Rows(0).Item("precio")
            txtstock.Text = datos.Tables("xproductos").Rows(0).Item("stock")
            txtmarcaid.Text = datos.Tables("xproductos").Rows(0).Item("idmarca")
            txtproveedorid.Text = datos.Tables("xproductos").Rows(0).Item("idproveedor")
            Call buscarMarca(txtmarcanombre.Text)
            Call buscarProveedor(txtproveedornombre.Text)
            codigo = codigoABM

        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            cerrarConexion()

        End Try
    End Sub
    Private Sub buscarMarca(codigo As String)
        Dim sql As String
        Try
            sql = "select * marca where id= " & codigo
            abrirConexion()
            adaptador = New MySqlDataAdapter(sql, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "marca")
            If datos.Tables("marca").Rows.Count > 0 Then
                txtmarcanombre.Text = datos.Tables("marca").Rows(0).Item("descripcion")
                txtproveedornombre.Focus()
            Else
                MsgBox("Marca no encontrada")
                txtmarcaid.Focus()
            End If
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            cerrarConexion()

        End Try
    End Sub

    Private Sub buscarProveedor(codigo As Integer)
        Dim sql As String
        Try
            sql = "select * from proveedor where id= " & codigo
            abrirConexion()
            adaptador = New MySqlDataAdapter(sql, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "proveedor")

            If datos.Tables("proveedor").Rows.Count > 0 Then
                txtproveedornombre.Text = datos.Tables("proveedor").Rows(0).Item("nombre")
                txtcosto.Focus()
            Else
                MsgBox("Proveedor no encontrado")
                txtproveedorid.Focus()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cerrarConexion()
        End Try
    End Sub

    Private Sub txtmarcaid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtmarcaid.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            If IsNumeric(txtmarcaid.Text) = False Or txtmarcaid.Text = "" Then
                MsgBox("Abrir Formulario")

            Else
                Call buscarMarca(txtmarcaid.Text)
            End If

            If IsNumeric(txtmarcaid.Text) = False Or txtmarcaid.Text = "" Then
                frmbuscarmarca.Show()
            End If
        End If

    End Sub

    Private Sub txtproveedorid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtproveedorid.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            If IsNumeric(txtproveedorid.Text) = False Or txtproveedorid.Text = "" Then
                MsgBox("Abrir Formulario")

            Else
                Call buscarProveedor(txtproveedorid.Text)

            End If
            If IsNumeric(txtproveedorid.Text) = False Or txtproveedorid.Text = "" Then
                frmbuscarproveedor.Show()
            End If
        End If
    End Sub

    Private Sub txtcosto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcosto.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            If IsNumeric(txtcosto.Text) = True Then
                txtprecio.Focus()
            Else
                MsgBox("Ingrese un valor numerico")
                txtcosto.Focus()

            End If
        End If
    End Sub

    Private Sub txtprecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtprecio.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            If IsNumeric(txtprecio.Text) = True Then
                txtmarcaid.Focus()
            Else
                MsgBox("Ingrese un valor numerico")
                txtprecio.Focus()

            End If
        End If
    End Sub
End Class