## Caso Práctico 1
***

A continuación se muestra el código utilizado para esta práctica.

~~~vbnet
Module Program
    ' Función para comprobar el tipo de dato entrado por el usurio
    ' Debe ser un valor numérico
    Function IsValidInput(sInput As Object) As Boolean
        Return IsNumeric(sInput)
    End Function
~~~

Seguimos con el módulo principal donde está el cuerpo del programa.

~~~vbnet
    Sub Main(args As String())
        'Variable declaration
        Dim nPercent As Decimal
        Dim nPrice

        ' Write text on console asking for user input
        Console.WriteLine("Caso práctico 1" + vbCrLf)
~~~

Se define un bucle para la introducción de los datos hasta que el tipo sea el correcto.

~~~vbnet
        ' Loop until correct user input
        Do While True
            Console.Write("Introducir precio del producto: ")

            ' Almacena valor introducido por pantalla
            nPrice = Console.ReadLine()

            ' Comprueba la validez del user Input
            If IsValidInput(nPrice) Then
                ' Salida del bucle cuando se verifica que el formato es el esperado
                Exit Do
            End If

            ' Entrada incorrecta del usuario. Pide nueva entrada
            Console.WriteLine("El precio del producto debe ser un valor númerico." +  vbCrLf)
        Loop
~~~

Una vez verificada la correcta introducción de los datos, se pasa a ralizar los cálculo correspondientes y dar salida por consola a los resultados para dar por finalizado el programa.

~~~vbnet
        ' Lógica de cálculo del porcentaje a apicar
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
~~~

El código del programa se puede descargar desde [aquí](https://github.com/jnestruch/sepe_net/blob/master/CasoPractico01/casopractico01/Program.vb).