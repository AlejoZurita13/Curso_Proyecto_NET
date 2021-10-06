Imports System.Data.SqlClient

Module ConexionMain
    Public conexion As New SqlConnection("Data Source=DESKTOP-I93TGEL\SQLEXPRESS;Initial Catalog=BaseDatosCursoProyecto;Integrated Security=True")

    Sub abrir()
        If conexion.State = 0 Then
            conexion.Open()

        End If
    End Sub

    Sub cerrar()
        If conexion.State = 1 Then
            conexion.Close()
        End If
    End Sub
End Module
