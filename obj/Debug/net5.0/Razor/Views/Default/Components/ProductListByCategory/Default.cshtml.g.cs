#pragma checksum "C:\Users\brker\source\repos\ProductCore\ProductCore\Views\Default\Components\ProductListByCategory\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b56f58095344649e363a7c0a31910ef25a012453"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Default_Components_ProductListByCategory_Default), @"mvc.1.0.view", @"/Views/Default/Components/ProductListByCategory/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b56f58095344649e363a7c0a31910ef25a012453", @"/Views/Default/Components/ProductListByCategory/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9f177334f991aa1e2e1d6f48ae097d099500a12", @"/Views/_ViewImports.cshtml")]
    public class Views_Default_Components_ProductListByCategory_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProductCore.Data.Models.Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("checkout.html"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"agile_top_brands_grids\">\r\n");
#nullable restore
#line 3 "C:\Users\brker\source\repos\ProductCore\ProductCore\Views\Default\Components\ProductListByCategory\Default.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""col-md-3 top_brand_left"" style=""margin-bottom:25px"">
            <div class=""hover14 column"">
                <div class=""agile_top_brand_left_grid"">
                    <div class=""agile_top_brand_left_grid1"">
                        <figure>
                            <div class=""snipcart-item block"">
                                <div class=""snipcart-thumb"">
                                    <a href=""single.html""><img style=""width:200px; height:200px"" title="" "" alt="" """);
            BeginWriteAttribute("src", " src=\"", 640, "\"", 667, 1);
#nullable restore
#line 12 "C:\Users\brker\source\repos\ProductCore\ProductCore\Views\Default\Components\ProductListByCategory\Default.cshtml"
WriteAttributeValue("", 646, item.ProductImageURL, 646, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></a>\r\n                                    <p class=\"sinirlama\">");
#nullable restore
#line 13 "C:\Users\brker\source\repos\ProductCore\ProductCore\Views\Default\Components\ProductListByCategory\Default.cshtml"
                                                    Write(item.ProductBrand);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    <h4>");
#nullable restore
#line 14 "C:\Users\brker\source\repos\ProductCore\ProductCore\Views\Default\Components\ProductListByCategory\Default.cshtml"
                                   Write(item.ProductPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ₺</h4><h6>Stok : ");
#nullable restore
#line 14 "C:\Users\brker\source\repos\ProductCore\ProductCore\Views\Default\Components\ProductListByCategory\Default.cshtml"
                                                                       Write(item.ProductStock);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                </div>\r\n                                <div class=\"snipcart-details top_brand_home_details\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b56f58095344649e363a7c0a31910ef25a0124536549", async() => {
                WriteLiteral(@"
                                        <fieldset>
                                            <input type=""hidden"" name=""cmd"" value=""_cart"" />
                                            <input type=""hidden"" name=""add"" value=""1"" />
                                            <input type=""hidden"" name=""business"" value="" "" />
                                            <input type=""hidden"" name=""item_name"" value=""Fortune Sunflower Oil"" />
                                            <input type=""hidden"" name=""amount"" value=""7.99"" />
                                            <input type=""hidden"" name=""discount_amount"" value=""1.00"" />
                                            <input type=""hidden"" name=""currency_code"" value=""USD"" />
                                            <input type=""hidden"" name=""return"" value="" "" />
                                            <input type=""hidden"" name=""cancel_return"" value="" "" />
                                            <input type=""submit"" name=""submit"" ");
                WriteLiteral("value=\"Sepete Ekle\" class=\"button\" />\r\n                                        </fieldset>\r\n\r\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                                </div>\r\n                            </div>\r\n                        </figure>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 40 "C:\Users\brker\source\repos\ProductCore\ProductCore\Views\Default\Components\ProductListByCategory\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"clearfix\"> </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProductCore.Data.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
