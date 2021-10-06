Imports System.Data.SqlClient

Public Class Usuarios
    Private Sub Usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel4.Visible = False
        Mostrar()

    End Sub

    ''Boton cerrar
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()

    End Sub

    ''Boton agregar
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Panel4.Visible = True
        GuardarToolStripMenuItem.Visible = True
        GuardarCambiosToolStripMenuItem.Visible = False
    End Sub

    ''Boton Agregar usuario nuevo
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

    '' Mostrar
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

    Private Sub DataListado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataListado.CellContentClick

    End Sub

    '' Doble click para modificar usuario
    Private Sub DataListado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataListado.CellDoubleClick
        Try
            Panel4.Visible = True
            GuardarToolStripMenuItem.Visible = False
            GuardarCambiosToolStripMenuItem.Visible = True
            txtBoxNombres.Text = DataListado.SelectedCells.Item(2).Value
            txtBoxUsuarios.Text = DataListado.SelectedCells.Item(3).Value
            txtBoxContraseña.Text = DataListado.SelectedCells.Item(4).Value
            lblidusuario.Text = DataListado.SelectedCells.Item(1).Value

        Catch ex As Exception

        End Try
    End Sub

    ''Boton Guardar usuario 
    Private Sub GuardarCambiosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarCambiosToolStripMenuItem.Click
        Try
            Dim cmd As New SqlCommand
            abrir()
            cmd = New SqlCommand("editar_usuario", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@idusuario", lblidusuario.Text)
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

    '' Boton Eliminar usuario 
    Private Sub DataListado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataListado.CellClick
        If e.ColumnIndex = Me.DataListado.Columns.Item("Eliminar").Index Then
            Dim result As DialogResult
            result = MessageBox.Show("¿Realmente desea eliminar a este Usuario?", "Eliminando usuario", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If result = DialogResult.OK Then
                Try
                    Dim cmd As New SqlCommand
                    abrir()
                    cmd = New SqlCommand("eliminar_usuario", conexion)
                    cmd.CommandType = 4
                    cmd.Parameters.AddWithValue("@idusuario", DataListado.SelectedCells.Item(1).Value)

                    cmd.ExecuteNonQuery()
                    cerrar()
                    Mostrar()


                Catch ex As Exception : MsgBox(ex.Message)

                End Try
            Else
                MessageBox.Show("Aqui no pasó nada", "Eliminando usuario", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If
        End If

    End Sub

    '' Intoduccion a buscar un usuario
    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged
        Buscar()

    End Sub
    '' Busqueda de usuario 
    Sub Buscar()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            abrir()
            da = New SqlDataAdapter("buscar_usuarios", conexion)
            da.SelectCommand.CommandType = 4
            da.SelectCommand.Parameters.AddWithValue("@letra", txtBusqueda.Text)

            da.Fill(dt)
            DataListado.DataSource = dt
            cerrar()

        Catch ex As Exception : MessageBox.Show(ex.Message)

        End Try
    End Sub
End Class