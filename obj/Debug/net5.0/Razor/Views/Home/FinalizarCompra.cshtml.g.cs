#pragma checksum "C:\Users\Desenvolvimento 2\Estudo\EcommerceAndrei\EcommerceAndrei2\Views\Home\FinalizarCompra.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c177a0e01ccc671281e8eaa00bfca2f1f92bc83"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_FinalizarCompra), @"mvc.1.0.view", @"/Views/Home/FinalizarCompra.cshtml")]
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
#line 1 "C:\Users\Desenvolvimento 2\Estudo\EcommerceAndrei\EcommerceAndrei2\Views\_ViewImports.cshtml"
using EcommerceAndrei2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Desenvolvimento 2\Estudo\EcommerceAndrei\EcommerceAndrei2\Views\_ViewImports.cshtml"
using EcommerceAndrei2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c177a0e01ccc671281e8eaa00bfca2f1f92bc83", @"/Views/Home/FinalizarCompra.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd8eb1e09e17fbfb48ee8ac8d9629af34b011c2b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_FinalizarCompra : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div>\r\n    <label >Nome</label>\r\n    <input type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 57, "\"", 65, 0);
            EndWriteAttribute();
            WriteLiteral(" name=\"q\" class=\"form-control form-control-sm\" placeholder=\"Nome\">\r\n\r\n    <label >E-mail</label>\r\n    <input onblur=\"validacaoEmail(this)\" id=\"email\" type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 227, "\"", 235, 0);
            EndWriteAttribute();
            WriteLiteral(" name=\"q\" class=\"form-control form-control-sm\" placeholder=\"E-mail\">\r\n    <span id=\"span\">E-mail inválido</span>\r\n\r\n    <label >Telefone</label>\r\n    <input id=\"telefone\" type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 418, "\"", 426, 0);
            EndWriteAttribute();
            WriteLiteral(@" name=""q"" class=""form-control form-control-sm"" placeholder=""Telefone"">
</div>

<script>
    $(""#telefone"").mask(""(999) 9999-9999"");
    function validacaoEmail(e) {
        if ($(e).val() != """") {
            if (!validateEmail(e)) {
                $(e).addClass(""input-validation-error"");
                $(e).parent().find(""#span"").show();
            }
        }
    }
</script>");
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