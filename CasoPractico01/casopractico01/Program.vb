Imports System

Module Program
    ' Funci�n para comprobar el tipo de dato entrado por el usurio
    ' Debe ser un valor num�rico
    Function IsValidInput(sInput As Object) As Boolean
        Return IsNumeric(sInput)
    End Function

    ' M�dulo principal
    Sub Main(args As String())
        'Variable declaration
        Dim nPercent As Decimal
        Dim nPrice

        ' Write text on console asking for user input
        Console.WriteLine("Caso pr�ctico 1" + vbCrLf)

        ' Loop until correct user input
        Do While True
            Console.Write("Introducir precio del producto: ")

            ' Almacena valor introducido por pantalla
            nPrice = Console.ReadLine()

            ' Comprueba la validez del user Input
            If IsValidInput(nPrice) Then
                Exit Do
            End If

            ' Entrada incorrecta del usuario. Pide nueva entrada
            Console.WriteLine("El precio del producto debe ser un valor n�merico." + vbCrLf)
        Loop

        ' L�gica de c�lculo del porcentaje a apicar
        If nPrice < 100 Then
            nPercent = nPrice * 0.1
        Else
            nPercent = nPrice * 0.2
        End If

        ' Mostrar el % del precio a aplicar
        Console.WriteLine("Valor del porcentaje a aplicar: {0}", nPercent)

        ' Mostrar el valor final
        Console.WriteLine(vbCrLf & "Precio total: {0}", nPrice + nPercent)

        ' Wait on Console to see result
        Console.ReadKey()
    End Sub
End Module
