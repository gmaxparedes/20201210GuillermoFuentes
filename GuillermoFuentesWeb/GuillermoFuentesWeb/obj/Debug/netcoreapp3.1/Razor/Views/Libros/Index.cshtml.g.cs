#pragma checksum "C:\Users\Max Paredes\source\repos\GuillermoFuentesWeb\GuillermoFuentesWeb\Views\Libros\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76437b2ebace89cf8427478c50675ef1878f3ca9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Libros_Index), @"mvc.1.0.view", @"/Views/Libros/Index.cshtml")]
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
#line 1 "C:\Users\Max Paredes\source\repos\GuillermoFuentesWeb\GuillermoFuentesWeb\Views\_ViewImports.cshtml"
using GuillermoFuentesWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Max Paredes\source\repos\GuillermoFuentesWeb\GuillermoFuentesWeb\Views\_ViewImports.cshtml"
using GuillermoFuentesWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76437b2ebace89cf8427478c50675ef1878f3ca9", @"/Views/Libros/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ff172d5a13a2fb76d7d86c47ad6210e3fd797a3", @"/Views/_ViewImports.cshtml")]
    public class Views_Libros_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<GuillermoFuentesWeb.Models.Libros>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Max Paredes\source\repos\GuillermoFuentesWeb\GuillermoFuentesWeb\Views\Libros\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 13 "C:\Users\Max Paredes\source\repos\GuillermoFuentesWeb\GuillermoFuentesWeb\Views\Libros\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\Max Paredes\source\repos\GuillermoFuentesWeb\GuillermoFuentesWeb\Views\Libros\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.book_title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\Max Paredes\source\repos\GuillermoFuentesWeb\GuillermoFuentesWeb\Views\Libros\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.book_author));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\Max Paredes\source\repos\GuillermoFuentesWeb\GuillermoFuentesWeb\Views\Libros\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.publisher));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\Max Paredes\source\repos\GuillermoFuentesWeb\GuillermoFuentesWeb\Views\Libros\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.publisher_date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\Max Paredes\source\repos\GuillermoFuentesWeb\GuillermoFuentesWeb\Views\Libros\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.lang));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "C:\Users\Max Paredes\source\repos\GuillermoFuentesWeb\GuillermoFuentesWeb\Views\Libros\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.keyword));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 34 "C:\Users\Max Paredes\source\repos\GuillermoFuentesWeb\GuillermoFuentesWeb\Views\Libros\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.book_title_index));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 40 "C:\Users\Max Paredes\source\repos\GuillermoFuentesWeb\GuillermoFuentesWeb\Views\Libros\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "C:\Users\Max Paredes\source\repos\GuillermoFuentesWeb\GuillermoFuentesWeb\Views\Libros\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 46 "C:\Users\Max Paredes\source\repos\GuillermoFuentesWeb\GuillermoFuentesWeb\Views\Libros\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.book_title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 49 "C:\Users\Max Paredes\source\repos\GuillermoFuentesWeb\GuillermoFuentesWeb\Views\Libros\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.book_author));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 52 "C:\Users\Max Paredes\source\repos\GuillermoFuentesWeb\GuillermoFuentesWeb\Views\Libros\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.publisher));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 55 "C:\Users\Max Paredes\source\repos\GuillermoFuentesWeb\GuillermoFuentesWeb\Views\Libros\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.publisher_date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 58 "C:\Users\Max Paredes\source\repos\GuillermoFuentesWeb\GuillermoFuentesWeb\Views\Libros\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.lang));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 61 "C:\Users\Max Paredes\source\repos\GuillermoFuentesWeb\GuillermoFuentesWeb\Views\Libros\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.keyword));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 64 "C:\Users\Max Paredes\source\repos\GuillermoFuentesWeb\GuillermoFuentesWeb\Views\Libros\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.book_title_index));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 67 "C:\Users\Max Paredes\source\repos\GuillermoFuentesWeb\GuillermoFuentesWeb\Views\Libros\Index.cshtml"
           Write(Html.ActionLink("Prestar", "Prestar", new { Cliente = ViewBag.Cliente, IdLibro = item.id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("               \r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 70 "C:\Users\Max Paredes\source\repos\GuillermoFuentesWeb\GuillermoFuentesWeb\Views\Libros\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<GuillermoFuentesWeb.Models.Libros>> Html { get; private set; }
    }
}
#pragma warning restore 1591