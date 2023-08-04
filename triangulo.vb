Imports System

Module Program
    Sub Main()
        Dim cateto1, cateto2, hipotenusa As Double

        ' Solicitamos al usuario los valores de los catetos
        Console.Write("Ingrese la longitud del primer cateto: ")
        cateto1 = Double.Parse(Console.ReadLine())

        Console.Write("Ingrese la longitud del segundo cateto: ")
        cateto2 = Double.Parse(Console.ReadLine())

        ' Calculamos la hipotenusa usando el teorema de Pitágoras
        hipotenusa = Math.Sqrt(Math.Pow(cateto1, 2) + Math.Pow(cateto2, 2))

        ' Mostramos el resultado
        Console.WriteLine("La hipotenusa es: " & hipotenusa)
        'gracias por ver 

        Console.ReadLine()
    End Sub
End Module
