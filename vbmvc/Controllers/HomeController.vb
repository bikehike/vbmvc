Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Private Shared staticCounter As New Integer

    <HttpGet>
    Function Index(bobModel As BobModel) As ActionResult
        Dim model As New List(Of Integer)()
        If bobModel Is Nothing Then
            bobModel = New BobModel()
        End If
        bobModel.simpleCounter += 1
        model.Add(bobModel.simpleCounter)
        Return View(model)
    End Function

    <HttpPost>
    Function scroll(bobModel As BobModel) As ActionResult
        Return RedirectToAction("Index", bobModel)
    End Function

    Function About() As ActionResult
        ViewData("Message") = "Your application description page."

        Return View()
    End Function

    Function Contact() As ActionResult
        ViewData("Message") = "bobs page."

        Return View()
    End Function

    Function Iris(controller As String, action As String, page As String, id As String) As ActionResult
        Return Content(controller + "/" + action + "/" + page + "/" + id)
    End Function

    Function iris100(controller As String, action As String) As ActionResult
        Return Content(controller + "/" + action)
    End Function


End Class
