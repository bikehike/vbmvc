Imports System.Runtime.CompilerServices
Imports System.Web.Mvc
Imports System.Linq.Expressions


Public Module HtmlExtensions

    <Extension()>
    Public Function help(Of TModel)(html As HtmlHelper(Of TModel), expression As Expression(Of Func(Of TModel))) As MvcHtmlString
        Return New MvcHtmlString("<div>bob was here</div>")
    End Function

    <Extension()>
    Public Function DisplayNameFor(Of TModel As {BaseParser}, TValue)(html As HtmlHelper(Of BaseParser),
                                                                      expression As Expression(Of Func(Of BaseParser, TValue))) As MvcHtmlString
        Return New MvcHtmlString("<div>bob was here</div>")
    End Function

End Module
