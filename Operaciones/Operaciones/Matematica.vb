Public Class Matematica


    ''' <summary>
    ''' Obtiene la hipotensa de un triangulo rectangulo
    ''' </summary>
    ''' <param name="ca"> Cateto a </param>
    ''' <param name="cb"> Cateto b </param>
    ''' <returns> Hipotenusa del triangulo rectangulo </returns>
    Public Shared Function Hipotenusa(ByVal ca As Double, ByVal cb As Double) As Double
        Return Math.Sqrt((Math.Pow(ca, 2) + Math.Pow(cb, 2)))
    End Function
    ''' <summary>
    ''' Retorna verdad en caso de recibir un numero primo y falso en caso de no ser
    ''' </summary>
    ''' <param name="num"> numero a evaluar </param>
    ''' <returns>True si es primo, false si no es primo</returns>
    Public Shared Function EsPrimo(ByVal num As Integer) As Boolean

        Dim es As Boolean = True
        If num = 1 Or num = 0 Then
            Return False
        End If

        Dim i As Integer = 2
        While i < num And es
            If num Mod i = 0 Then
                es = False
            End If
            i += 1
        End While
        Return es
    End Function

    ''' <summary>
    ''' Convierte un numero binario en decimal
    ''' </summary>
    ''' <param name="binario"> Cadena numerica</param>
    ''' <returns></returns>
    Public Shared Function BinarioDecimal(ByVal binario As String) As Integer

        Return Convert.ToInt32(binario, 2)

    End Function

    ''' <summary>
    ''' Convierte un numero decimal a binario
    ''' </summary>
    ''' <param name="dec"></param>
    ''' <returns>Binario en forma de cadena</returns>
    Public Shared Function DecimalBinario(ByVal dec As Integer) As String
        Return Convert.ToString(dec, 2)
    End Function

    ''' <summary>
    ''' Calcula el factorial de un numero
    ''' </summary>
    ''' <param name="numero">Numero a evaluar</param>
    ''' <returns> Retorna factorial del numero evaluado</returns>
    Public Shared Function Factorial(ByVal numero As Integer) As Integer

        Dim f As Integer = 1

        For i = 2 To numero
            f *= i
        Next


        Return f
    End Function


End Class

