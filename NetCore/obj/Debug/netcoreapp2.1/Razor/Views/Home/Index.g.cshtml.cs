#pragma checksum "/Users/ncopado/Projects/NetCore/NetCore/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f9331ab33e0192a57d87483fd99f280e1b8bd0e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "/Users/ncopado/Projects/NetCore/NetCore/Views/_ViewImports.cshtml"
using NetCore;

#line default
#line hidden
#line 2 "/Users/ncopado/Projects/NetCore/NetCore/Views/_ViewImports.cshtml"
using NetCore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f9331ab33e0192a57d87483fd99f280e1b8bd0e", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68c593e2973db2472dd8ea7ea162ebc292929aa7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<NetCore.Models.Album>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "/Users/ncopado/Projects/NetCore/NetCore/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(80, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "/Users/ncopado/Projects/NetCore/NetCore/Views/Home/Index.cshtml"
 foreach  (var item in Model)
{

#line default
#line hidden
            BeginContext(116, 22, true);
            WriteLiteral("    <input type=\"text\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 138, "\"", 154, 1);
#line 8 "/Users/ncopado/Projects/NetCore/NetCore/Views/Home/Index.cshtml"
WriteAttributeValue("", 146, item.Id, 146, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(155, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
            BeginContext(162, 22, true);
            WriteLiteral("    <input type=\"text\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 184, "\"", 202, 1);
#line 10 "/Users/ncopado/Projects/NetCore/NetCore/Views/Home/Index.cshtml"
WriteAttributeValue("", 192, item.Name, 192, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(203, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
#line 11 "/Users/ncopado/Projects/NetCore/NetCore/Views/Home/Index.cshtml"

}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<NetCore.Models.Album>> Html { get; private set; }
    }
}
#pragma warning restore 1591
