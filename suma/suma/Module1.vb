Module Module1

    Sub Main(args As String())

        If args.Length = 0 Then
            Console.WriteLine("Se requieren parametros para realizar la operación")

            Return

        End If

        Dim sum As Double = 0

        For Each arg As String In args

            sum += Double.Parse(arg)

        Next

        Console.Write("El resultado es igual: " + sum.ToString())

    End Sub

End Module
