#pragma checksum "/media/files/Usuarios/Vinicius Dantas/Documentos/Repositorio Github/C#/GPC/Views/Jogador/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6071052a9e4da3da4b8bd13c906798ad7184fb6d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Jogador_Index), @"mvc.1.0.view", @"/Views/Jogador/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Jogador/Index.cshtml", typeof(AspNetCore.Views_Jogador_Index))]
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
#line 1 "/media/files/Usuarios/Vinicius Dantas/Documentos/Repositorio Github/C#/GPC/Views/_ViewImports.cshtml"
using GPC;

#line default
#line hidden
#line 2 "/media/files/Usuarios/Vinicius Dantas/Documentos/Repositorio Github/C#/GPC/Views/_ViewImports.cshtml"
using GPC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6071052a9e4da3da4b8bd13c906798ad7184fb6d", @"/Views/Jogador/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f43ed33b984320f62513ef635de632ebe67bf944", @"/Views/_ViewImports.cshtml")]
    public class Views_Jogador_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<GPC.Models.Jogador>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "../Shared/_StatusMessage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("float: right;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Editar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(40, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "/media/files/Usuarios/Vinicius Dantas/Documentos/Repositorio Github/C#/GPC/Views/Jogador/Index.cshtml"
  
    ViewData["Title"] = "Jogadores(as)";

#line default
#line hidden
            BeginContext(91, 434, true);
            WriteLiteral(@"<style>
    .btn-success.pers{
        padding-right: 10px;
        padding-left: 10px;
        background: none;
        color: #18bc9c;
        border-radius: 20px;
        font-size: 14px;
        font-style: normal;
    }
    tr th{
        text-align: center;
    }
    .table > tbody > tr > td{
        vertical-align: middle;
        word-break: break-all;
    }
</style>
<br />
<h2 style=""display: inline;"">");
            EndContext();
            BeginContext(527, 17, false);
#line 25 "/media/files/Usuarios/Vinicius Dantas/Documentos/Repositorio Github/C#/GPC/Views/Jogador/Index.cshtml"
                         Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(545, 7, true);
            WriteLiteral("</h2>\r\n");
            EndContext();
            BeginContext(552, 43, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6071052a9e4da3da4b8bd13c906798ad7184fb6d5688", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(595, 113, true);
            WriteLiteral("\r\n<div style=\"display: inline; float: right;\" class=\"form-group text-right\">\r\n    <button class=\"btn btn-success\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 708, "\"", 758, 3);
            WriteAttributeValue("", 718, "location.href=\'", 718, 15, true);
#line 28 "/media/files/Usuarios/Vinicius Dantas/Documentos/Repositorio Github/C#/GPC/Views/Jogador/Index.cshtml"
WriteAttributeValue("", 733, Url.Action("Cadastro"), 733, 23, false);

#line default
#line hidden
            WriteAttributeValue("", 756, "\';", 756, 2, true);
            EndWriteAttribute();
            BeginContext(759, 409, true);
            WriteLiteral(@">Cadastrar jogador(a)</button>
</div>

<div style=""border-radius: 10px; overflow: hidden; border: 1px solid #2c3e50; display: inline-table; width: 100%; text-align: center;"">
    <table class=""table table-striped table-hover"" style=""text-align: center; table-layout: fixed;"">
        <thead class=""bg-primary"">
            <tr>
                <th scope=""col"" style=""width: 30%;"">
                    ");
            EndContext();
            BeginContext(1169, 50, false);
#line 36 "/media/files/Usuarios/Vinicius Dantas/Documentos/Repositorio Github/C#/GPC/Views/Jogador/Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Nome).ToUpper());

#line default
#line hidden
            EndContext();
            BeginContext(1219, 98, true);
            WriteLiteral("\r\n                </th>\r\n                <th scope=\"col\" style=\"width: 5%;\">\r\n                    ");
            EndContext();
            BeginContext(1318, 51, false);
#line 39 "/media/files/Usuarios/Vinicius Dantas/Documentos/Repositorio Github/C#/GPC/Views/Jogador/Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Idade).ToUpper());

#line default
#line hidden
            EndContext();
            BeginContext(1369, 99, true);
            WriteLiteral("\r\n                </th>\r\n                <th scope=\"col\" style=\"width: 30%;\">\r\n                    ");
            EndContext();
            BeginContext(1469, 59, false);
#line 42 "/media/files/Usuarios/Vinicius Dantas/Documentos/Repositorio Github/C#/GPC/Views/Jogador/Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Nacionalidade).ToUpper());

#line default
#line hidden
            EndContext();
            BeginContext(1528, 131, true);
            WriteLiteral("\r\n                </th>\r\n                <th style=\"width: 12%;\">AÇÕES</th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 48 "/media/files/Usuarios/Vinicius Dantas/Documentos/Repositorio Github/C#/GPC/Views/Jogador/Index.cshtml"
     foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1695, 72, true);
            WriteLiteral("            <tr>\r\n                <td scope=\"row\">\r\n                    ");
            EndContext();
            BeginContext(1768, 39, false);
#line 51 "/media/files/Usuarios/Vinicius Dantas/Documentos/Repositorio Github/C#/GPC/Views/Jogador/Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(1807, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1875, 40, false);
#line 54 "/media/files/Usuarios/Vinicius Dantas/Documentos/Repositorio Github/C#/GPC/Views/Jogador/Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Idade));

#line default
#line hidden
            EndContext();
            BeginContext(1915, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1983, 48, false);
#line 57 "/media/files/Usuarios/Vinicius Dantas/Documentos/Repositorio Github/C#/GPC/Views/Jogador/Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Nacionalidade));

#line default
#line hidden
            EndContext();
            BeginContext(2031, 122, true);
            WriteLiteral("\r\n                </td>\r\n                <td style=\"justify-content: space-between; display: flex;\">\r\n                    ");
            EndContext();
            BeginContext(2153, 139, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6071052a9e4da3da4b8bd13c906798ad7184fb6d11300", async() => {
                BeginContext(2222, 66, true);
                WriteLiteral("<i class=\"fas fa-user-edit fa-lg btn btn-success pers\"> Editar</i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 60 "/media/files/Usuarios/Vinicius Dantas/Documentos/Repositorio Github/C#/GPC/Views/Jogador/Index.cshtml"
                                                                   WriteLiteral(item.Id);

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
            BeginContext(2292, 23, true);
            WriteLiteral(" \r\n                    ");
            EndContext();
            BeginContext(2315, 141, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6071052a9e4da3da4b8bd13c906798ad7184fb6d13812", async() => {
                BeginContext(2384, 68, true);
                WriteLiteral("<i class=\"fas fa-user-minus fa-lg btn btn-success pers\"> Deletar</i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 61 "/media/files/Usuarios/Vinicius Dantas/Documentos/Repositorio Github/C#/GPC/Views/Jogador/Index.cshtml"
                                                                   WriteLiteral(item.Id);

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
            BeginContext(2456, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 64 "/media/files/Usuarios/Vinicius Dantas/Documentos/Repositorio Github/C#/GPC/Views/Jogador/Index.cshtml"
    }

#line default
#line hidden
            BeginContext(2507, 32, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
            EndContext();
#line 67 "/media/files/Usuarios/Vinicius Dantas/Documentos/Repositorio Github/C#/GPC/Views/Jogador/Index.cshtml"
     if(Model.Cast<object>().Any() == false){

#line default
#line hidden
            BeginContext(2586, 86, true);
            WriteLiteral("        <h4>Não foram encontrados(as) jogadores(as) cadastrados(as) no sistema.</h4>\r\n");
            EndContext();
#line 69 "/media/files/Usuarios/Vinicius Dantas/Documentos/Repositorio Github/C#/GPC/Views/Jogador/Index.cshtml"
    }

#line default
#line hidden
            BeginContext(2679, 8, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<GPC.Models.Jogador>> Html { get; private set; }
    }
}
#pragma warning restore 1591
