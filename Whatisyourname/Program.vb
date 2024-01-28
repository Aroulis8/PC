Imports System.Net.Mime.MediaTypeNames
Imports System.Threading

Module Program
    Dim name = name
    Dim code = code
    Dim userkey = 1
    Dim code1 = 1
    Sub Main(args As String())

        Console.Title = "Login"
        Console.WriteLine("Hi.Please enter name:")
        name = Console.ReadLine()
        Console.WriteLine($"Welcome back {name}!")
        Thread.Sleep(1000)
        Console.WriteLine("Please enter password:")
        code = Console.ReadLine()
        Thread.Sleep(1000)
        Console.Clear()
        Console.WriteLine("Login Successful!")
        Thread.Sleep(1000)
        Home()

    End Sub

    Sub Settings()

        Console.Clear()
        Console.Title = "Settings"
        Console.Beep()
        Console.WriteLine("Change password")
        Console.WriteLine($"Current password: {code}")
        Console.WriteLine("Type new password:")
        code = Console.ReadLine()
        Console.WriteLine("Please enter password:")
        code1 = Console.ReadLine()
        If code = code1 Then
            Console.Beep()
            Console.WriteLine("Success!")
            Thread.Sleep(2000)
            Home()
        Else
            Console.WriteLine("Failed")
        End If
        Thread.Sleep(2000)
        Home()

    End Sub

    Sub Home()
        Console.Clear()
        Console.Title = "Home"
        Console.WriteLine("Press 's' to enter settings.")
        Console.WriteLine("Press 'e' to exit.")
        Console.WriteLine("Press 'c' to enter the calculator")
        Console.WriteLine("Press 'p' to enter your profile")

        userkey = Console.ReadLine()
        If userkey = "s" Then
            Settings()
        End If

        If userkey = "e" Then
            shut()

        End If

        If userkey = "c" Then
            Calc()
        End If

        If userkey = "p" Then
            User()
        End If
    End Sub

    Sub Calc()
        Console.Title = "Calculator"
        Dim num1 = 0
        Dim num2 = 0
        Console.Clear()
        Console.WriteLine("Calculator")
        Console.WriteLine("------------------------")


        Console.WriteLine("Type a number, and then press Enter")
        num1 = Convert.ToInt32(Console.ReadLine())


        Console.WriteLine("Type another number, and then press Enter")
        num2 = Convert.ToInt32(Console.ReadLine())

        Console.WriteLine("The result is:")
        Console.WriteLine(num1 + num2)
        Thread.Sleep(2000)
        Console.WriteLine("Press any key to exit")
        Console.ReadKey()
        Home()


    End Sub

    Sub User()
        Console.Clear()
        Console.WriteLine($"Name: {name}")
        Console.WriteLine($"Password: {code}")
        Console.WriteLine("(Change password in settings)")
        Console.WriteLine("Press any key to exit")
        Console.ReadKey()
        Home()
    End Sub

    Sub shut()
        Console.Clear()
        Console.WriteLine("Shutting down...")
        Thread.Sleep(2000)
        Environment.Exit(0)
    End Sub


End Module
