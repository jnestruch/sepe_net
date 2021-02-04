Imports System.Data.SqlClient

Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim conexion As SqlConnection = New SqlConnection()

        conexion.ConnectionString = "Data Source=localhost; Initial Catalog=prueba;Integrated Security=True"

        conexion.Open()

        Dim descri As String = TextBox1.Text

        Dim precio As String = TextBox2.Text

        Dim cadena As String = "insert into articulos(descripcion,precio) values ('" & descri & "'," & precio & ")"

        Dim comando As SqlCommand

        comando = New SqlCommand(cadena, conexion)

        comando.ExecuteNonQuery()

        MessageBox.Show("Los datos se guardaron correctamente")

        TextBox1.Text = ""

        TextBox2.Text = ""

        conexion.Close()

    End Sub
End Class
