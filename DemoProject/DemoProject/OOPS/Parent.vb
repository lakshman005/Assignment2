Public Class Parent

    Sub New()
        Console.WriteLine("Parent constructor is called")
    End Sub

    Overridable Sub Display()
        Console.WriteLine("I'm the Parent")
    End Sub

End Class


Class Children : Inherits Parent

    Sub New()
        Console.WriteLine("Child Constructor is called")
    End Sub

    Overrides Sub Display()
        Console.WriteLine("I'm the Child")
    End Sub

End Class
