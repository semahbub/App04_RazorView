#pragma checksum "D:\WorkSpace\BITM9_ASPNETCore\Projects\App04_RazorView\App04_RazorView\Views\Home\SIngleFileInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5593b1b476af45c4f603a20b4c25741b73ca0709"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_SIngleFileInfo), @"mvc.1.0.view", @"/Views/Home/SIngleFileInfo.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5593b1b476af45c4f603a20b4c25741b73ca0709", @"/Views/Home/SIngleFileInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94b06dd6f0cd1377b132445b49dcae02d3db4f4e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_SIngleFileInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<App04_RazorView.Models.FileDetailInfo>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\WorkSpace\BITM9_ASPNETCore\Projects\App04_RazorView\App04_RazorView\Views\Home\SIngleFileInfo.cshtml"
  
    ViewData["Title"] = "SIngleFileInfo";
    int k = 100;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"alert alert-info\">SIngle File Info</h1>\r\n<br />\r\n<h3 class=\"alert alert-success\">");
#nullable restore
#line 9 "D:\WorkSpace\BITM9_ASPNETCore\Projects\App04_RazorView\App04_RazorView\Views\Home\SIngleFileInfo.cshtml"
                           Write(Model.FileName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<h3 class=\"alert alert-success\">");
#nullable restore
#line 10 "D:\WorkSpace\BITM9_ASPNETCore\Projects\App04_RazorView\App04_RazorView\Views\Home\SIngleFileInfo.cshtml"
                           Write(Model.FileExtension);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<h3 class=\"alert alert-success\">");
#nullable restore
#line 11 "D:\WorkSpace\BITM9_ASPNETCore\Projects\App04_RazorView\App04_RazorView\Views\Home\SIngleFileInfo.cshtml"
                           Write(Model.FileSize);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<h3 class=\"alert alert-success\">");
#nullable restore
#line 12 "D:\WorkSpace\BITM9_ASPNETCore\Projects\App04_RazorView\App04_RazorView\Views\Home\SIngleFileInfo.cshtml"
                           Write(Model.FilePath);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<br />\r\n\r\n<h2 class=\"alert alert-success\">Implicit Transition ");
#nullable restore
#line 15 "D:\WorkSpace\BITM9_ASPNETCore\Projects\App04_RazorView\App04_RazorView\Views\Home\SIngleFileInfo.cshtml"
                                               Write(k);

#line default
#line hidden
#nullable disable
            WriteLiteral(" + 50 </h2>\r\n<h2 class=\"alert alert-success\">Implicit Transition ");
#nullable restore
#line 16 "D:\WorkSpace\BITM9_ASPNETCore\Projects\App04_RazorView\App04_RazorView\Views\Home\SIngleFileInfo.cshtml"
                                               Write(k);

#line default
#line hidden
#nullable disable
            WriteLiteral("+50 </h2>\r\n<h2 class=\"alert alert-success\">Explicit Transition ");
#nullable restore
#line 17 "D:\WorkSpace\BITM9_ASPNETCore\Projects\App04_RazorView\App04_RazorView\Views\Home\SIngleFileInfo.cshtml"
                                                Write(k + 50 );

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<App04_RazorView.Models.FileDetailInfo> Html { get; private set; }
    }
}
#pragma warning restore 1591
