Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class UnitTest1

    Public Interface IClass
        Property prop As Integer
    End Interface

    Public Class DefaultClass
        Implements IClass
        Private Shared lock As New Object
        Public Shared Property counter As Integer = 1
        Public Function IncrementAndGetCount() As Integer
            SyncLock lock
                counter += 1
            End SyncLock
            Return counter
        End Function
        Public Property prop As Integer Implements IClass.prop
    End Class

    Public Class DefaultSubClass
        Inherits DefaultClass

        Public Function baseProp() As Integer
            Return MyBase.prop
        End Function

        Public Function myProp() As Integer
            Return prop
        End Function

        Public Overloads Property prop As Integer
            Get
                MyBase.prop = MyBase.IncrementAndGetCount()
                prop = MyBase.prop
                Return prop
            End Get
            Set(value As Integer)
                MyBase.prop = value
            End Set
        End Property
    End Class

    Private Sub defaultClassProp(defaultClass As IClass)
        Debug.WriteLine(defaultClass.prop)
    End Sub

    <TestMethod()> Public Sub TestMethod1()
        Dim subclass As New DefaultSubClass
        Debug.WriteLine(subclass.prop)
        Debug.WriteLine(subclass.baseProp)
        Debug.WriteLine(subclass.myProp)
        subclass.prop = 13
        Debug.WriteLine(subclass.prop)
        Debug.WriteLine(subclass.baseProp)
        Debug.WriteLine(subclass.myProp)
        defaultClassProp(subclass)
        Dim value As Integer = subclass.prop
        Debug.WriteLine("value=" & value)
        subclass.prop = (value * 2)
        Debug.WriteLine(subclass.baseProp)
        Debug.WriteLine(subclass.myProp)
        defaultClassProp(subclass)
        Debug.WriteLine(subclass.prop)
        Debug.WriteLine(subclass.myProp)


    End Sub

End Class