Module Module1

    Sub Main()
        Call ProgramaFactorial()
        Console.ReadKey()
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

