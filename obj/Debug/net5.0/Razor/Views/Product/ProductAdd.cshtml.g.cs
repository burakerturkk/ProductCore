#pragma checksum "C:\Users\brker\source\repos\ProductCore\ProductCore\Views\Product\ProductAdd.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a65b768ce7af408743c251c145df16ca2b140d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_ProductAdd), @"mvc.1.0.view", @"/Views/Product/ProductAdd.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a65b768ce7af408743c251c145df16ca2b140d7", @"/Views/Product/ProductAdd.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9f177334f991aa1e2e1d6f48ae097d099500a12", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_ProductAdd : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductCore.Data.Models.Product>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\brker\source\repos\ProductCore\ProductCore\Views\Product\ProductAdd.cshtml"
  
    ViewData["Title"] = "ProductAdd";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Product Add Page</h1>\r\n\r\n<br />\r\n");
#nullable restore
#line 10 "C:\Users\brker\source\repos\ProductCore\ProductCore\Views\Product\ProductAdd.cshtml"
 using (Html.BeginForm("ProductAdd", "Product", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\brker\source\repos\ProductCore\ProductCore\Views\Product\ProductAdd.cshtml"
Write(Html.LabelFor(x => x.ProductBrand));

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\brker\source\repos\ProductCore\ProductCore\Views\Product\ProductAdd.cshtml"
Write(Html.TextBoxFor(x => x.ProductBrand, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 15 "C:\Users\brker\source\repos\ProductCore\ProductCore\Views\Product\ProductAdd.cshtml"
Write(Html.LabelFor(x => x.ProductPrice));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\brker\source\repos\ProductCore\ProductCore\Views\Product\ProductAdd.cshtml"
Write(Html.TextBoxFor(x => x.ProductPrice, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 18 "C:\Users\brker\source\repos\ProductCore\ProductCore\Views\Product\ProductAdd.cshtml"
Write(Html.LabelFor(x => x.ProductImageURL));

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\brker\source\repos\ProductCore\ProductCore\Views\Product\ProductAdd.cshtml"
Write(Html.TextBoxFor(x => x.ProductImageURL, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 21 "C:\Users\brker\source\repos\ProductCore\ProductCore\Views\Product\ProductAdd.cshtml"
Write(Html.LabelFor(x => x.ProductStock));

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\brker\source\repos\ProductCore\ProductCore\Views\Product\ProductAdd.cshtml"
Write(Html.TextBoxFor(x => x.ProductStock, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 24 "C:\Users\brker\source\repos\ProductCore\ProductCore\Views\Product\ProductAdd.cshtml"
Write(Html.LabelFor(x => x.Category));

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\brker\source\repos\ProductCore\ProductCore\Views\Product\ProductAdd.cshtml"
Write(Html.DropDownListFor(x => x.CategoryId, (List<SelectListItem>)ViewBag.v1, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 27 "C:\Users\brker\source\repos\ProductCore\ProductCore\Views\Product\ProductAdd.cshtml"
Write(Html.LabelFor(x => x.ProductDescription));

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\brker\source\repos\ProductCore\ProductCore\Views\Product\ProductAdd.cshtml"
Write(Html.TextAreaFor(x => x.ProductDescription, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <button class=\"btn btn-primary\">Save</button>\r\n");
#nullable restore
#line 31 "C:\Users\brker\source\repos\ProductCore\ProductCore\Views\Product\ProductAdd.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductCore.Data.Models.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591