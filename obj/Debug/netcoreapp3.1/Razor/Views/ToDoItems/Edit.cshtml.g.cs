#pragma checksum "D:\UofA\DEMOS\VISUAL_STUDIO\ToDo\ToDo\Views\ToDoItems\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b4e74b1395c74592dba8be10838886efd5f0d6cb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ToDoItems_Edit), @"mvc.1.0.view", @"/Views/ToDoItems/Edit.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4e74b1395c74592dba8be10838886efd5f0d6cb", @"/Views/ToDoItems/Edit.cshtml")]
    public class Views_ToDoItems_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ToDo.Models.ToDoItem>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\UofA\DEMOS\VISUAL_STUDIO\ToDo\ToDo\Views\ToDoItems\Edit.cshtml"
  
    ViewData["Title"] = "Edit";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Edit</h1>

<h4>ToDoItem</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Edit"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <input type=""hidden"" asp-for=""Id"" />
            <div class=""form-group"">
                <label asp-for=""Task"" class=""control-label""></label>
                <input asp-for=""Task"" class=""form-control"" />
                <span asp-validation-for=""Task"" class=""text-danger""></span>
            </div>
            <div class=""form-group form-check"">
                <label class=""form-check-label"">
                    <input class=""form-check-input"" asp-for=""Completed"" /> ");
#nullable restore
#line 24 "D:\UofA\DEMOS\VISUAL_STUDIO\ToDo\ToDo\Views\ToDoItems\Edit.cshtml"
                                                                      Write(Html.DisplayNameFor(model => model.Completed));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </label>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Save"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ToDo.Models.ToDoItem> Html { get; private set; }
    }
}
#pragma warning restore 1591
