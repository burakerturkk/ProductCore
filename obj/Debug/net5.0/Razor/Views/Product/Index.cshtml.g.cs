#pragma checksum "C:\Users\brker\source\repos\ProductCore\ProductCore\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4424638cd0b240ddac9af1d1957dce01b683ac14"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\brker\source\repos\ProductCore\ProductCore\Views\Product\Index.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\brker\source\repos\ProductCore\ProductCore\Views\Product\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4424638cd0b240ddac9af1d1957dce01b683ac14", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9f177334f991aa1e2e1d6f48ae097d099500a12", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<ProductCore.Data.Models.Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\brker\source\repos\ProductCore\ProductCore\Views\Product\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Product List</h1>
<br />
<table class=""table table-bordered"">
    <tr>
        <th>ID</th>
        <th>Product Brand</th>
        <th>Category Name</th>
        <th>Product Description</th>
        <th>Product Price</th>
        <th>Product Image</th>
        <th>Product Stock</th>
        <th>Delete</th>
        <th>Update</th>
        <th>Product Details</th>
    </tr>
");
#nullable restore
#line 24 "C:\Users\brker\source\repos\ProductCore\ProductCore\Views\Product\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 27 "C:\Users\brker\source\repos\ProductCore\ProductCore\Views\Product\Index.cshtml"
           Write(item.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 28 "C:\Users\brker\source\repos\ProductCore\ProductCore\Views\Product\Index.cshtml"
           Write(item.ProductBrand);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 29 "C:\Users\brker\source\repos\ProductCore\ProductCore\Views\Product\Index.cshtml"
           Write(item.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 30 "C:\Users\brker\source\repos\ProductCore\ProductCore\Views\Product\Index.cshtml"
           Write(item.ProductDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 31 "C:\Users\brker\source\repos\ProductCore\ProductCore\Views\Product\Index.cshtml"
           Write(item.ProductPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 32 "C:\Users\brker\source\repos\ProductCore\ProductCore\Views\Product\Index.cshtml"
           Write(item.ProductImageURL);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 33 "C:\Users\brker\source\repos\ProductCore\ProductCore\Views\Product\Index.cshtml"
           Write(item.ProductStock);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 960, "\"", 1005, 2);
            WriteAttributeValue("", 967, "/Product/ProductDelete/", 967, 23, true);
#nullable restore
#line 34 "C:\Users\brker\source\repos\ProductCore\ProductCore\Views\Product\Index.cshtml"
WriteAttributeValue("", 990, item.ProductId, 990, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Delete</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 1065, "\"", 1107, 2);
            WriteAttributeValue("", 1072, "/Product/ProductGet/", 1072, 20, true);
#nullable restore
#line 35 "C:\Users\brker\source\repos\ProductCore\ProductCore\Views\Product\Index.cshtml"
WriteAttributeValue("", 1092, item.ProductId, 1092, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info\">Update</a></td>\r\n            <td><a href=\"#\" class=\"btn btn-warning\">Details</a></td>\r\n\r\n        </tr>\r\n");
#nullable restore
#line 39 "C:\Users\brker\source\repos\ProductCore\ProductCore\Views\Product\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>\r\n");
#nullable restore
#line 42 "C:\Users\brker\source\repos\ProductCore\ProductCore\Views\Product\Index.cshtml"
Write(Html.PagedListPager((IPagedList)Model, page => Url.Action("Index", new { page })));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<a href=\"/Product/ProductAdd\" class=\"btn btn-primary\">New Product</a>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPagedList<ProductCore.Data.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
