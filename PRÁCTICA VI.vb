Imports System

Module Program
    Sub Main()
        Dim categoria_cliente As Integer
        Dim subtotal_venta, descuento, itbis, total As Double

        ' Solicitamos al usuario ingresar la categoría del cliente y el subtotal de la venta
        Console.Write("Ingrese la categoría del cliente (1 o 2): ")
        While Not Integer.TryParse(Console.ReadLine(), categoria_cliente) Or Not (categoria_cliente = 1 Or categoria_cliente = 2)
            Console.WriteLine("¡Error! Por favor, ingrese una categoría válida (1 o 2).")
            Console.Write("Ingrese la categoría del cliente (1 o 2): ")
        End While

        Console.Write("Ingrese el subtotal de la venta: ")
        While Not Double.TryParse(Console.ReadLine(), subtotal_venta) Or subtotal_venta < 0
            Console.WriteLine("¡Error! Por favor, ingrese un valor válido para el subtotal de la venta.")
            Console.Write("Ingrese el subtotal de la venta: ")
        End While

        ' Calculamos el descuento y el ITBIS basado en la categoría del cliente
        If categoria_cliente = 1 Then
            descuento = subtotal_venta * 0.2
        Else
            descuento = 0
        End If

        itbis = subtotal_venta * 0.18

        ' Calculamos el total (subtotal - descuento + ITBIS)
        total = subtotal_venta - descuento + itbis

        ' Mostramos los resultados por pantalla
        Console.WriteLine("SUBTOTAL: " & subtotal_venta.ToString("C"))
        Console.WriteLine("DESCUENTO: " & descuento.ToString("C"))
        Console.WriteLine("ITBIS: " & itbis.ToString("C"))
        Console.WriteLine("TOTAL: " & total.ToString("C"))

        ' Impresión de la factura (puedes implementar aquí la lógica para imprimir la factura)

        Console.ReadLine()
    End Sub
End Module
