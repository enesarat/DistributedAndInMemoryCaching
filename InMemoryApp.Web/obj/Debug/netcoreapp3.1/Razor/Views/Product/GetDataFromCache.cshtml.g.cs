#pragma checksum "C:\Users\Enes\source\repos\DistributedAndInMemoryCaching\InMemoryApp.Web\Views\Product\GetDataFromCache.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e20d4fed2dd08c71798cf06b382b83cf374e231"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e20d4fed2dd08c71798cf06b382b83cf374e231", @"/Views/Product/GetDataFromCache.cshtml")]
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
            WriteLiteral("\r\n<h1>Data From Cache</h1>\r\n<br />\r\n<p>Cached Time Data: ");
#nullable restore
#line 8 "C:\Users\Enes\source\repos\DistributedAndInMemoryCaching\InMemoryApp.Web\Views\Product\GetDataFromCache.cshtml"
                Write(ViewBag.time);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<hr />\r\n<p>Cached Time Data(with absolute life time): ");
#nullable restore
#line 10 "C:\Users\Enes\source\repos\DistributedAndInMemoryCaching\InMemoryApp.Web\Views\Product\GetDataFromCache.cshtml"
                                         Write(ViewBag.timeWithAbsoluteExpireTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>");
#nullable restore
#line 11 "C:\Users\Enes\source\repos\DistributedAndInMemoryCaching\InMemoryApp.Web\Views\Product\GetDataFromCache.cshtml"
Write(ViewBag.callback1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<hr />\r\n<p>Cached Time Data(with sliding life time): ");
#nullable restore
#line 13 "C:\Users\Enes\source\repos\DistributedAndInMemoryCaching\InMemoryApp.Web\Views\Product\GetDataFromCache.cshtml"
                                        Write(ViewBag.timeWithSlidingExpireTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>");
#nullable restore
#line 14 "C:\Users\Enes\source\repos\DistributedAndInMemoryCaching\InMemoryApp.Web\Views\Product\GetDataFromCache.cshtml"
Write(ViewBag.callback2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<hr />\r\n<p>Cached Time Data(with absolute+sliding life time): ");
#nullable restore
#line 16 "C:\Users\Enes\source\repos\DistributedAndInMemoryCaching\InMemoryApp.Web\Views\Product\GetDataFromCache.cshtml"
                                                 Write(ViewBag.timeWithAbsoluteAndSlidingExpireTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>");
#nullable restore
#line 17 "C:\Users\Enes\source\repos\DistributedAndInMemoryCaching\InMemoryApp.Web\Views\Product\GetDataFromCache.cshtml"
Write(ViewBag.callback3);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
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
