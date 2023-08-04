Imports System

Module Program
    Sub Main()
        Dim sueldo, afp, ars, totalDescuento, sueldoNeto As Double

        ' Solicitamos al usuario ingresar el sueldo y validamos la entrada
        Console.Write("Ingrese el sueldo del empleado: ")
        While Not Double.TryParse(Console.ReadLine(), sueldo) Or sueldo < 0
            Console.WriteLine("¡Error! Por favor, ingrese un valor válido para el sueldo.")
            Console.Write("Ingrese el sueldo del empleado: ")
        End While

        ' Calculamos la AFP y la ARS
        afp = sueldo * 0.0287
        ars = sueldo * 0.0302

        ' Calculamos el total de descuentos y el sueldo neto
        totalDescuento = afp + ars
        sueldoNeto = sueldo - totalDescuento

        ' Mostramos los resultados por pantalla
        Console.WriteLine("Resultados:")
        Console.WriteLine("AFP: " & afp.ToString("C"))
        Console.WriteLine("ARS: " & ars.ToString("C"))
        Console.WriteLine("Total Descuento: " & totalDescuento.ToString("C"))
        Console.WriteLine("Sueldo Neto: " & sueldoNeto.ToString("C"))

        Console.ReadLine()
    End Sub
End Module
