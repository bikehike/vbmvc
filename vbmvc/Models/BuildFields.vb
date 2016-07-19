Imports System.Web
Module BuildFields

    Public Class Column
        Inherits Attribute
        Public Property index As Integer
        Public Property name As String
        Sub New()
        End Sub
    End Class

    <Column(index:=0, name:="f1")>
    Private fields1 As Lazy(Of IList(Of Orders(Of Customer))) = New Lazy(Of IList(Of Orders(Of Customer)))(Function() build1())
    <Column(index:=1, name:="f2")>
    Private fields2 As Lazy(Of IList(Of Orders(Of Customer))) = New Lazy(Of IList(Of Orders(Of Customer)))(Function() build1())
    <Column(index:=3, name:="f3")>
    Private fields3 As Lazy(Of IList(Of Orders(Of Customer))) = New Lazy(Of IList(Of Orders(Of Customer)))(Function() build1())
    <Column(index:=4, name:="f4")>
    Private fields4 As Lazy(Of IList(Of Orders(Of Customer))) = New Lazy(Of IList(Of Orders(Of Customer)))(Function() build1())
    <Column(index:=5, name:="f5")>
    Private fields5 As Lazy(Of IList(Of Orders(Of Customer))) = New Lazy(Of IList(Of Orders(Of Customer)))(Function() build1())
    <Column(index:=2, name:="f6")>
    Private fields6 As Lazy(Of IList(Of Orders(Of Customer))) = New Lazy(Of IList(Of Orders(Of Customer)))(Function() build1())
    Private fields7 As Lazy(Of IList(Of Orders(Of Customer))) = New Lazy(Of IList(Of Orders(Of Customer)))(Function() build1())
    Private fields8 As Lazy(Of IList(Of Orders(Of Customer))) = New Lazy(Of IList(Of Orders(Of Customer)))(Function() build1())
    Private fields9 As Lazy(Of IList(Of Orders(Of Customer))) = New Lazy(Of IList(Of Orders(Of Customer)))(Function() build1())
    Private fields10 As Lazy(Of IList(Of Orders(Of Customer))) = New Lazy(Of IList(Of Orders(Of Customer)))(Function() build1())
    Private fields11 As Lazy(Of IList(Of Orders(Of Customer))) = New Lazy(Of IList(Of Orders(Of Customer)))(Function() build1())
    Private fields12 As Lazy(Of IList(Of Orders(Of Customer))) = New Lazy(Of IList(Of Orders(Of Customer)))(Function() build1())
    Private fields13 As Lazy(Of IList(Of Orders(Of Customer))) = New Lazy(Of IList(Of Orders(Of Customer)))(Function() build1())
    Private fields14 As Lazy(Of IList(Of Orders(Of Customer))) = New Lazy(Of IList(Of Orders(Of Customer)))(Function() build1())
    Private fields15 As Lazy(Of IList(Of Orders(Of Customer))) = New Lazy(Of IList(Of Orders(Of Customer)))(Function() build1())
    Private fields16 As Lazy(Of IList(Of Orders(Of Customer))) = New Lazy(Of IList(Of Orders(Of Customer)))(Function() build1())
    Private fields17 As Lazy(Of IList(Of Orders(Of Customer))) = New Lazy(Of IList(Of Orders(Of Customer)))(Function() build1())
    Private fields18 As Lazy(Of IList(Of Orders(Of Customer))) = New Lazy(Of IList(Of Orders(Of Customer)))(Function() build1())
    Private fields19 As Lazy(Of IList(Of Orders(Of Customer))) = New Lazy(Of IList(Of Orders(Of Customer)))(Function() build1())

    Function build1() As IList(Of Orders(Of Customer))
        Debug.WriteLine("build1")
        Dim list As New List(Of Orders(Of Customer))
        list.Add(New Orders(Of Customer)(Sub(a) Return, 1))
        list.Add(New Orders(Of Customer)(Sub(a) Return, 1))
        list.Add(New Orders(Of Customer)(Sub(a) Return, 1))
        list.Add(New Orders(Of Customer)(Sub(a) Return, 1))
        list.Add(New Orders(Of Customer)(Sub(a) Return, 1))
        list.Add(New Orders(Of Customer)(Sub(a) Return, 1))
        list.Add(New Orders(Of Customer)(Sub(a) Return, 1))
        list.Add(New Orders(Of Customer)(Sub(a) Return, 1))
        list.Add(New Orders(Of Customer)(Sub(a) Return, 1))
        list.Add(New Orders(Of Customer)(Sub(a) Return, 1))
        list.Add(New Orders(Of Customer)(Sub(a) Return, 1))
        list.Add(New Orders(Of Customer)(Sub(a) Return, 1))
        list.Add(New Orders(Of Customer)(Sub(a) Return, 1))
        list.Add(New Orders(Of Customer)(Sub(a) Return, 1))
        list.Add(New Orders(Of Customer)(Sub(a) Return, 1))
        list.Add(New Orders(Of Customer)(Sub(a) Return, 1))
        list.Add(New Orders(Of Customer)(Sub(a) Return, 1))
        list.Add(New Orders(Of Customer)(Sub(a) Return, 1))
        list.Add(New Orders(Of Customer)(Sub(a) Return, 1))
        list.Add(New Orders(Of Customer)(Sub(a) Return, 1))
        list.Add(New Orders(Of Customer)(Sub(a) Return, 1))
        list.Add(New Orders(Of Customer)(Sub(a) Return, 1))
        list.Add(New Orders(Of Customer)(Sub(a) Return, 1))
        list.Add(New Orders(Of Customer)(Sub(a) Return, 1))
        list.Add(New Orders(Of Customer)(Sub(a) Return, 1))
        list.Add(New Orders(Of Customer)(Sub(a) Return, 1))
        list.Add(New Orders(Of Customer)(Sub(a) Return, 1))
        list.Add(New Orders(Of Customer)(Sub(a) Return, 1))
        list.Add(New Orders(Of Customer)(Sub(a) Return, 1))
        list.Add(New Orders(Of Customer)(Sub(a) Return, 1))
        list.Add(New Orders(Of Customer)(Sub(a) Return, 1))
        list.Add(New Orders(Of Customer)(Sub(a) Return, 1))
        list.Add(New Orders(Of Customer)(Sub(a) Return, 1))
        list.Add(New Orders(Of Customer)(Sub(a) Return, 1))
        list.Add(New Orders(Of Customer)(Sub(a) Return, 1))
        list.Add(New Orders(Of Customer)(Sub(a) Return, 1))
        list.Add(New Orders(Of Customer)(Sub(a) Return, 1))
        list.Add(New Orders(Of Customer)(Sub(a) Return, 1))
        list.Add(New Orders(Of Customer)(Sub(a) Return, 1))

        Return list
    End Function

    Public Class Orders(Of cust As Customer)
        Sub New(s As Action(Of cust), a As Integer)
        End Sub
    End Class

    Public Class Customer
        Sub New(s As Action(Of String), a As Integer)
        End Sub
    End Class

    <Column(index:=0, name:="F2")>
    Public ReadOnly Property F2() As IList(Of Orders(Of Customer))
        Get
            Return fields2.Value
        End Get
    End Property
    <Column(index:=1, name:="F1")>
    Public ReadOnly Property F1() As IList(Of Orders(Of Customer))
        Get
            Return fields1.Value
        End Get
    End Property

    Public ReadOnly Property F3() As IList(Of Orders(Of Customer))
        Get
            Return fields3.Value
        End Get
    End Property
    Public ReadOnly Property F4() As IList(Of Orders(Of Customer))
        Get
            Return fields4.Value
        End Get
    End Property
    Public ReadOnly Property F5() As IList(Of Orders(Of Customer))
        Get
            Return fields5.Value
        End Get
    End Property
    Public ReadOnly Property F6() As IList(Of Orders(Of Customer))
        Get
            Return fields6.Value
        End Get
    End Property
    Public ReadOnly Property F7() As IList(Of Orders(Of Customer))
        Get
            Return fields7.Value
        End Get
    End Property
    Public ReadOnly Property F8() As IList(Of Orders(Of Customer))
        Get
            Return fields8.Value
        End Get
    End Property
    Public ReadOnly Property F9() As IList(Of Orders(Of Customer))
        Get
            Return fields9.Value
        End Get
    End Property
    Public ReadOnly Property F10() As IList(Of Orders(Of Customer))
        Get
            Return fields10.Value
        End Get
    End Property
    Public ReadOnly Property F11() As IList(Of Orders(Of Customer))
        Get
            Return fields11.Value
        End Get
    End Property
    Public ReadOnly Property F12() As IList(Of Orders(Of Customer))
        Get
            Return fields12.Value
        End Get
    End Property
    Public ReadOnly Property F13() As IList(Of Orders(Of Customer))
        Get
            Return fields13.Value
        End Get
    End Property
    Public ReadOnly Property F14() As IList(Of Orders(Of Customer))
        Get
            Return fields14.Value
        End Get
    End Property
    Public ReadOnly Property F15() As IList(Of Orders(Of Customer))
        Get
            Return fields15.Value
        End Get
    End Property
    Public ReadOnly Property F16() As IList(Of Orders(Of Customer))
        Get
            Return fields16.Value
        End Get
    End Property
    Public ReadOnly Property F17() As IList(Of Orders(Of Customer))
        Get
            Return fields17.Value
        End Get
    End Property
    Public ReadOnly Property F18() As IList(Of Orders(Of Customer))
        Get
            Return fields18.Value
        End Get
    End Property
    Public ReadOnly Property F19() As IList(Of Orders(Of Customer))
        Get
            Return fields18.Value
        End Get
    End Property

    Public Sub Load()
        Dim a = F1()
        a = F2()
        a = F3()
        a = F4()
        a = F5()
        a = F6()
        a = F7()
        a = F8()
        a = F9()
        a = F10()
        a = F11()
        a = F12()
        a = F13()
        a = F14()
        a = F15()
        a = F16()
        a = F17()
        a = F18()
        a = F19()
    End Sub

End Module
