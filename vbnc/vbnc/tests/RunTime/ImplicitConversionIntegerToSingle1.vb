Module ImplicitConversionIntegerToSingle1
    Function Main() As Integer
        Dim result As Boolean
        Dim value1 As Integer
        Dim value2 As Single
        Dim const2 As Single

        value1 = 50I
        value2 = value1
        const2 = 50I

        result = value2 = const2

        If result = False Then
            System.Console.WriteLine("FAIL ImplicitConversionIntegerToSingle1")
            Return 1
        End If
    End Function
End Module
