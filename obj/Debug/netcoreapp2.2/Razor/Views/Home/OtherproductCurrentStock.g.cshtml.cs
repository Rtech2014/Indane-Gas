#pragma checksum "E:\Final IndaneGas\IndaneApi\Views\Home\OtherproductCurrentStock.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dbcd9b5cc3757bfbbacedd51f4dda16b71cc03ff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_OtherproductCurrentStock), @"mvc.1.0.view", @"/Views/Home/OtherproductCurrentStock.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/OtherproductCurrentStock.cshtml", typeof(AspNetCore.Views_Home_OtherproductCurrentStock))]
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
#line 1 "E:\Final IndaneGas\IndaneApi\Views\_ViewImports.cshtml"
using IndaneApi;

#line default
#line hidden
#line 2 "E:\Final IndaneGas\IndaneApi\Views\_ViewImports.cshtml"
using IndaneApi.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dbcd9b5cc3757bfbbacedd51f4dda16b71cc03ff", @"/Views/Home/OtherproductCurrentStock.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"058e3261ac6a72d17932f7e547998f58f61fb6c6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_OtherproductCurrentStock : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "E:\Final IndaneGas\IndaneApi\Views\Home\OtherproductCurrentStock.cshtml"
  
    ViewData["Title"] = "OtherproductCurrentStock";

#line default
#line hidden
            BeginContext(62, 70, true);
            WriteLiteral("\r\n\r\n<h1>Current Stock</h1>  \r\n<ul>\r\n    <li>\r\n        <p>totalload =  ");
            EndContext();
            BeginContext(133, 21, false);
#line 10 "E:\Final IndaneGas\IndaneApi\Views\Home\OtherproductCurrentStock.cshtml"
                   Write(ViewData["TotalLoad"]);

#line default
#line hidden
            EndContext();
            BeginContext(154, 51, true);
            WriteLiteral("</p>\r\n    </li>\r\n    <li>\r\n        <p>totalsales = ");
            EndContext();
            BeginContext(206, 21, false);
#line 13 "E:\Final IndaneGas\IndaneApi\Views\Home\OtherproductCurrentStock.cshtml"
                   Write(ViewData["TotalSale"]);

#line default
#line hidden
            EndContext();
            BeginContext(227, 46, true);
            WriteLiteral("</p>\r\n    </li>\r\n    <li>\r\n        <p>total = ");
            EndContext();
            BeginContext(274, 17, false);
#line 16 "E:\Final IndaneGas\IndaneApi\Views\Home\OtherproductCurrentStock.cshtml"
              Write(ViewData["Total"]);

#line default
#line hidden
            EndContext();
            BeginContext(291, 26, true);
            WriteLiteral("</p>\r\n    </li>\r\n</ul>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
