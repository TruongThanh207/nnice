#pragma checksum "D:\KIVI\nnice\NNice\NNice.Web\Views\Product\Product.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7172d5d2283b38f7a4c32569395d999782c0b5ae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Product), @"mvc.1.0.view", @"/Views/Product/Product.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/Product.cshtml", typeof(AspNetCore.Views_Product_Product))]
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
#line 1 "D:\KIVI\nnice\NNice\NNice.Web\Views\_ViewImports.cshtml"
using NNice.Web;

#line default
#line hidden
#line 2 "D:\KIVI\nnice\NNice\NNice.Web\Views\_ViewImports.cshtml"
using NNice.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7172d5d2283b38f7a4c32569395d999782c0b5ae", @"/Views/Product/Product.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bd5693ba48d1d7fa77e1a48ac2d805876030ec6", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Product : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<ProductViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\KIVI\nnice\NNice\NNice.Web\Views\Product\Product.cshtml"
  
    ViewData["Title"] = "Product";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(122, 81, true);
            WriteLiteral("\r\n<header>\r\n    <div class=\"row\">\r\n        <div class=\"col-md-6\">\r\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 203, "\"", 248, 1);
#line 10 "D:\KIVI\nnice\NNice\NNice.Web\Views\Product\Product.cshtml"
WriteAttributeValue("", 210, Url.Action("ProductDetail","Product"), 210, 38, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(249, 125, true);
            WriteLiteral(" class=\"btn btn-info\" name=\"btnAdd\" role=\"button\">New Product</a>\r\n            <input type=\"hidden\" id=\"custId\" name=\"custId\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 374, "\"", 398, 1);
#line 11 "D:\KIVI\nnice\NNice\NNice.Web\Views\Product\Product.cshtml"
WriteAttributeValue("", 382, ViewBag.message, 382, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(399, 51, true);
            WriteLiteral(">\r\n        </div>\r\n        <div class=\"col-md-6\">\r\n");
            EndContext();
#line 14 "D:\KIVI\nnice\NNice\NNice.Web\Views\Product\Product.cshtml"
             using (Html.BeginForm())
            {

#line default
#line hidden
            BeginContext(504, 91, true);
            WriteLiteral("                <div class=\"input-group md-form form-sm form-2 pl-0\">\r\n                    ");
            EndContext();
            BeginContext(596, 133, false);
#line 17 "D:\KIVI\nnice\NNice\NNice.Web\Views\Product\Product.cshtml"
               Write(Html.TextBox("Search", "", new { @class = "form-control my-0 py-1", @style = "border: 1px solid #ef9a9a;", @placeholder = "Search" }));

#line default
#line hidden
            EndContext();
            BeginContext(729, 240, true);
            WriteLiteral("\r\n                    <div class=\"input-group-append\">\r\n                        <button id=\"button-addon1\" type=\"submit\" class=\"btn btn-primary\"><i class=\"icon icon-search\"></i></button>\r\n                    </div>\r\n                </div>\r\n");
            EndContext();
#line 22 "D:\KIVI\nnice\NNice\NNice.Web\Views\Product\Product.cshtml"
            }

#line default
#line hidden
            BeginContext(984, 687, true);
            WriteLiteral(@"        </div>
    </div>
</header>
<div class=""row"">
    <div class=""col-md-12 "">
        <div class=""card"">
            <div class=""card-header"">
                <h4>PRODUCT</h4>
            </div>
            <div class=""card-body"">
                <div class=""table-responsive"">
                    <table class=""table"">
                        <thead>
                            <tr>
                                <th>Name</th>
                                <th>Price</th>
                                <th></th>
                                <th></th>
                            </tr>
                        </thead>
                        <tbody>
");
            EndContext();
#line 44 "D:\KIVI\nnice\NNice\NNice.Web\Views\Product\Product.cshtml"
                             foreach (ProductViewModel x in Model)
                            {
                                var myModal = "myModal" + x.ID;

#line default
#line hidden
            BeginContext(1835, 78, true);
            WriteLiteral("                                <tr>\r\n                                    <td>");
            EndContext();
            BeginContext(1914, 6, false);
#line 48 "D:\KIVI\nnice\NNice\NNice.Web\Views\Product\Product.cshtml"
                                   Write(x.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1920, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(1968, 11, false);
#line 49 "D:\KIVI\nnice\NNice\NNice.Web\Views\Product\Product.cshtml"
                                   Write(x.UnitPrice);

#line default
#line hidden
            EndContext();
            BeginContext(1979, 91, true);
            WriteLiteral("</td>\r\n                                    <td>\r\n                                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2070, "\"", 2135, 1);
#line 51 "D:\KIVI\nnice\NNice\NNice.Web\Views\Product\Product.cshtml"
WriteAttributeValue("", 2077, Url.Action("ProductDetail", "Product", new { id = x.ID }), 2077, 58, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2136, 281, true);
            WriteLiteral(@" class=""btn btn-sm btn-success"" name=""btnAdd"" role=""button"">Edit</a>
                                    </td>
                                    <td>
                                        <button type=""button"" class=""btn btn-sm btn-danger"" data-toggle=""modal"" data-target=""#");
            EndContext();
            BeginContext(2418, 7, false);
#line 54 "D:\KIVI\nnice\NNice\NNice.Web\Views\Product\Product.cshtml"
                                                                                                                         Write(myModal);

#line default
#line hidden
            EndContext();
            BeginContext(2425, 17, true);
            WriteLiteral("\" data-whatever=\"");
            EndContext();
            BeginContext(2443, 4, false);
#line 54 "D:\KIVI\nnice\NNice\NNice.Web\Views\Product\Product.cshtml"
                                                                                                                                                  Write(x.ID);

#line default
#line hidden
            EndContext();
            BeginContext(2447, 180, true);
            WriteLiteral("\">\r\n                                            Delete\r\n                                        </button>\r\n                                        <div class=\"modal fade xoa-modal\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2627, "\"", 2640, 1);
#line 57 "D:\KIVI\nnice\NNice\NNice.Web\Views\Product\Product.cshtml"
WriteAttributeValue("", 2632, myModal, 2632, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2641, 1316, true);
            WriteLiteral(@" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
                                            <div class=""modal-dialog"" role=""document"">
                                                <div class=""modal-content"">
                                                    <div class=""modal-header"">
                                                        <h5 class=""modal-title"" id=""exampleModalLabel"">Confirm</h5>
                                                        <button class=""close"" type=""button"" data-dismiss=""modal"" aria-label=""Close"">
                                                            <span aria-hidden=""true"">×</span>
                                                        </button>
                                                    </div>
                                                    <div class=""modal-body"">Do you really want to delete?</div>
                                                    <div class=""modal-footer"">
                           ");
            WriteLiteral(@"                             <button class=""btn btn-sm btn-secondary"" type=""button"" data-dismiss=""modal"">Cancel</button>
                                                        <button type=""button"" class=""btn btn-sm btn-danger"">
                                                            ");
            EndContext();
            BeginContext(3958, 72, false);
#line 70 "D:\KIVI\nnice\NNice\NNice.Web\Views\Product\Product.cshtml"
                                                       Write(Html.ActionLink("Delete", "DeleteProduct", "Product", new { id = x.ID }));

#line default
#line hidden
            EndContext();
            BeginContext(4030, 367, true);
            WriteLiteral(@"
                                                        </button>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </td>
                                </tr>
");
            EndContext();
#line 78 "D:\KIVI\nnice\NNice\NNice.Web\Views\Product\Product.cshtml"
                            }

#line default
#line hidden
            BeginContext(4428, 146, true);
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<ProductViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591