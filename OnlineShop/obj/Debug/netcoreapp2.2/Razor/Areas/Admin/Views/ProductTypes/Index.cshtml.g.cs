#pragma checksum "E:\IDB Materials\Project\OnlineShop\OnlineShop\Areas\Admin\Views\ProductTypes\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1506cab59ea4475abb655b7f760e2a3f01fe7ae8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_ProductTypes_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/ProductTypes/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/ProductTypes/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_ProductTypes_Index))]
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
#line 1 "E:\IDB Materials\Project\OnlineShop\OnlineShop\Areas\Admin\Views\_ViewImports.cshtml"
using OnlineShop;

#line default
#line hidden
#line 1 "E:\IDB Materials\Project\OnlineShop\OnlineShop\Areas\Admin\Views\ProductTypes\Index.cshtml"
using OnlineShop.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1506cab59ea4475abb655b7f760e2a3f01fe7ae8", @"/Areas/Admin/Views/ProductTypes/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d90dc07541a5c6d64c93e024fee34b85f8e0e69", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_ProductTypes_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProductTypes>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ButtonPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(61, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "E:\IDB Materials\Project\OnlineShop\OnlineShop\Areas\Admin\Views\ProductTypes\Index.cshtml"
  

    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(106, 209, true);
            WriteLiteral("\r\n<br /><br/>\r\n\r\n      <div class=\"row\">\r\n          <div class=\"col-6\">\r\n              <h2 class=\"text-info\">Product Type List</h2>\r\n          </div>\r\n\r\n          <div class=\"col-6 text-right\">\r\n              ");
            EndContext();
            BeginContext(315, 98, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1506cab59ea4475abb655b7f760e2a3f01fe7ae85021", async() => {
                BeginContext(359, 50, true);
                WriteLiteral("<i class=\"fas fa-plus\"></i>&nbsp; New Product Type");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(413, 164, true);
            WriteLiteral("\r\n          </div>\r\n      </div>\r\n<br />\r\n<div>\r\n    <table class=\"table table-striped border\">\r\n        <tr class=\"table-info\">\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(578, 39, false);
#line 25 "E:\IDB Materials\Project\OnlineShop\OnlineShop\Areas\Admin\Views\ProductTypes\Index.cshtml"
           Write(Html.DisplayNameFor(c => c.ProductType));

#line default
#line hidden
            EndContext();
            BeginContext(617, 82, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n            <th></th>\r\n        </tr>\r\n");
            EndContext();
#line 30 "E:\IDB Materials\Project\OnlineShop\OnlineShop\Areas\Admin\Views\ProductTypes\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(748, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(787, 16, false);
#line 33 "E:\IDB Materials\Project\OnlineShop\OnlineShop\Areas\Admin\Views\ProductTypes\Index.cshtml"
               Write(item.ProductType);

#line default
#line hidden
            EndContext();
            BeginContext(803, 47, true);
            WriteLiteral("</td>\r\n               <td>\r\n                   ");
            EndContext();
            BeginContext(850, 50, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1506cab59ea4475abb655b7f760e2a3f01fe7ae87877", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#line 35 "E:\IDB Materials\Project\OnlineShop\OnlineShop\Areas\Admin\Views\ProductTypes\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = item.Id;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(900, 43, true);
            WriteLiteral("\r\n               </td>\r\n            </tr>\r\n");
            EndContext();
#line 38 "E:\IDB Materials\Project\OnlineShop\OnlineShop\Areas\Admin\Views\ProductTypes\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(954, 24, true);
            WriteLiteral("    </table>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(995, 154, true);
                WriteLiteral(" \r\n\r\n    <script src=\"//cdn.jsdelivr.net/npm/alertifyjs@1.13.1/build/alertify.min.js\"></script>\r\n    <script type=\"text/javascript\">\r\n   \r\n    </script>\r\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProductTypes>> Html { get; private set; }
    }
}
#pragma warning restore 1591
