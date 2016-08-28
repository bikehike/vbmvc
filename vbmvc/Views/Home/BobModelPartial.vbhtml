@ModelType BobModel

<p>Static @Html.Hidden("unchanged", Model.simpleCounter(), htmlAttributes:=New With {.value2 = Model.simpleCounter})</p>
<p>Dynamic @Html.EditorFor(Function(model) model.simpleCounter(), New With {.htmlAttributes = New With {.value = 2222}})</p>


display name for
@Html.DisplayNameFor(Of Integer)(Function(i) Model.modelFirst)