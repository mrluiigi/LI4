#pragma checksum "C:\Users\Barbosa\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\ConfecionaReceita.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36592ff12fc4fc817836839cd363ebbea2390c02"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ReceitaView_ConfecionaReceita), @"mvc.1.0.view", @"/Views/ReceitaView/ConfecionaReceita.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ReceitaView/ConfecionaReceita.cshtml", typeof(AspNetCore.Views_ReceitaView_ConfecionaReceita))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36592ff12fc4fc817836839cd363ebbea2390c02", @"/Views/ReceitaView/ConfecionaReceita.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0cfabe0b49a2ea3b364ec6f27b5c32b3c3b437b", @"/Views/_ViewImports.cshtml")]
    public class Views_ReceitaView_ConfecionaReceita : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebChef.Models.Passo[]>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ReceitaView", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ConfecionaReceita", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ConcluirReceita", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(31, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Barbosa\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\ConfecionaReceita.cshtml"
  
    ViewData["Title"] = "ConfecionaReceita";

#line default
#line hidden
            BeginContext(86, 19, true);
            WriteLiteral("\r\n<!DOCTYPE HTML>\r\n");
            EndContext();
#line 8 "C:\Users\Barbosa\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\ConfecionaReceita.cshtml"
 if (@ViewBag.duracao != null)
{

#line default
#line hidden
            BeginContext(140, 18, true);
            WriteLiteral("    <html>\r\n\r\n    ");
            EndContext();
            BeginContext(158, 269, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "36592ff12fc4fc817836839cd363ebbea2390c025531", async() => {
                BeginContext(164, 256, true);
                WriteLiteral(@"
        <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
        <style>
            p {
                text-align: center;
                font-size: 60px;
                margin-top: 0px;
            }
        </style>
    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(427, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(433, 1607, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "36592ff12fc4fc817836839cd363ebbea2390c026976", async() => {
                BeginContext(439, 83, true);
                WriteLiteral("\r\n\r\n        <p id=\"demo\"></p>\r\n\r\n        <script>\r\n            var countDownDate = ");
                EndContext();
                BeginContext(523, 15, false);
#line 27 "C:\Users\Barbosa\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\ConfecionaReceita.cshtml"
                           Write(ViewBag.duracao);

#line default
#line hidden
                EndContext();
                BeginContext(538, 1495, true);
                WriteLiteral(@";
            var hours = Math.floor((countDownDate % (60 * 60 * 24)) / (60 * 60));
            var minutes = Math.floor((countDownDate % (60 * 60)) / (60));
            var seconds = Math.floor((countDownDate % 60));
            document.getElementById(""demo"").innerHTML = hours + "":"" + minutes + "":"" + seconds;
            var y = 0;
            var x;

            function startTime() {


                // Atualizador o contador a cada segundo
                x = setInterval(function () {
                    hours = Math.floor((countDownDate % (60 * 60 * 24)) / (60 * 60));
                    minutes = Math.floor((countDownDate % (60 * 60)) / (60));
                    seconds = Math.floor((countDownDate % 60));
                    // O output é um valor com o id ""demo""
                    document.getElementById(""demo"").innerHTML = hours + "":"" + minutes + "":"" + seconds;

                    // Quando o temporizador acaba escreve Terminou!
                    if (countDownDate < 0) {
  ");
                WriteLiteral(@"                      clearInterval(x);
                        document.getElementById(""demo"").innerHTML = ""Terminou!"";
                    } else countDownDate--
                }, 1000);

            }

            /**/</script>
        <div class=""col text-center"">
            <button class=""btn btn-primary"" onclick=""startTime()"">Start</button>
            <button class=""btn btn-primary"" onclick=""clearInterval(x)"">Stop</button>
        </div>


    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2040, 11, true);
            WriteLiteral("\r\n</html>\r\n");
            EndContext();
#line 64 "C:\Users\Barbosa\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\ConfecionaReceita.cshtml"
}

#line default
#line hidden
            BeginContext(2054, 6, true);
            WriteLiteral("\r\n<h1>");
            EndContext();
            BeginContext(2061, 35, false);
#line 66 "C:\Users\Barbosa\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\ConfecionaReceita.cshtml"
Write(Model[@ViewBag.passo - 1].descricao);

#line default
#line hidden
            EndContext();
            BeginContext(2096, 15, true);
            WriteLiteral("</h1>\r\n\r\n\r\n<h5>");
            EndContext();
            BeginContext(2112, 40, false);
#line 69 "C:\Users\Barbosa\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\ConfecionaReceita.cshtml"
Write(Model[@ViewBag.passo - 1].Acao.descricao);

#line default
#line hidden
            EndContext();
            BeginContext(2152, 11, true);
            WriteLiteral("</h5>\r\n\r\n\r\n");
            EndContext();
#line 72 "C:\Users\Barbosa\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\ConfecionaReceita.cshtml"
 if(ViewBag.link != null)
{

#line default
#line hidden
            BeginContext(2193, 36, true);
            WriteLiteral("    <iframe width=\"560\" height=\"315\"");
            EndContext();
            BeginWriteAttribute("src", " src=", 2229, "", 2247, 1);
#line 74 "C:\Users\Barbosa\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\ConfecionaReceita.cshtml"
WriteAttributeValue("", 2234, ViewBag.link, 2234, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2247, 44, true);
            WriteLiteral(" frameborder=\"0\" allowfullscreen></iframe>\r\n");
            EndContext();
#line 75 "C:\Users\Barbosa\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\ConfecionaReceita.cshtml"
}

#line default
#line hidden
            BeginContext(2294, 21, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n");
            EndContext();
#line 78 "C:\Users\Barbosa\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\ConfecionaReceita.cshtml"
     foreach (var ing in @Model[@ViewBag.passo - 1].ingredientes)
    {


#line default
#line hidden
            BeginContext(2391, 128, true);
            WriteLiteral("        <div class=\"col-md-2\">\r\n            <figure class=\"img my-4\">\r\n                <img class=\"figure-img img-fluid rounded\"");
            EndContext();
            BeginWriteAttribute("src", " src=", 2519, "", 2548, 1);
#line 83 "C:\Users\Barbosa\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\ConfecionaReceita.cshtml"
WriteAttributeValue("", 2524, Url.Content(ing.imagem), 2524, 24, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2548, 91, true);
            WriteLiteral(" style=\"width: 150px; height: 150px;\">\r\n                <figcaption class=\"figure-caption\">");
            EndContext();
            BeginContext(2640, 14, false);
#line 84 "C:\Users\Barbosa\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\ConfecionaReceita.cshtml"
                                              Write(ing.designacao);

#line default
#line hidden
            EndContext();
            BeginContext(2654, 2, true);
            WriteLiteral(" (");
            EndContext();
            BeginContext(2657, 14, false);
#line 84 "C:\Users\Barbosa\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\ConfecionaReceita.cshtml"
                                                               Write(ing.quantidade);

#line default
#line hidden
            EndContext();
            BeginContext(2671, 55, true);
            WriteLiteral(")</figcaption>\r\n            </figure>\r\n        </div>\r\n");
            EndContext();
#line 87 "C:\Users\Barbosa\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\ConfecionaReceita.cshtml"

    }

#line default
#line hidden
            BeginContext(2735, 53, true);
            WriteLiteral("</div>\r\n\r\n<div class=\"btn-group my-4\" role=\"group\">\r\n");
            EndContext();
#line 92 "C:\Users\Barbosa\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\ConfecionaReceita.cshtml"
     if (@ViewBag.passo > 1)
    {

#line default
#line hidden
            BeginContext(2825, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(2833, 184, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "36592ff12fc4fc817836839cd363ebbea2390c0214547", async() => {
                BeginContext(2981, 32, true);
                WriteLiteral("\r\n            Anterior\r\n        ");
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
#line 94 "C:\Users\Barbosa\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\ConfecionaReceita.cshtml"
                                                                        WriteLiteral(ViewBag.id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 94 "C:\Users\Barbosa\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\ConfecionaReceita.cshtml"
                                                                                                    WriteLiteral(ViewBag.anterior);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["passo"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-passo", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["passo"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3017, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 97 "C:\Users\Barbosa\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\ConfecionaReceita.cshtml"
    }

#line default
#line hidden
            BeginContext(3026, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 99 "C:\Users\Barbosa\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\ConfecionaReceita.cshtml"
     if (@ViewBag.passo + 1 <= @ViewBag.tamanho)
    {

#line default
#line hidden
            BeginContext(3085, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(3093, 184, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "36592ff12fc4fc817836839cd363ebbea2390c0218525", async() => {
                BeginContext(3241, 32, true);
                WriteLiteral("\r\n            Seguinte\r\n        ");
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
#line 101 "C:\Users\Barbosa\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\ConfecionaReceita.cshtml"
                                                                        WriteLiteral(ViewBag.id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 101 "C:\Users\Barbosa\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\ConfecionaReceita.cshtml"
                                                                                                    WriteLiteral(ViewBag.seguinte);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["passo"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-passo", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["passo"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3277, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 104 "C:\Users\Barbosa\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\ConfecionaReceita.cshtml"
    }

#line default
#line hidden
            BeginContext(3286, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 106 "C:\Users\Barbosa\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\ConfecionaReceita.cshtml"
     if (@ViewBag.passo == @ViewBag.tamanho)
    {

#line default
#line hidden
            BeginContext(3341, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(3349, 146, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "36592ff12fc4fc817836839cd363ebbea2390c0222503", async() => {
                BeginContext(3459, 32, true);
                WriteLiteral("\r\n            Concluir\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 108 "C:\Users\Barbosa\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\ConfecionaReceita.cshtml"
                                                                      WriteLiteral(ViewBag.id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3495, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 111 "C:\Users\Barbosa\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\ConfecionaReceita.cshtml"
    }

#line default
#line hidden
            BeginContext(3504, 8, true);
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebChef.Models.Passo[]> Html { get; private set; }
    }
}
#pragma warning restore 1591
