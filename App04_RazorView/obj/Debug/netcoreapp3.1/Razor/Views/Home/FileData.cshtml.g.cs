#pragma checksum "D:\WorkSpace\BITM9_ASPNETCore\Projects\App04_RazorView\App04_RazorView\Views\Home\FileData.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44966b07c98b86315626228257e74c8e91114ed4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_FileData), @"mvc.1.0.view", @"/Views/Home/FileData.cshtml")]
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
#line 1 "D:\WorkSpace\BITM9_ASPNETCore\Projects\App04_RazorView\App04_RazorView\Views\_ViewImports.cshtml"
using App04_RazorView;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\WorkSpace\BITM9_ASPNETCore\Projects\App04_RazorView\App04_RazorView\Views\_ViewImports.cshtml"
using App04_RazorView.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44966b07c98b86315626228257e74c8e91114ed4", @"/Views/Home/FileData.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94b06dd6f0cd1377b132445b49dcae02d3db4f4e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_FileData : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\WorkSpace\BITM9_ASPNETCore\Projects\App04_RazorView\App04_RazorView\Views\Home\FileData.cshtml"
  
    ViewData["Title"] = "FileData";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n        <h2 class=\"alert alert-info\">File Content</h2>\r\n    </div>\r\n</div>\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n");
#nullable restore
#line 14 "D:\WorkSpace\BITM9_ASPNETCore\Projects\App04_RazorView\App04_RazorView\Views\Home\FileData.cshtml"
         foreach (var item in ViewBag.line)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p class=\"text-justify\">");
#nullable restore
#line 16 "D:\WorkSpace\BITM9_ASPNETCore\Projects\App04_RazorView\App04_RazorView\Views\Home\FileData.cshtml"
                               Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 17 "D:\WorkSpace\BITM9_ASPNETCore\Projects\App04_RazorView\App04_RazorView\Views\Home\FileData.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n\r\n\r\n");
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