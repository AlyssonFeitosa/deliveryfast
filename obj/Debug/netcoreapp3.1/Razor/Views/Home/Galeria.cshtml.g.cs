#pragma checksum "C:\Users\Alysson Feitosa\Downloads\deliveryfast\Views\Home\Galeria.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea5d699cacbe464bf7186e3ecc05ac543de1f9bf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Galeria), @"mvc.1.0.view", @"/Views/Home/Galeria.cshtml")]
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
#line 1 "C:\Users\Alysson Feitosa\Downloads\deliveryfast\Views\_ViewImports.cshtml"
using deliveryfast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Alysson Feitosa\Downloads\deliveryfast\Views\_ViewImports.cshtml"
using deliveryfast.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea5d699cacbe464bf7186e3ecc05ac543de1f9bf", @"/Views/Home/Galeria.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e25c30f07b7ca6a1163981e8c2cb87c13f72eb2c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Galeria : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Alysson Feitosa\Downloads\deliveryfast\Views\Home\Galeria.cshtml"
  
    ViewData["Title"] = "Galeria de Fotos";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h3>");
#nullable restore
#line 4 "C:\Users\Alysson Feitosa\Downloads\deliveryfast\Views\Home\Galeria.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n\r\n<figure>\r\n\r\n<img src=\"img/paofrances.png\" class=\"img-fluid\">\r\n<a>&nbsp; &nbsp;</a>\r\n<img src=\"img/paocarteira.png\"class=\"img-fluid\">\r\n<a>&nbsp; &nbsp;</a>\r\n<img src=\"img/paofrances.png\"class=\"img-fluid\">\r\n<a>&nbsp; &nbsp;</a>\r\n\r\n</figure>");
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
