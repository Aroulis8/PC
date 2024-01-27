Imports System
Imports System.Threading

Module Program
    Sub Main(args As String())

        Console.WriteLine("Hi.Please enter name:")
        Dim name = Console.ReadLine()
        Console.WriteLine("Please Wait...")
        Thread.Sleep(5000)
        Console.WriteLine($"Welcome back {name}!")
        Thread.Sleep(3000)
        Console.WriteLine("Please enter password:")
        Dim code = Console.ReadLine()
        Thread.Sleep(3000)
        Console.Clear()
        Console.WriteLine("Login Successful!")



    End Sub
End Module
