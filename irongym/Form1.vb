Imports MySql.Data.MySqlClient
Public Class login
    Dim datos As DataSet
    Dim adaptador As New MySqlDataAdapter

    Private Sub ingresar(usuario As String, password As String)
        Dim sql As String
        sql = "select * from usuario where user= '" & usuario & "' and password= '" & password & "'"

        Try
            abrirConexion()
            adaptador = New MySqlDataAdapter(sql, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "xusuario")

            If Me.ValidateChildren = True And txtusuario.Text <> "" And txtpassword.Text <> "" Then
                If datos.Tables("xusuario").Rows.Count > 0 Then
                    frmMenu.Show()
                    Hide()



                    txtusuario.Text = ""
                    txtpassword.Text = ""

                Else
                    MsgBox("verificar usuario o contraseña", MsgBoxStyle.Exclamation, "Usuario incorrecto")


                End If
            Else
                MessageBox.Show("Rellene los campos", "Registro de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            cerrarConexion()


        End Try

    End Sub


    Private Sub btnaceptar_Click(sender As Object, e As EventArgs) Handles btnaceptar.Click

        Call ingresar(txtusuario.Text, txtpassword.Text)



    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Dispose()
    End Sub


    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Me.Close()

    End Sub

    Private Sub txtpassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpassword.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            btnaceptar.Focus()

        End If
    End Sub


End Class
