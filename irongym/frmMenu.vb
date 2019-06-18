Public Class frmMenu
    Private Sub btnclientes_Click(sender As Object, e As EventArgs) Handles btnclientes.Click
        frmclientes.Show()
        Me.Close()
    End Sub

    Private Sub btnproductos_Click(sender As Object, e As EventArgs) Handles btnproductos.Click
        frmproductos.Show()
        Me.Close()
    End Sub

    Private Sub btnpersonal_Click(sender As Object, e As EventArgs) Handles btnpersonal.Click
        frmpersonal.Show()
        Me.Close()
    End Sub

    Private Sub btnproveedores_Click(sender As Object, e As EventArgs) Handles btnproveedores.Click
        frmproveedores.Show()
        Me.Close()
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        If MsgBox("¿Desea Cerrar Sesion?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            login.Show()

            Me.Close()

        End If

    End Sub

    Private Sub btnmarca_Click(sender As Object, e As EventArgs) Handles btnmarca.Click
        frmmarca.Show()
        Me.Close()
    End Sub

    Private Sub btnusuario_Click(sender As Object, e As EventArgs) Handles btnusuario.Click
        login2.Show()



    End Sub
End Class