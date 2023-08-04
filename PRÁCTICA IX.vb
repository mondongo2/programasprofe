Imports System

Module Program
    Sub Main()
        Dim cantidad_personas, edad_persona, contador_mayores As Integer
        Dim nombre_persona As String

        ' Solicitamos al usuario ingresar la cantidad de personas
        Console.Write("Ingrese la cantidad de personas: ")
        While Not Integer.TryParse(Console.ReadLine(), cantidad_personas) Or cantidad_personas <= 0
            Console.WriteLine("¡Error! Por favor, ingrese una cantidad válida.")
            Console.Write("Ingrese la cantidad de personas: ")
        End While

        contador_mayores = 0 ' Inicializamos el contador de personas mayores

        ' Iteramos sobre la cantidad de personas ingresadas
        For i As Integer = 1 To cantidad_personas
            Console.Write("Ingrese la edad de la persona " & i & ": ")
            While Not Integer.TryParse(Console.ReadLine(), edad_persona) Or edad_persona < 0
                Console.WriteLine("¡Error! Por favor, ingrese una edad válida.")
                Console.Write("Ingrese la edad de la persona " & i & ": ")
            End While

            Console.Write("Ingrese el nombre de la persona " & i & ": ")
            nombre_persona = Console.ReadLine()

            If edad_persona >= 18 Then
                Console.WriteLine("Nombre: " & nombre_persona & ", Edad: " & edad_persona)
                contador_mayores += 1
            Else
                Console.WriteLine("Menor de edad - Nombre: " & nombre_persona & ", Edad: " & edad_persona)
            End If
        Next

        Console.WriteLine("Total personas mayores de edad: " & contador_mayores)

        Console.ReadLine()
    End Sub
End Module
