Imports System

Module Program
    Sub Main(args As String())
        Dim nombre, apellido, nombreCompleto As String
        nombre = "Carlos"
        apellido = "Pérez"
        nombreCompleto = nombre + " " + apellido
        Console.WriteLine("Nombre completo: {0}", nombreCompleto)

        'Utilizando el constructor de string
        Dim letras As Char() = {"H", "o", "l", "a"}
        Dim saludo As New String(letras)
        Console.WriteLine("Saludos: {0}", saludo)

        'Utilizando métodos que retornan String
        Dim sarray() As String = {"Hola", "desde", "Visual", "Basic"}
        Dim mensaje As String = String.Join(" ", sarray)
        Console.WriteLine("Mensaje: {0}", mensaje)

        'Formateando métodos que convierten valores
        Dim esperar As DateTime = New DateTime(2012, 12, 12, 17, 58, 1)
        Dim chat As String = String.Format("Mensaje enviado el {0:t} el {0:D}", esperar)
        Console.WriteLine("Mensaje: {0}", chat)

        Console.ReadLine()
    End Sub
End Module
