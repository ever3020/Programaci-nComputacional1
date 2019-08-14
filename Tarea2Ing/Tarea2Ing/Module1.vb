Module Module1

    Sub Main()
        Dim mayor As Double
        Dim estudiantes(9, 2) As Double
        Dim menor As Double
        Dim promedio As Double
        Dim buscar As Double
        Console.WriteLine("Bienvenido maestro")
        For i = 0 To 9


            For a = 0 To 2
                Console.WriteLine("Ingrese la nota " & a + 1 & "  del estudiante: " & i + 1)
                estudiantes(i, a) = Console.ReadLine
            Next
            promedio = ((estudiantes(i, 0) + estudiantes(i, 1) + estudiantes(i, 2)) / 3)
            If estudiantes(i, 0) > estudiantes(i, 1) And estudiantes(i, 0) > estudiantes(i, 2) Then
                mayor = estudiantes(i, 0)
            ElseIf estudiantes(i, 1) > estudiantes(i, 0) And estudiantes(i, 1) > estudiantes(i, 2) Then
                mayor = estudiantes(i, 1)
            ElseIf estudiantes(i, 2) > estudiantes(i, 1) And estudiantes(i, 2) > estudiantes(i, 1) Then
                mayor = estudiantes(i, 2)
            ElseIf estudiantes(i, 0) = estudiantes(i, 1) And estudiantes(i, 0) = estudiantes(i, 2) Then
                menor = estudiantes(i, 0)
                mayor = estudiantes(i, 0)
            End If
            If estudiantes(i, 0) < estudiantes(i, 1) And estudiantes(i, 0) < estudiantes(i, 2) Then
                menor = estudiantes(i, 0)
            ElseIf estudiantes(i, 1) < estudiantes(i, 0) And estudiantes(i, 1) < estudiantes(i, 2) Then
                menor = estudiantes(i, 1)
            ElseIf estudiantes(i, 2) < estudiantes(i, 1) And estudiantes(i, 2) < estudiantes(i, 1) Then
                menor = estudiantes(i, 2)
            End If
            MsgBox(
                   "Estudiante N°: " & i + 1 & vbCrLf &
                   "la nota mayor es: " & mayor & vbCrLf &
                   "la nota menor es: " & menor & vbCrLf &
                   "El promedio es: " & promedio
                   )
            Console.ReadKey()
            Console.Clear()
        Next
    End Sub

End Module
