Imports System

Module Program
    Sub Main()
        Dim cuota, mora, total_a_pagar, descuento, neto_a_pagar As Double
        Dim fecha_pago, fecha_pago_esperada, fecha_limite As Date

        ' Solicitamos al usuario ingresar la cuota y la fecha de pago
        Console.Write("Ingrese la cuota: ")
        While Not Double.TryParse(Console.ReadLine(), cuota) Or cuota < 0
            Console.WriteLine("¡Error! Por favor, ingrese un valor válido para la cuota.")
            Console.Write("Ingrese la cuota: ")
        End While

        Console.Write("Ingrese la fecha de pago (formato dd/MM/yyyy): ")
        While Not Date.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", Nothing, Globalization.DateTimeStyles.None, fecha_pago)
            Console.WriteLine("¡Error! Por favor, ingrese una fecha válida en el formato dd/MM/yyyy.")
            Console.Write("Ingrese la fecha de pago (formato dd/MM/yyyy): ")
        End While

        ' Calculamos la fecha límite para el pago (7 días después de la fecha esperada de pago)
        fecha_pago_esperada = fecha_pago.AddDays(-7)
        fecha_limite = fecha_pago_esperada.AddDays(7)

        ' Verificamos si el pago es tardío o a tiempo y calculamos el monto a pagar
        If fecha_pago > fecha_limite Then
            mora = cuota * 0.05
            total_a_pagar = cuota + mora

            ' Mostramos los resultados por pantalla
            Console.WriteLine("Mora: " & mora.ToString("C"))
            Console.WriteLine("Total a Pagar: " & total_a_pagar.ToString("C"))
        Else
            descuento = cuota * 0.1
            neto_a_pagar = cuota - descuento

            ' Mostramos los resultados por pantalla
            Console.WriteLine("Descuento: " & descuento.ToString("C"))
            Console.WriteLine("Neto a Pagar: " & neto_a_pagar.ToString("C"))
        End If

        Console.ReadLine()
    End Sub
End Module
