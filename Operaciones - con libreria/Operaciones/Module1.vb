Imports OperacionVb

Module Module1

    Sub Main()
        Dim key As ConsoleKeyInfo

        Do
            Console.Clear()
            Console.WriteLine("Menú principal")
            Console.WriteLine("1. Programa factorial")
            Console.WriteLine("2. Programa decimal -> binario")
            Console.WriteLine("3. Programa binario -> decimal")
            Console.WriteLine("4. Programa es primo")
            Console.WriteLine("5. Porgrama hipotenusa")
            Console.WriteLine("6. Salir")
            Console.Write("Selecione una opción: ")
            key = Console.ReadKey()
            Console.Clear()
            Select Case key.Key
                Case ConsoleKey.D1, ConsoleKey.NumPad1
                    Call ProgramaFactorial()
                Case ConsoleKey.D2, ConsoleKey.NumPad2
                    Call ProgramaDecimalBinario()
                Case ConsoleKey.D3, ConsoleKey.NumPad3
                    Call ProgramaBinarioDecimal()
                Case ConsoleKey.D4, ConsoleKey.NumPad4
                    Call ProgramaEsPrimo()
                Case ConsoleKey.D5, ConsoleKey.NumPad5
                    Call ProgramaHipotenusa()
                Case ConsoleKey.D6, ConsoleKey.NumPad6
                    Console.WriteLine("Saliendo de la aplicación...")
            End Select


            Console.Write("Presione cualquier tecla para continuar")
            Console.ReadKey()
        Loop While key.Key <> ConsoleKey.D6 And key.Key <> ConsoleKey.NumPad6

    End Sub

    Private Sub ProgramaHipotenusa()
        Dim ca, cb, h As Double

        Console.Write("Digite cat a: ")
        ca = Convert.ToDouble(Console.ReadLine())
        Console.Write("Digite cat b: ")
        cb = Convert.ToDouble(Console.ReadLine())
        'h = (ca ^ 2 + cb ^ 2) ^ (1 / 2)
        h = Matematica.Hipotenusa(ca, cb)
        Console.WriteLine($"hip = {h} con cat a = {ca} y cat b = {cb}")
    End Sub

    Private Sub ProgramaEsPrimo()
        Dim num As Integer
        Console.Write("Digite numero")
        num = Integer.Parse(Console.ReadLine())

        If Matematica.EsPrimo(num) Then
            Console.WriteLine("El numero {0} es primo", num)
        Else
            Console.WriteLine("El numero no es prim {0}", num)
        End If

    End Sub

    Private Sub ProgramaBinarioDecimal()
        Dim binario As String
        Dim dec As Integer
        Console.Write("Digite numero binario: ")
        binario = Console.ReadLine()
        dec = Matematica.BinarioDecimal(binario)
        Console.WriteLine($"Binario: {binario}  => Decimal : {dec} ")
    End Sub

    Private Sub ProgramaDecimalBinario()
        Dim binario As String
        Dim dec As Integer
        Console.Write("Digite numero decimal: ")
        dec = Integer.Parse(Console.ReadLine())
        binario = Matematica.DecimalBinario(dec)
        Console.WriteLine($"Binario: {binario}  <- Decimal : {dec} ")
    End Sub

    Private Sub ProgramaFactorial()
        Dim f, num As Integer
        Console.Write("Digite el numero: ")
        num = Integer.Parse(Console.ReadLine())
        f = Matematica.Factorial(num)
        Console.WriteLine($"El factorial de {num} es {f}")
    End Sub

End Module

