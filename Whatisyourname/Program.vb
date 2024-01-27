Imports System

Module Program
    Sub Main(args As String())

        Console.WriteLine("Hi.Please enter password:")
        Dim code = Console.ReadLine()
        Console.WriteLine("Please enter password again:")
        If Console.ReadLine = code Then
            Console.WriteLine("Succes!")


        End If

    End Sub
End Module
