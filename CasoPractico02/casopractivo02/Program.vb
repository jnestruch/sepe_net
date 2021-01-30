Imports System

Module Program
    Sub Main(args As String())

        'Variable declaration
        Dim dNace As Date
        Dim sName As String

        ' Write text on console asking for user input
        Console.WriteLine("Caso practico 2" + vbCrLf)

        ' Loop until correct user input
        Do While True
            ' User input
            Console.Write("C�mo te llamas ?: ")
            sName = Console.ReadLine()

            Console.Write("Fecha de nacimiento (dd-mm-yyyy) ?: ")
            Try
                dNace = Console.ReadLine()
            Catch e As Exception
                ' Entrada incorrecta del usuario. Pide nueva entrada
                Console.WriteLine("Formato de fecha incorrecto." + vbCrLf)
                Continue Do
            End Try

            ' Salida del bucle al tener el formato correcto
            Exit Do
        Loop

        ' Salida formateada
        ' Se omiten c�lculos complejos para el c�lculo de la edad correcta. Salida aproximada.
        Console.WriteLine()
        Console.WriteLine("Hola {0}, si naciste {1}, tu edad es de {2} a�os.", sName, dNace.ToString("D"), Today.Year - dNace.Year)

        ' Wait on Console to see result
        Console.ReadKey()
    End Sub
End Module
