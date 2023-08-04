Imports System

Module Program
    Sub Main()
        ' Variables de entrada
        Dim articulo As String
        Dim precio, cantidad As Double

        ' Variables de salida
        Dim subtotal, itbis, total As Double

        ' Variable para controlar si se desea agregar otro artículo
        Dim agregarOtro As Boolean = True

        While agregarOtro
            ' Solicitamos al usuario ingresar los datos del artículo
            Console.WriteLine("Ingrese los datos del artículo:")
            Console.Write("Nombre del artículo: ")
            articulo = Console.ReadLine()

            Console.Write("Precio: ")
            While Not Double.TryParse(Console.ReadLine(), precio) Or precio <= 0
                Console.WriteLine("¡Error! Por favor, ingrese un precio válido.")
                Console.Write("Precio: ")
            End While

            Console.Write("Cantidad: ")
            While Not Double.TryParse(Console.ReadLine(), cantidad) Or cantidad <= 0
                Console.WriteLine("¡Error! Por favor, ingrese una cantidad válida.")
                Console.Write("Cantidad: ")
            End While

            ' Calculamos el subtotal, el ITBIS y el total
            subtotal = cantidad * precio
            itbis = subtotal * 0.18
            total = subtotal + itbis

            ' Mostramos los resultados por pantalla
            Console.WriteLine("Datos del artículo:")
            Console.WriteLine("Nombre: " & articulo)
            Console.WriteLine("Precio: " & precio.ToString("C"))
            Console.WriteLine("Cantidad: " & cantidad)
            Console.WriteLine("Subtotal: " & subtotal.ToString("C"))
            Console.WriteLine("ITBIS: " & itbis.ToString("C"))
            Console.WriteLine("Total: " & total.ToString("C"))

            ' Preguntamos si desea agregar otro artículo
            Console.Write("¿Desea agregar otro artículo? (Sí: 1, No: 0): ")
            Dim opcion As Integer
            While Not Integer.TryParse(Console.ReadLine(), opcion) Or Not (opcion = 0 Or opcion = 1)
                Console.WriteLine("¡Error! Por favor, ingrese 1 para Sí o 0 para No.")
                Console.Write("¿Desea agregar otro artículo? (Sí: 1, No: 0): ")
            End While

            If opcion = 0 Then
                agregarOtro = False
            End If

            Console.WriteLine() ' Espacio en blanco para separar cada artículo
        End While

        Console.WriteLine("¡Gracias por utilizar el programa!")
        Console.ReadLine()
    End Sub
End Module
