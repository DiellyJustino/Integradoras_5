#pragma checksum "C:\Users\diell\Desktop\Integradoras_5\Views\Animal\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d9e4b2a3ee470d88c9a1991eb8ebf15a00ec5e3e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Animal_Delete), @"mvc.1.0.view", @"/Views/Animal/Delete.cshtml")]
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
#line 1 "C:\Users\diell\Desktop\Integradoras_5\Views\_ViewImports.cshtml"
using CaoLendario.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\diell\Desktop\Integradoras_5\Views\_ViewImports.cshtml"
using CaoLendario.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9e4b2a3ee470d88c9a1991eb8ebf15a00ec5e3e", @"/Views/Animal/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e58fa1ec7b980f070977ad8132a6c90f13d0949f", @"/Views/_ViewImports.cshtml")]
    public class Views_Animal_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CaoLendario.Models.Animal>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "New", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("botoes-delete container-animal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\diell\Desktop\Integradoras_5\Views\Animal\Delete.cshtml"
  
    ViewData["Title"] = "Deletar Animal";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section class=\"content-view\">\r\n    <h3>");
#nullable restore
#line 9 "C:\Users\diell\Desktop\Integradoras_5\Views\Animal\Delete.cshtml"
   Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    <div class=\"container-animal\">\r\n        <div class=\"dados-animal grid-12\">\r\n            <div class=\"head-animal\">\r\n                <p>");
#nullable restore
#line 13 "C:\Users\diell\Desktop\Integradoras_5\Views\Animal\Delete.cshtml"
              Write(Model.AnimalID.ToString("00000"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 13 "C:\Users\diell\Desktop\Integradoras_5\Views\Animal\Delete.cshtml"
                                                  Write(Model.NomeAnimal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n            <div class=\"img-animal grid-6\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 478, "\"", 498, 1);
#nullable restore
#line 16 "C:\Users\diell\Desktop\Integradoras_5\Views\Animal\Delete.cshtml"
WriteAttributeValue("", 484, Model.UrlFoto, 484, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </div>\r\n            <div class=\"grid-6 descricao-animal\">\r\n                <div class=\"box-descricao\">\r\n                    <p>Nascimento</p>\r\n                    <input readonly type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 706, "\"", 754, 1);
#nullable restore
#line 21 "C:\Users\diell\Desktop\Integradoras_5\Views\Animal\Delete.cshtml"
WriteAttributeValue("", 714, Model.Nascimento.ToString("dd/MM/yyyy"), 714, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                </div>\r\n                <div class=\"box-descricao\">\r\n                    <p>Sexo</p>\r\n                    <input readonly type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 909, "\"", 928, 1);
#nullable restore
#line 25 "C:\Users\diell\Desktop\Integradoras_5\Views\Animal\Delete.cshtml"
WriteAttributeValue("", 917, Model.Sexo, 917, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                </div>\r\n                <div class=\"box-descricao\">\r\n                    <p>Peso(KG)</p>\r\n                    <input readonly type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 1087, "\"", 1106, 1);
#nullable restore
#line 29 "C:\Users\diell\Desktop\Integradoras_5\Views\Animal\Delete.cshtml"
WriteAttributeValue("", 1095, Model.Peso, 1095, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                </div>\r\n                <div class=\"box-descricao\">\r\n                    <p>Tipo de pelo</p>\r\n                    <input readonly type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 1269, "\"", 1295, 1);
#nullable restore
#line 33 "C:\Users\diell\Desktop\Integradoras_5\Views\Animal\Delete.cshtml"
WriteAttributeValue("", 1277, Model.TipoPelagem, 1277, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                </div>\r\n                <div class=\"box-descricao\">\r\n                    <p>Porte</p>\r\n                    <input readonly type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 1451, "\"", 1471, 1);
#nullable restore
#line 37 "C:\Users\diell\Desktop\Integradoras_5\Views\Animal\Delete.cshtml"
WriteAttributeValue("", 1459, Model.Porte, 1459, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                </div>\r\n                <div class=\"box-descricao\">\r\n                    <p>Temperamento</p>\r\n                    <input readonly type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 1634, "\"", 1661, 1);
#nullable restore
#line 41 "C:\Users\diell\Desktop\Integradoras_5\Views\Animal\Delete.cshtml"
WriteAttributeValue("", 1642, Model.Temperamento, 1642, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                </div>\r\n                <div class=\"box-descricao\">\r\n                    <p>Gosta de Brincar?</p>\r\n");
#nullable restore
#line 45 "C:\Users\diell\Desktop\Integradoras_5\Views\Animal\Delete.cshtml"
                     if (Model.GostaBrincar.ToString() == "True")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <input readonly type=\"text\" value=\"Sim\" />\r\n");
#nullable restore
#line 48 "C:\Users\diell\Desktop\Integradoras_5\Views\Animal\Delete.cshtml"
                    }
                    else if (Model.RelacionaOutroCao.ToString() == "False")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <input readonly type=\"text\" value=\"Não\" />");
#nullable restore
#line 50 "C:\Users\diell\Desktop\Integradoras_5\Views\Animal\Delete.cshtml"
                                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n                <div class=\"box-descricao\">\r\n                    <p>Pode conviver com outro cão?</p>\r\n");
#nullable restore
#line 54 "C:\Users\diell\Desktop\Integradoras_5\Views\Animal\Delete.cshtml"
                     if (Model.RelacionaGato.ToString() == "True")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <input readonly type=\"text\" value=\"Sim\" />\r\n");
#nullable restore
#line 57 "C:\Users\diell\Desktop\Integradoras_5\Views\Animal\Delete.cshtml"
                    }
                    else if (Model.RelacionaGato.ToString() == "False")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <input readonly type=\"text\" value=\"Não\" />");
#nullable restore
#line 59 "C:\Users\diell\Desktop\Integradoras_5\Views\Animal\Delete.cshtml"
                                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n                <div class=\"box-descricao\">\r\n                    <p>Pode conviver com gato?</p>\r\n");
#nullable restore
#line 63 "C:\Users\diell\Desktop\Integradoras_5\Views\Animal\Delete.cshtml"
                     if (Model.RelacionaGato.ToString() == "True")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <input readonly type=\"text\" value=\"Sim\" />\r\n");
#nullable restore
#line 66 "C:\Users\diell\Desktop\Integradoras_5\Views\Animal\Delete.cshtml"
                    }
                    else if (Model.RelacionaGato.ToString() == "False")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <input readonly type=\"text\" value=\"Não\" />");
#nullable restore
#line 68 "C:\Users\diell\Desktop\Integradoras_5\Views\Animal\Delete.cshtml"
                                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n                <div class=\"box-descricao\">\r\n                    <p>Possui deficiencia?</p>\r\n");
#nullable restore
#line 72 "C:\Users\diell\Desktop\Integradoras_5\Views\Animal\Delete.cshtml"
                     if (Model.PossuiDeficiencia.ToString() == "True")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <input readonly type=\"text\" value=\"Sim\" />\r\n");
#nullable restore
#line 75 "C:\Users\diell\Desktop\Integradoras_5\Views\Animal\Delete.cshtml"
                    }
                    else if (Model.PossuiDeficiencia.ToString() == "False")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <input readonly type=\"text\" value=\"Não\" />");
#nullable restore
#line 77 "C:\Users\diell\Desktop\Integradoras_5\Views\Animal\Delete.cshtml"
                                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n                <div class=\"box-descricao\">\r\n                    <p>Histórico</p>\r\n                    <input readonly type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 3599, "\"", 3627, 1);
#nullable restore
#line 81 "C:\Users\diell\Desktop\Integradoras_5\Views\Animal\Delete.cshtml"
WriteAttributeValue("", 3607, Model.HistoricoVida, 3607, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d9e4b2a3ee470d88c9a1991eb8ebf15a00ec5e3e14416", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d9e4b2a3ee470d88c9a1991eb8ebf15a00ec5e3e14683", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 87 "C:\Users\diell\Desktop\Integradoras_5\Views\Animal\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.AnimalID);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <button type=\"submit\">Deletar</button>\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d9e4b2a3ee470d88c9a1991eb8ebf15a00ec5e3e16432", async() => {
                    WriteLiteral("Voltar");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</section>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CaoLendario.Models.Animal> Html { get; private set; }
    }
}
#pragma warning restore 1591
