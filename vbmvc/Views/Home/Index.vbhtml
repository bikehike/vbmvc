@ModelType IEnumerable(Of Integer)
@Code
    ViewData("Title") = "Home Page"

    Dim bobModel As New BobModel()
    bobModel.simpleCounter = Model.First

End Code

@helper  bobhelp(a As String, b As String)
    @Html.Label(a, b)
End Helper

@bobhelp("c", "c")

@Html.help(Function() Model)

@Using Html.BeginForm("scroll", "Home", FormMethod.Post, New With {.class = "form-horizontal", .role = "form"})
    @Html.AntiForgeryToken()
    @Html.Partial("BobModelPartial", bobModel)
    @<p>index value @Html.Value(Model.First)</p>
    @<p>index value @Html.Editor(Model.First)</p>
    @<button type="submit" name="button">submit</button>
End Using
