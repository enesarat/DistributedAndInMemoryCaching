#pragma checksum "C:\Users\Enes\source\repos\DistributedAndInMemoryCaching\InMemoryApp.Web\Views\Product\GetDataFromCache.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a90f184960176d5c4d0cd0f19ce7e2e6296706d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_GetDataFromCache), @"mvc.1.0.view", @"/Views/Product/GetDataFromCache.cshtml")]
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
#line 1 "C:\Users\Enes\source\repos\DistributedAndInMemoryCaching\InMemoryApp.Web\Views\_ViewImports.cshtml"
using InMemoryApp.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Enes\source\repos\DistributedAndInMemoryCaching\InMemoryApp.Web\Views\_ViewImports.cshtml"
using InMemoryApp.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a90f184960176d5c4d0cd0f19ce7e2e6296706d", @"/Views/Product/GetDataFromCache.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1394e55ecf3bf10c19f50bbe19ff315dcbe4ad68", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_GetDataFromCache : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Enes\source\repos\DistributedAndInMemoryCaching\InMemoryApp.Web\Views\Product\GetDataFromCache.cshtml"
  
    ViewData["Title"] = "GetDataFromCache";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Data From Cache</h1>\r\n<p>");
#nullable restore
#line 7 "C:\Users\Enes\source\repos\DistributedAndInMemoryCaching\InMemoryApp.Web\Views\Product\GetDataFromCache.cshtml"
Write(ViewBag.time);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n");
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
