@*<h1>Data passed using ViewData</h1>
@{
    string str1 = (string)ViewData["str1"]; //Typecasting required in View data
    int num1 = (int)ViewData["num1"];
    <h3>@str1</h3>
    <h3>@num1</h3>
}

<h1>Data passed using ViewBag</h1>
@{
    string str2 = ViewBag.str2;
    int num2 = ViewBag.num2;
    <h3>@str2</h3>
    <h3>@num2</h3>
}*@
@section localcontent
{
    <h3>Index.cshtml's local content goes here</h3>
}
