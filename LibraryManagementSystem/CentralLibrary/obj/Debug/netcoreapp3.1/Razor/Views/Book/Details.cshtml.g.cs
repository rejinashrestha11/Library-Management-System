#pragma checksum "D:\3rd Semester\advanced programming\main assignment\Library\Assignment_Library\CentralLibrary\CentralLibrary\Views\Book\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe443bf934913fc9325436a46c48452fd377b89a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_Details), @"mvc.1.0.view", @"/Views/Book/Details.cshtml")]
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
#nullable restore
#line 1 "D:\3rd Semester\advanced programming\main assignment\Library\Assignment_Library\CentralLibrary\CentralLibrary\Views\_ViewImports.cshtml"
using CentralLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\3rd Semester\advanced programming\main assignment\Library\Assignment_Library\CentralLibrary\CentralLibrary\Views\_ViewImports.cshtml"
using CentralLibrary.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe443bf934913fc9325436a46c48452fd377b89a", @"/Views/Book/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40358453af8edcdae849d7ff7e8a047a8de05a4d", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CentralLibrary.Models.Book>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\3rd Semester\advanced programming\main assignment\Library\Assignment_Library\CentralLibrary\CentralLibrary\Views\Book\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Book Details</h1>\r\n<hr />\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-6\">\r\n\r\n        <dl class=\"row\">\r\n            <dt class=\"col-sm-6\">\r\n                ");
#nullable restore
#line 15 "D:\3rd Semester\advanced programming\main assignment\Library\Assignment_Library\CentralLibrary\CentralLibrary\Views\Book\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Book_id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-6\">\r\n                ");
#nullable restore
#line 18 "D:\3rd Semester\advanced programming\main assignment\Library\Assignment_Library\CentralLibrary\CentralLibrary\Views\Book\Details.cshtml"
           Write(Html.DisplayFor(model => model.Book_id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-6\">\r\n                ");
#nullable restore
#line 21 "D:\3rd Semester\advanced programming\main assignment\Library\Assignment_Library\CentralLibrary\CentralLibrary\Views\Book\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.BookName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-6\">\r\n                ");
#nullable restore
#line 24 "D:\3rd Semester\advanced programming\main assignment\Library\Assignment_Library\CentralLibrary\CentralLibrary\Views\Book\Details.cshtml"
           Write(Html.DisplayFor(model => model.BookName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-6\">\r\n                ");
#nullable restore
#line 27 "D:\3rd Semester\advanced programming\main assignment\Library\Assignment_Library\CentralLibrary\CentralLibrary\Views\Book\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.ISBN_NO));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-6\">\r\n                ");
#nullable restore
#line 30 "D:\3rd Semester\advanced programming\main assignment\Library\Assignment_Library\CentralLibrary\CentralLibrary\Views\Book\Details.cshtml"
           Write(Html.DisplayFor(model => model.ISBN_NO));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-6\">\r\n                ");
#nullable restore
#line 33 "D:\3rd Semester\advanced programming\main assignment\Library\Assignment_Library\CentralLibrary\CentralLibrary\Views\Book\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.publish_year));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-6\">\r\n                ");
#nullable restore
#line 36 "D:\3rd Semester\advanced programming\main assignment\Library\Assignment_Library\CentralLibrary\CentralLibrary\Views\Book\Details.cshtml"
           Write(Html.DisplayFor(model => model.publish_year));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-6\">\r\n                ");
#nullable restore
#line 39 "D:\3rd Semester\advanced programming\main assignment\Library\Assignment_Library\CentralLibrary\CentralLibrary\Views\Book\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.author));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-6\">\r\n                ");
#nullable restore
#line 42 "D:\3rd Semester\advanced programming\main assignment\Library\Assignment_Library\CentralLibrary\CentralLibrary\Views\Book\Details.cshtml"
           Write(Html.DisplayFor(model => model.author));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </dd>

        </dl>
    </div>
    <div class=""col-md-6"">
        <img src =""https://images.unsplash.com/photo-1594312915251-48db9280c8f1?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxleHBsb3JlLWZlZWR8MTl8fHxlbnwwfHx8fA%3D%3D&w=1000&q=80"" style=""border-radius : 10px; width: 100%; height: auto;"" />
    </div>

</div>


<div>
    ");
#nullable restore
#line 55 "D:\3rd Semester\advanced programming\main assignment\Library\Assignment_Library\CentralLibrary\CentralLibrary\Views\Book\Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { /* id = Model.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe443bf934913fc9325436a46c48452fd377b89a8559", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CentralLibrary.Models.Book> Html { get; private set; }
    }
}
#pragma warning restore 1591
