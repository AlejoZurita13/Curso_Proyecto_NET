Imports System.Data.SqlClient

Public Class Usuarios
    Private Sub Usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel4.Visible = False
        Mostrar()

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Panel4.Visible = True
    End Sub

    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        Try
            Dim cmd As New SqlCommand
            abrir()
            cmd = New SqlCommand("insertar_usuario", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@nombres", txtBoxNombres.Text)
            cmd.Parameters.AddWithValue("@Login", txtBoxUsuarios.Text)
            cmd.Parameters.AddWithValue("@Password", txtBoxContraseña.Text)
            cmd.ExecuteNonQuery()
            cerrar()
            Mostrar()
            Panel4.Visible = False

        Catch ex As Exception : MsgBox(ex.Message)

        End Try


    End Sub

    Sub Mostrar()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            abrir()
            da = New SqlDataAdapter("mostrar_usuario", conexion)
            da.Fill(dt)
            DataListado.DataSource = dt
            cerrar()

        Catch ex As Exception : MessageBox.Show(ex.Message)

        End Try
    End Sub
End Class