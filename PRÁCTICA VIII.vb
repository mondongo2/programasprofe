Imports System

Module Program
    Sub Main()
        Dim nota As Double

        ' Solicitamos al usuario ingresar la nota del estudiante
        Console.Write("Ingrese la nota del estudiante: ")
        While Not Double.TryParse(Console.ReadLine(), nota)
            Console.WriteLine("¡Error! Por favor, ingrese una nota válida.")
            Console.Write("Ingrese la nota del estudiante: ")
        End While

        ' Evaluamos la nota y mostramos el resultado por pantalla
        If nota >= 70 Then
            Console.WriteLine("APROBADO")
        Else
            Console.WriteLine("REPROBADO")
        End If

        Console.ReadLine()
    End Sub
End Module
