#pragma checksum "C:\Users\helle\source\repos\MyFinance\MyFinance\Views\Conta\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d59b90108325bf821cac4715833b4356d6291ab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Conta_Index), @"mvc.1.0.view", @"/Views/Conta/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Conta/Index.cshtml", typeof(AspNetCore.Views_Conta_Index))]
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
#line 1 "C:\Users\helle\source\repos\MyFinance\MyFinance\Views\_ViewImports.cshtml"
using MyFinance;

#line default
#line hidden
#line 2 "C:\Users\helle\source\repos\MyFinance\MyFinance\Views\_ViewImports.cshtml"
using MyFinance.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d59b90108325bf821cac4715833b4356d6291ab", @"/Views/Conta/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d05dd6abef5a8ff60f9a555c67ee727241a6c480", @"/Views/_ViewImports.cshtml")]
    public class Views_Conta_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\helle\source\repos\MyFinance\MyFinance\Views\Conta\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(43, 226, true);
            WriteLiteral("    \r\n<h3>Conta</h3>\r\n<table class=\"table table-bordered\">\r\n\r\n    <thead>\r\n        <tr>\r\n            <th>#</th>\r\n            <th>Id</th>\r\n            <th>Nome</th>\r\n            <th>Conta</th>\r\n        </tr>\r\n\r\n    </thead>\r\n\r\n");
            EndContext();
#line 19 "C:\Users\helle\source\repos\MyFinance\MyFinance\Views\Conta\Index.cshtml"
      
        foreach (var item in (List<ContaModel>)ViewBag.ListaConta)    //Cast explicito  - Conversões explicitas
        {

#line default
#line hidden
            BeginContext(401, 121, true);
            WriteLiteral("            <tbody>\r\n                    <tr>\r\n\r\n                        <td><button type=\"button\" class=\"btn btn-danger\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 522, "\"", 560, 3);
            WriteAttributeValue("", 532, "Excluir(", 532, 8, true);
#line 25 "C:\Users\helle\source\repos\MyFinance\MyFinance\Views\Conta\Index.cshtml"
WriteAttributeValue("", 540, item.Id.ToString(), 540, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 559, ")", 559, 1, true);
            EndWriteAttribute();
            BeginContext(561, 45, true);
            WriteLiteral("> Excluir </td>\r\n                        <td>");
            EndContext();
            BeginContext(607, 18, false);
#line 26 "C:\Users\helle\source\repos\MyFinance\MyFinance\Views\Conta\Index.cshtml"
                       Write(item.Id.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(625, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(661, 20, false);
#line 27 "C:\Users\helle\source\repos\MyFinance\MyFinance\Views\Conta\Index.cshtml"
                       Write(item.Nome.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(681, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(717, 24, false);
#line 28 "C:\Users\helle\source\repos\MyFinance\MyFinance\Views\Conta\Index.cshtml"
                       Write(item.Saldo.ToString("C"));

#line default
#line hidden
            EndContext();
            BeginContext(741, 60, true);
            WriteLiteral("</td>\r\n\r\n                    </tr>\r\n\r\n            </tbody>\r\n");
            EndContext();
#line 33 "C:\Users\helle\source\repos\MyFinance\MyFinance\Views\Conta\Index.cshtml"
        }
    

#line default
#line hidden
            BeginContext(819, 93, true);
            WriteLiteral(" </table>\r\n\r\n<button type=\"button\" onclick=\"CriarConta()\" class=\"btn btn-block btn-primary\"> ");
            EndContext();
            BeginContext(995, 465, true);
            WriteLiteral(@"
    Criar Conta
</button>

<script>

    function CriarConta () {
    window.location.href = ""../Conta/CriarConta"" //acessando minha view CriarConta formar diferente de usar: <a href=""../Usuario/Login""> aqui </a> 
    }

    
    function Excluir(id_conta){
        window.location.href = ""../Conta/ExcluirConta/"" + id_conta; //Na rota (Statup) permite concatenar os valores. Chamando minha controller Conta e o método ExcluirConta
     }

</script>");
            EndContext();
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