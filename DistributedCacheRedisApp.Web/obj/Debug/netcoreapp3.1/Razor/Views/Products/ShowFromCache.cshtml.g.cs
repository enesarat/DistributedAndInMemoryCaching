#pragma checksum "C:\Users\Enes\source\repos\DistributedAndInMemoryCaching\DistributedCacheRedisApp.Web\Views\Products\ShowFromCache.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f1b1f1bd38fc988ba51e624ca698c5da5815830"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_ShowFromCache), @"mvc.1.0.view", @"/Views/Products/ShowFromCache.cshtml")]
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
#line 1 "C:\Users\Enes\source\repos\DistributedAndInMemoryCaching\DistributedCacheRedisApp.Web\Views\_ViewImports.cshtml"
using DistributedCacheRedisApp.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Enes\source\repos\DistributedAndInMemoryCaching\DistributedCacheRedisApp.Web\Views\_ViewImports.cshtml"
using DistributedCacheRedisApp.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f1b1f1bd38fc988ba51e624ca698c5da5815830", @"/Views/Products/ShowFromCache.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e388ea504c86fca918d06d0a8b30703ac33b495e", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_ShowFromCache : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Enes\source\repos\DistributedAndInMemoryCaching\DistributedCacheRedisApp.Web\Views\Products\ShowFromCache.cshtml"
  
    ViewData["Title"] = "ShowFromCache";
    var product = ViewBag.complexTypeProduct as Product;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Data From Distributed Cache</h1>\r\n<hr />\r\n<h2>Primitive Type Data</h2>\r\n<h3>");
#nullable restore
#line 10 "C:\Users\Enes\source\repos\DistributedAndInMemoryCaching\DistributedCacheRedisApp.Web\Views\Products\ShowFromCache.cshtml"
Write(ViewBag.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<hr />\r\n<h2>Complex Type Data</h2>\r\n<h3>Id: ");
#nullable restore
#line 13 "C:\Users\Enes\source\repos\DistributedAndInMemoryCaching\DistributedCacheRedisApp.Web\Views\Products\ShowFromCache.cshtml"
   Write(product.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Name: ");
#nullable restore
#line 13 "C:\Users\Enes\source\repos\DistributedAndInMemoryCaching\DistributedCacheRedisApp.Web\Views\Products\ShowFromCache.cshtml"
                            Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("  Price: ");
#nullable restore
#line 13 "C:\Users\Enes\source\repos\DistributedAndInMemoryCaching\DistributedCacheRedisApp.Web\Views\Products\ShowFromCache.cshtml"
                                                  Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n");
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
