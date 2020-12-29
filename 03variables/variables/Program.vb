Imports System

Module Program
    Enum Colores
        red = 1
        orange = 2
        yellow = 3
        green = 4
        azure = 5
        blue = 6
        violet = 7
    End Enum
    Sub Main(args As String())
        Dim a As Short
        Dim b As Integer
        Dim c As Double
        Dim list As Integer() = {34, 72, 13, 44, 25, 30, 10}
        Dim temp As Integer() = list
        Dim i As Integer

        a = 10
        b = 20
        c = a + b

        Console.WriteLine("a = {0}, b = {1}, c = {2}", a, b, c)

        Console.WriteLine("El color rojo es: " & Colores.red)

        Console.Write("Array original: ")
        For Each i In list
            Console.Write("{0} ", i)
        Next i
        Console.WriteLine()
        ' reverse the array
        Array.Reverse(temp)
        Console.Write("Array invertido: ")
        For Each i In temp
            Console.Write("{0} ", i)
        Next i
        Console.WriteLine()
        'sort the array
        Array.Sort(list)
        Console.Write("Array ordenado: ")
        For Each i In list
            Console.Write("{0} ", i)
        Next i
        Console.WriteLine()

        Console.ReadKey()
    End Sub
End Module
