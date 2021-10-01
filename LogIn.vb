Public Class LogIn
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()

    End Sub

    Private Sub TxtIngreseUsuario_TextChanged(sender As Object, e As EventArgs) Handles TxtIngreseUsuario.TextChanged

    End Sub

    Private Sub TxtIngreseUsuario_Click(sender As Object, e As EventArgs) Handles TxtIngreseUsuario.Click
        TxtIngreseUsuario.Text = ""
        TxtIngreseUsuario.Focus()

    End Sub

    Private Sub txtContraseña_Click(sender As Object, e As EventArgs)
        txtContraseña.Text = ""
        txtContraseña.Focus()
    End Sub
End Class
