Imports System

Module looper_100
    Sub Main()
        Dim output, rows, columns As Integer

        'number of rows and columns
        Console.Write("Insert number of columns: ")
        rows = Console.ReadLine
        Console.Write("Insert number of columns: ")
        columns = Console.ReadLine

        'counts up until designated row and column to create a time table
        For count1 = 1 To rows
            For count2 = 1 To columns
                output = count1 * count2

                If output < 10 Then
                    Console.Write(Format(output, "|0 ") & "|")
                End If
                If output >= 10 Then
                    Console.Write(Format(output, "|0") & "|")
                ElseIf output = 100 Then
                    Console.Write(Format(output, "|") & "|")
                End If
            Next
            Console.WriteLine()
        Next
        'John Calverley
    End Sub
End Module
