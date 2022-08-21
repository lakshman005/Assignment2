Module Program

    Sub Main()

        'TestEmployee()
        'TestRunTime()
        CheckWords()
        Console.Read()

    End Sub


    Sub TestEmployee()
        Dim emp As Employee
        Dim val As Integer
        Console.WriteLine("Enter your Employee No ")
        Dim no As Integer
        no = Convert.ToInt32(Console.ReadLine())

        Console.WriteLine("Enter your Employee Name ")
        Dim name As String

        name = Console.ReadLine()

        Console.WriteLine("Enter your Basic Salary")
        Dim salary As Integer
        salary = Convert.ToInt32(Console.ReadLine())
        emp = New Employee(no, name, salary)
        val = emp.Calculate()
        Console.WriteLine("-------------------------------")
        Console.WriteLine(" Employee Id : " & emp.Eno & vbCrLf & " Employee Name :" & emp.Ename & vbCrLf & " Employee Netsalary :" & val)
        Console.WriteLine("-------------------------------")

    End Sub


    Sub TestRunTime()
        Dim check As Parent
        check = New Children()
        check.Display()
    End Sub

    Sub CheckWords()
        Console.WriteLine("Enter a string ")
        Dim game = Console.ReadLine()
        Dim count As Integer = 0
        Dim ans() As String
        ans = game.Split(" ")
        For i As Integer = 0 To ans.Length() - 1 Step 1
            count += 1
        Next
        Console.WriteLine(count)

    End Sub








End Module
