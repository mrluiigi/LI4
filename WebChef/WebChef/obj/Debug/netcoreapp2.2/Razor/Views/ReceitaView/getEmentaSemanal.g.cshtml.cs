#pragma checksum "C:\Users\jose9\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\getEmentaSemanal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69adf75b2476e03e1d084995f35bba8ed82890dc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ReceitaView_getEmentaSemanal), @"mvc.1.0.view", @"/Views/ReceitaView/getEmentaSemanal.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ReceitaView/getEmentaSemanal.cshtml", typeof(AspNetCore.Views_ReceitaView_getEmentaSemanal))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69adf75b2476e03e1d084995f35bba8ed82890dc", @"/Views/ReceitaView/getEmentaSemanal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0cfabe0b49a2ea3b364ec6f27b5c32b3c3b437b", @"/Views/_ViewImports.cshtml")]
    public class Views_ReceitaView_getEmentaSemanal : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebChef.Models.EmentaSemanal>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ReceitaView", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "getReceita", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "removeReceitaEmenta", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ListaCompras", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\jose9\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\getEmentaSemanal.cshtml"
  
    ViewData["Title"] = "EmentaSemanal";
    ViewBag.diasSemana = new List<string> { "Segunda", "Terça", "Quarta", "Quinta", "Sexta", "Sábado", "Domingo"};

#line default
#line hidden
            BeginContext(215, 52, true);
            WriteLiteral("\r\n<h1>Ementa Semanal</h1>\r\n\r\n<table class=\"table\">\r\n");
            EndContext();
#line 10 "C:\Users\jose9\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\getEmentaSemanal.cshtml"
     foreach (var dia in ViewBag.diasSemana) {

#line default
#line hidden
            BeginContext(315, 11, true);
            WriteLiteral("        <tr");
            EndContext();
            BeginWriteAttribute("bgcolor", " bgcolor=\'", 326, "\'", 345, 1);
#line 11 "C:\Users\jose9\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\getEmentaSemanal.cshtml"
WriteAttributeValue("", 336, "#EEE", 336, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(346, 37, true);
            WriteLiteral(">\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(384, 3, false);
#line 13 "C:\Users\jose9\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\getEmentaSemanal.cshtml"
           Write(dia);

#line default
#line hidden
            EndContext();
            BeginContext(387, 75, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n\r\n            </th>\r\n        </tr>\r\n");
            EndContext();
#line 20 "C:\Users\jose9\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\getEmentaSemanal.cshtml"
         foreach (var e in Model)
        {
            if (e.dia_da_semana.Substring(0, 3).Equals(dia.Substring(0,3))) {

#line default
#line hidden
            BeginContext(589, 14, true);
            WriteLiteral("        <tr>\r\n");
            EndContext();
#line 24 "C:\Users\jose9\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\getEmentaSemanal.cshtml"
             if (e.dia_da_semana.Substring(3, 1).Equals("A"))
            {

#line default
#line hidden
            BeginContext(681, 73, true);
            WriteLiteral("                <th>\r\n                    Almoço\r\n                </th>\r\n");
            EndContext();
#line 29 "C:\Users\jose9\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\getEmentaSemanal.cshtml"
            }
            else if (e.dia_da_semana.Substring(3, 1).Equals("J"))
            {

#line default
#line hidden
            BeginContext(851, 73, true);
            WriteLiteral("                <th>\r\n                    Jantar\r\n                </th>\r\n");
            EndContext();
#line 35 "C:\Users\jose9\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\getEmentaSemanal.cshtml"
            }
            else if (e.dia_da_semana.Substring(3, 1).Equals("O"))
            {

#line default
#line hidden
            BeginContext(1021, 72, true);
            WriteLiteral("                <th>\r\n                    Outro\r\n                </th>\r\n");
            EndContext();
#line 41 "C:\Users\jose9\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\getEmentaSemanal.cshtml"
            }

#line default
#line hidden
            BeginContext(1108, 60, true);
            WriteLiteral("\r\n            <td class=\"text-center\"><img class=\"img-fluid\"");
            EndContext();
            BeginWriteAttribute("src", " src=", 1168, "", 1203, 1);
#line 43 "C:\Users\jose9\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\getEmentaSemanal.cshtml"
WriteAttributeValue("", 1173, Url.Content(e.receita.imagem), 1173, 30, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1203, 44, true);
            WriteLiteral(" /></td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1247, 183, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "69adf75b2476e03e1d084995f35bba8ed82890dc8789", async() => {
                BeginContext(1338, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(1361, 47, false);
#line 46 "C:\Users\jose9\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\getEmentaSemanal.cshtml"
               Write(Html.DisplayFor(modelreceita => e.receita.nome));

#line default
#line hidden
                EndContext();
                BeginContext(1408, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 45 "C:\Users\jose9\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\getEmentaSemanal.cshtml"
                                                                         WriteLiteral(e.receita.id_receita);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1430, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1485, 234, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "69adf75b2476e03e1d084995f35bba8ed82890dc11865", async() => {
                BeginContext(1642, 73, true);
                WriteLiteral("\r\n                    Remover Receita de Ementa Semanal\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 50 "C:\Users\jose9\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\getEmentaSemanal.cshtml"
                                                                                  WriteLiteral(e.receita.id_receita);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 50 "C:\Users\jose9\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\getEmentaSemanal.cshtml"
                                                                                                                      WriteLiteral(e.dia_da_semana);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["dia"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-dia", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["dia"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1719, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 55 "C:\Users\jose9\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\getEmentaSemanal.cshtml"
            }
        }

#line default
#line hidden
#line 56 "C:\Users\jose9\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\getEmentaSemanal.cshtml"
         
    }

#line default
#line hidden
            BeginContext(1788, 12, true);
            WriteLiteral("</table>\r\n\r\n");
            EndContext();
            BeginContext(1800, 102, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "69adf75b2476e03e1d084995f35bba8ed82890dc15827", async() => {
                BeginContext(1882, 16, true);
                WriteLiteral("Lista de compras");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebChef.Models.EmentaSemanal>> Html { get; private set; }
    }
}
#pragma warning restore 1591
