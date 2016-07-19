Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        Return View()
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
