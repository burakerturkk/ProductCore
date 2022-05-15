#pragma checksum "C:\Users\brker\source\repos\ProductCore\ProductCore\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1572164d815a583cc71703f69f4652c8e1b5bab3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_Index), @"mvc.1.0.view", @"/Views/Category/Index.cshtml")]
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
#line 1 "C:\Users\brker\source\repos\ProductCore\ProductCore\Views\_ViewImports.cshtml"
using ProductCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\brker\source\repos\ProductCore\ProductCore\Views\_ViewImports.cshtml"
using ProductCore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1572164d815a583cc71703f69f4652c8e1b5bab3", @"/Views/Category/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9f177334f991aa1e2e1d6f48ae097d099500a12", @"/Views/_ViewImports.cshtml")]
    public class Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ProductCore.Data.Models.Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\brker\source\repos\ProductCore\ProductCore\Views\Category\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Category List</h1>\r\n<br />\r\n");
#nullable restore
#line 9 "C:\Users\brker\source\repos\ProductCore\ProductCore\Views\Category\Index.cshtml"
 using (Html.BeginForm())
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p>\r\n                    Product Name : ");
#nullable restore
#line 12 "C:\Users\brker\source\repos\ProductCore\ProductCore\Views\Category\Index.cshtml"
                              Write(Html.TextBox("p"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <input type=\"submit\" value=\"Find\" />\r\n                </p>\r\n");
#nullable restore
#line 15 "C:\Users\brker\source\repos\ProductCore\ProductCore\Views\Category\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>ID</th>\r\n        <th>Category Name</th>\r\n        <th>Category Status</th>\r\n        <th>Delete</th>\r\n        <th>Update</th>\r\n    </tr>\r\n");
#nullable restore
#line 24 "C:\Users\brker\source\repos\ProductCore\ProductCore\Views\Category\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 27 "C:\Users\brker\source\repos\ProductCore\ProductCore\Views\Category\Index.cshtml"
           Write(item.CategoryId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 28 "C:\Users\brker\source\repos\ProductCore\ProductCore\Views\Category\Index.cshtml"
           Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 29 "C:\Users\brker\source\repos\ProductCore\ProductCore\Views\Category\Index.cshtml"
           Write(item.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 766, "\"", 814, 2);
            WriteAttributeValue("", 773, "/Category/CategoryDelete/", 773, 25, true);
#nullable restore
#line 30 "C:\Users\brker\source\repos\ProductCore\ProductCore\Views\Category\Index.cshtml"
WriteAttributeValue("", 798, item.CategoryId, 798, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Delete</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 874, "\"", 919, 2);
            WriteAttributeValue("", 881, "/Category/CategoryGet/", 881, 22, true);
#nullable restore
#line 31 "C:\Users\brker\source\repos\ProductCore\ProductCore\Views\Category\Index.cshtml"
WriteAttributeValue("", 903, item.CategoryId, 903, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info\">Update</a></td>\r\n            \r\n        </tr>\r\n");
#nullable restore
#line 34 "C:\Users\brker\source\repos\ProductCore\ProductCore\Views\Category\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>\r\n<a href=\"/Category/CategoryAdd\" class=\"btn btn-primary\">New Category</a>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ProductCore.Data.Models.Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591