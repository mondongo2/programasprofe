Imports System

Module Program
    Sub Main(args As String())
        Dim articulo As Integer
        Dim existencia As Integer
        Dim compras As Integer
        Dim ventas As Integer
        Console.WriteLine("ingrese el numero de articulos")
        articulo = Console.ReadLine()
        Console.WriteLine("ingrese la cantidad de articulos vendidos")
        ventas = Console.ReadLine()
        Console.WriteLine("Ingrese la cantidad de artículos comprados:")
        compras = Integer.Parse(Console.ReadLine())
        ' Calcular la existencia final
        existencia = articulo + compras - ventas

        ' Mostrar el resultado
        Console.WriteLine("Existencia final del artículo: " & existencia)


    End Sub
End Module
