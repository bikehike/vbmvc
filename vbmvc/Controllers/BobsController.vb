Imports System.Reflection
Imports System.Web.Mvc

Namespace Controllers
    Public Class BobsController
        Inherits Controller

        Function b1() As ActionResult
            Dim ts As System.DateTime = DateTime.Now
            Return Content(String.Format("fields: {0} props: {1}", elapsed(Sub() GetAllFieldValues()), elapsed(Sub() GetAllPropertyValues())))
        End Function

        Function b2() As ActionResult
            Return Content("b2")
        End Function

        Function elapsed(method As Action) As Integer
            Dim watch = System.Diagnostics.Stopwatch.StartNew()
            method()
            watch.Stop()
            Return watch.ElapsedMilliseconds
        End Function

        Dim predicate As Predicate(Of PropertyInfo) = Function(p)
                                                          Return p.GetCustomAttribute(Of Column)() IsNot Nothing
                                                      End Function

        Sub GetAllFieldValues()
            Dim aaa() As Reflection.FieldInfo = GetType(BuildFields).GetRuntimeFields()
            Dim fields() As FieldInfo = Array.FindAll(Of FieldInfo)(aaa, Function(f) f.GetCustomAttribute(Of Column)() IsNot Nothing)
            Array.Sort(fields, Function(x, y)
                                   If (x = y) Then Return 0
                                   If (x Is Nothing) Then Return 1
                                   If (y Is Nothing) Then Return -1
                                   Return getColumnIndex(x) - getColumnIndex(y)
                               End Function)
            'Array.ForEach(Of FieldInfo)(fields, Sub(f) Debug.WriteLine("field {0} index {1}", New Object() {f.Name, getColumnIndex(f)}))
            Array.ForEach(Of FieldInfo)(fields, Sub(f) getColumnIndex(f))
            'aaa.AsParallel().ForAll(Sub(e)
            '                            If e.IsPublic And e.Name.StartsWith("fields") Then
            '                                Dim lazye As Lazy(Of IList(Of Orders(Of Customer))) = e.GetValue(e)
            '                                Dim value = lazye.Value
            '                                Debug.WriteLine("field {0} value {1} fieldinfo {2}", e.Name, value, e)
            '                            End If
            '                        End Sub)
            'Dim f = fields1.Value
        End Sub

        Private Function getColumnIndex(f As FieldInfo) As Object
            Return f.GetCustomAttribute(Of Column)().index
        End Function

        Sub GetAllPropertyValues()
            Dim aaa() As Reflection.PropertyInfo = GetType(BuildFields).GetProperties()
            Dim properties() As PropertyInfo = Array.FindAll(Of PropertyInfo)(aaa, predicate)
            'Array.ForEach(Of PropertyInfo)(properties, Sub(p) Debug.WriteLine("name {0} ", New Object() {p.Name}))
            Array.ForEach(Of PropertyInfo)(properties, Sub(p) p.Name.Any())
            'Dim f = fields1.Value
        End Sub

    End Class
End Namespace