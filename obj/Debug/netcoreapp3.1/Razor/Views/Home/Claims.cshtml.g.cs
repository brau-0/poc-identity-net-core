#pragma checksum "E:\Central LIMS\POC Login\Login\TestIdentity\Views\Home\Claims.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00a833dc4ab359a4acbfba13333826a5c586ec79"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Claims), @"mvc.1.0.view", @"/Views/Home/Claims.cshtml")]
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
#line 1 "E:\Central LIMS\POC Login\Login\TestIdentity\Views\_ViewImports.cshtml"
using POCIdentity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Central LIMS\POC Login\Login\TestIdentity\Views\_ViewImports.cshtml"
using POCIdentity.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00a833dc4ab359a4acbfba13333826a5c586ec79", @"/Views/Home/Claims.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03533bb41aeb98cdae121700b405dda9dcdeea65", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Claims : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\Central LIMS\POC Login\Login\TestIdentity\Views\Home\Claims.cshtml"
  
    ViewData["Title"] = "View User Claims";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 4 "E:\Central LIMS\POC Login\Login\TestIdentity\Views\Home\Claims.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<br />\r\n");
#nullable restore
#line 6 "E:\Central LIMS\POC Login\Login\TestIdentity\Views\Home\Claims.cshtml"
 if (User.Identity.IsAuthenticated)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"table table-responsive-sm\">\r\n");
#nullable restore
#line 9 "E:\Central LIMS\POC Login\Login\TestIdentity\Views\Home\Claims.cshtml"
         foreach (var claim in User.Claims)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 12 "E:\Central LIMS\POC Login\Login\TestIdentity\Views\Home\Claims.cshtml"
               Write(claim.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 13 "E:\Central LIMS\POC Login\Login\TestIdentity\Views\Home\Claims.cshtml"
               Write(claim.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 14 "E:\Central LIMS\POC Login\Login\TestIdentity\Views\Home\Claims.cshtml"
               Write(claim.Issuer);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 16 "E:\Central LIMS\POC Login\Login\TestIdentity\Views\Home\Claims.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n");
#nullable restore
#line 18 "E:\Central LIMS\POC Login\Login\TestIdentity\Views\Home\Claims.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591