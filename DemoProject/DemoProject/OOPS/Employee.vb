Public Class Employee

    Public Eno As Integer
    Public Ename As String
    Public BSA As Integer
    Private DA As Integer
    Private HRA As Integer
    Private IT As Integer
    Private PF As Integer
    Private Gross_Salary As Integer
    Private NetSalary As Integer


    Public Sub New(e As Integer, name As String, bs As Integer)

        Eno = e
        Ename = name
        BSA = bs


    End Sub

    Private Property no As Integer
        Get
            Return Eno
        End Get
        Set(value As Integer)
            Eno = value
        End Set
    End Property

    Private Property basic As Integer
        Get
            Return BSA
        End Get
        Set(value As Integer)
            BSA = value
        End Set
    End Property


    Private Property name As String
        Get
            Return Ename
        End Get
        Set(value As String)
            Ename = value
        End Set
    End Property


    Private Property d As Integer
        Get
            Return DA
        End Get
        Set(value As Integer)
            DA = value
        End Set
    End Property



    Private Property hr As Integer
        Get
            Return HRA
        End Get
        Set(value As Integer)
            HRA = value
        End Set
    End Property


    Private Property iit As Integer
        Get
            Return IT
        End Get
        Set(value As Integer)
            IT = value
        End Set
    End Property


    Private Property ppf As Integer
        Get
            Return PF
        End Get
        Set(value As Integer)
            PF = value
        End Set
    End Property


    Private Property grosss As Integer
        Get
            Return Gross_Salary
        End Get
        Set(value As Integer)
            Gross_Salary = value
        End Set
    End Property


    Private Property net As Integer
        Get
            Return NetSalary
        End Get
        Set(value As Integer)
            NetSalary = value
        End Set
    End Property


    Public Function Calculate() As Integer
        Dim da As Integer = 0
        Dim hra As Integer = 0
        Dim it As Integer = 0
        Dim pf As Integer = 0
        Dim gs As Integer = 0
        Dim ns As Integer = 0

        da = BSA * 12 \ 100
        hra = BSA * 20 \ 100
        it = BSA * 15 \ 100
        pf = BSA * 12 \ 100
        gs = BSA + hra + da
        ns = gs - (it + pf)

        Return ns ' Net salary is returned Here


    End Function












End Class
