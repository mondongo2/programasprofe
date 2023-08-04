Imports System

Module Program
    Sub Main()
        Dim sueldo, venta_mensual, comision, total_ganado As Double

        ' Solicitamos al usuario ingresar el sueldo y el monto de venta mensual
        Console.Write("Ingrese el sueldo del vendedor: ")
        While Not Double.TryParse(Console.ReadLine(), sueldo) Or sueldo < 0
            Console.WriteLine("¡Error! Por favor, ingrese un valor válido para el sueldo.")
            Console.Write("Ingrese el sueldo del vendedor: ")
        End While

        Console.Write("Ingrese el monto de venta mensual: ")
        While Not Double.TryParse(Console.ReadLine(), venta_mensual) Or venta_mensual < 0
            Console.WriteLine("¡Error! Por favor, ingrese un valor válido para el monto de venta mensual.")
            Console.Write("Ingrese el monto de venta mensual: ")
        End While

        ' Calculamos la comisión en base al monto de venta mensual
        If venta_mensual >= 100000.0 Then
            comision = venta_mensual * 0.1
        Else
            comision = 0
        End If

        ' Calculamos el total ganado (sueldo + comisión)
        total_ganado = sueldo + comision

        ' Mostramos los resultados por pantalla
        Console.WriteLine("Comisión: " & comision.ToString("C"))
        Console.WriteLine("Total Ganado: " & total_ganado.ToString("C"))

        Console.ReadLine()
    End Sub
End Module
