Imports System.Data.SqlClient

Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim connection As SqlConnection = New SqlConnection()

        connection.ConnectionString = "Data Source=localhost; Initial Catalog=prueba;Integrated Security=True"

        connection.Open()

        Dim adp As SqlDataAdapter = New SqlDataAdapter("select * from articulos", connection)

        Dim ds As DataSet = New DataSet()

        adp.Fill(ds)

        DataGridView1.DataSource = ds.Tables(0)

        connection.Close()

    End Sub
End Class
