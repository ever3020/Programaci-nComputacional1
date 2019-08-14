Module Module1

    Sub Main()
        Dim salario As Double
        Dim tiempo As Integer
        Dim name As String
        Dim salarioNeto As Double
        Dim respuesta As Integer
        Console.Clear()


        Console.WriteLine("Bienvenido! " & vbCrLf & "introduce tu nonbre!")
        name = Console.ReadLine

        Console.Clear()
        Console.WriteLine("Hola: " & name & " ayudame digitando tu salario")
        salario = Console.ReadLine
        validar(salario)
        Console.WriteLine("muy bien " & name & " ahora digita el tiempo que llevas laborando en meses!")
        tiempo = Console.ReadLine
        validar(tiempo)

        If tiempo < 12 Then
            Console.Clear()
            salarioNeto = salario * 1.05
            Console.WriteLine(name & " Tu salario es: $" & salarioNeto)
        ElseIf tiempo >= 12 & tiempo < 24 Then
            Console.Clear()
            salarioNeto = salario * 1.07
            Console.WriteLine(name & " Tu salario es: $" & salarioNeto)
        ElseIf tiempo >= 24 & tiempo < 60 Then
            Console.Clear()
            salarioNeto = salario * 1.1
            Console.WriteLine(name & " Tu salario es: $" & salarioNeto)
        ElseIf tiempo >= 60 & tiempo < 120 Then
            Console.Clear()
            salarioNeto = salario * 1.15
            Console.WriteLine(name & " Tu salario es: $" & salarioNeto)
            Console.ReadKey()
        ElseIf tiempo >= 120 Then
            Console.Clear()
            salarioNeto = salario * 1.07
            Console.WriteLine(name & " Tu salario es: $" & salarioNeto)
        End If
        Console.WriteLine("Desea utilizar nuevamente el programa?")
        Console.WriteLine("Si su respuesta es 'Si' dijite 1, si no dijite '0'")
        respuesta = Console.ReadLine()
        If respuesta = 1 Then
            Main()
        ElseIf respuesta = 0 Then
            Console.WriteLine("Gracias por usar nuestro programa!" & name)
        End If

    End Sub
    Sub validar(num As Integer)
        If num < 0 Then
            Console.WriteLine("Los numeros negativos no son validos")
            Console.WriteLine("Seras redirijido al inicio")
            Console.ReadKey()
            Main()
        End If
    End Sub

End Module
