#pragma checksum "D:\Visual Studio projects\WebApplication5\WebApplication5\Views\Admin\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69e627094a509d0ef5cddfb0636bfa0472831674"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Details), @"mvc.1.0.view", @"/Views/Admin/Details.cshtml")]
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
#line 1 "D:\Visual Studio projects\WebApplication5\WebApplication5\Views\_ViewImports.cshtml"
using WebApplication5;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Visual Studio projects\WebApplication5\WebApplication5\Views\_ViewImports.cshtml"
using WebApplication5.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69e627094a509d0ef5cddfb0636bfa0472831674", @"/Views/Admin/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ac7a6a20369a094c1643b76f0e92e19ec3cef6a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Visual Studio projects\WebApplication5\WebApplication5\Views\Admin\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Details</h1>\r\n<div>\r\n    <h4>\r\n      ");
#nullable restore
#line 9 "D:\Visual Studio projects\WebApplication5\WebApplication5\Views\Admin\Details.cshtml"
 Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </h4>\r\n    <h4>\r\n        ");
#nullable restore
#line 12 "D:\Visual Studio projects\WebApplication5\WebApplication5\Views\Admin\Details.cshtml"
   Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </h4>\r\n       <h4>\r\n      ");
#nullable restore
#line 15 "D:\Visual Studio projects\WebApplication5\WebApplication5\Views\Admin\Details.cshtml"
 Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </h4>\r\n    <h4>\r\n        ");
#nullable restore
#line 18 "D:\Visual Studio projects\WebApplication5\WebApplication5\Views\Admin\Details.cshtml"
   Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </h4>\r\n       <h4>\r\n      ");
#nullable restore
#line 21 "D:\Visual Studio projects\WebApplication5\WebApplication5\Views\Admin\Details.cshtml"
 Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </h4>\r\n    <h4>\r\n        ");
#nullable restore
#line 24 "D:\Visual Studio projects\WebApplication5\WebApplication5\Views\Admin\Details.cshtml"
   Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </h4>\r\n       <h4>\r\n      ");
#nullable restore
#line 27 "D:\Visual Studio projects\WebApplication5\WebApplication5\Views\Admin\Details.cshtml"
 Write(Html.DisplayNameFor(model => model.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </h4>\r\n    <h4>\r\n        ");
#nullable restore
#line 30 "D:\Visual Studio projects\WebApplication5\WebApplication5\Views\Admin\Details.cshtml"
   Write(Html.DisplayFor(model => model.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </h4>\r\n    <h4>\r\n        ");
#nullable restore
#line 33 "D:\Visual Studio projects\WebApplication5\WebApplication5\Views\Admin\Details.cshtml"
   Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </h4>\r\n       <h4>\r\n      ");
#nullable restore
#line 36 "D:\Visual Studio projects\WebApplication5\WebApplication5\Views\Admin\Details.cshtml"
 Write(Html.DisplayNameFor(model => model.StartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </h4>\r\n    <h4>\r\n        ");
#nullable restore
#line 39 "D:\Visual Studio projects\WebApplication5\WebApplication5\Views\Admin\Details.cshtml"
   Write(Html.DisplayFor(model => model.StartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </h4>\r\n    <h4>\r\n        ");
#nullable restore
#line 42 "D:\Visual Studio projects\WebApplication5\WebApplication5\Views\Admin\Details.cshtml"
   Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </h4>\r\n</div>\r\n<div>\r\n    <p>\r\n        ");
#nullable restore
#line 48 "D:\Visual Studio projects\WebApplication5\WebApplication5\Views\Admin\Details.cshtml"
   Write(Html.ActionLink("Back to Home", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </p");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
