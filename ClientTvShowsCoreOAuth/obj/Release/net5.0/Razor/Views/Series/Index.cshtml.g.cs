#pragma checksum "D:\APIs\ApiTvShowsClient\ClientTvShowsCoreOAuth\Views\Series\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d38e11e2444bc49f54a02276523053976759421"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Series_Index), @"mvc.1.0.view", @"/Views/Series/Index.cshtml")]
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
#line 1 "D:\APIs\ApiTvShowsClient\ClientTvShowsCoreOAuth\Views\_ViewImports.cshtml"
using ClientTvShowsCoreOAuth;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\APIs\ApiTvShowsClient\ClientTvShowsCoreOAuth\Views\Series\Index.cshtml"
using ClientTvShowsCoreOAuth.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d38e11e2444bc49f54a02276523053976759421", @"/Views/Series/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b7ed4a024d2725f7210522ae7ff1d2480ff1b1c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Series_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Serie>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Series", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Personajes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "BySerie", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info rounded-pill"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\APIs\ApiTvShowsClient\ClientTvShowsCoreOAuth\Views\Series\Index.cshtml"
  
    ViewData["Title"] = "Series";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<nav aria-label=\"breadcrumb\">\r\n  <ol class=\"breadcrumb\">\r\n    <li class=\"breadcrumb-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4d38e11e2444bc49f54a022765230539767594215606", async() => {
                WriteLiteral("Inicio");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</li>
    <li class=""breadcrumb-item active"" aria-current=""page"">Series</li>
  </ol>
</nav>

<h2 class=""mb-4"">Series</h2>

<table class=""table table-responsive-sm align-middle"">
    <thead>
        <tr class=""table-dark text-center"">
            <th scope=""col""></th>
            <th scope=""col"">Imagen</th>
            <th scope=""col"" colspan=""2"">Información</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 25 "D:\APIs\ApiTvShowsClient\ClientTvShowsCoreOAuth\Views\Series\Index.cshtml"
       var counter = 0; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "D:\APIs\ApiTvShowsClient\ClientTvShowsCoreOAuth\Views\Series\Index.cshtml"
     foreach (Serie serie in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr class=\"text-center\">\r\n            <th scope=\"row\" class=\"col-sm-1\" rowspan=\"3\">");
#nullable restore
#line 28 "D:\APIs\ApiTvShowsClient\ClientTvShowsCoreOAuth\Views\Series\Index.cshtml"
                                                     Write(++counter);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <td class=\"col-sm-5 px-0 align-middle\" rowspan=\"3\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 931, "\"", 950, 1);
#nullable restore
#line 30 "D:\APIs\ApiTvShowsClient\ClientTvShowsCoreOAuth\Views\Series\Index.cshtml"
WriteAttributeValue("", 937, serie.Imagen, 937, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 951, "\"", 978, 3);
            WriteAttributeValue("", 957, "Foto", 957, 4, true);
            WriteAttributeValue(" ", 961, "de", 962, 3, true);
#nullable restore
#line 30 "D:\APIs\ApiTvShowsClient\ClientTvShowsCoreOAuth\Views\Series\Index.cshtml"
WriteAttributeValue(" ", 964, serie.Titulo, 965, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                    style=\"max-width:280px;width:100%;\" class=\"img-thumbnail img-fluid\">\r\n            </td>\r\n            <td class=\"col-sm-6 table-secondary border-bottom-0\" colspan=\"2\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4d38e11e2444bc49f54a022765230539767594219296", async() => {
                WriteLiteral("\r\n                    ");
#nullable restore
#line 36 "D:\APIs\ApiTvShowsClient\ClientTvShowsCoreOAuth\Views\Series\Index.cshtml"
               Write(serie.Titulo);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-idserie", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 35 "D:\APIs\ApiTvShowsClient\ClientTvShowsCoreOAuth\Views\Series\Index.cshtml"
                           WriteLiteral(serie.IdSerie);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idserie"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-idserie", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idserie"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr class=\"text-center table-secondary\">\r\n            <td class=\"col-sm-3\">\r\n                <input");
            BeginWriteAttribute("id", " id=\"", 1489, "\"", 1520, 2);
            WriteAttributeValue("", 1494, "input-stars-", 1494, 12, true);
#nullable restore
#line 42 "D:\APIs\ApiTvShowsClient\ClientTvShowsCoreOAuth\Views\Series\Index.cshtml"
WriteAttributeValue("", 1506, serie.IdSerie, 1506, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 1521, "\"", 1554, 2);
            WriteAttributeValue("", 1528, "input-stars-", 1528, 12, true);
#nullable restore
#line 42 "D:\APIs\ApiTvShowsClient\ClientTvShowsCoreOAuth\Views\Series\Index.cshtml"
WriteAttributeValue("", 1540, serie.IdSerie, 1540, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", "\r\n                    value=\"", 1555, "\"", 1605, 1);
#nullable restore
#line 43 "D:\APIs\ApiTvShowsClient\ClientTvShowsCoreOAuth\Views\Series\Index.cshtml"
WriteAttributeValue("", 1584, serie.Puntuacion/2, 1584, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"rating-loading\">\r\n            </td>\r\n            <td class=\"col-sm-3\"><strong>Año estreno:</strong> ");
#nullable restore
#line 45 "D:\APIs\ApiTvShowsClient\ClientTvShowsCoreOAuth\Views\Series\Index.cshtml"
                                                          Write(serie.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr class=\"text-center\">\r\n            <td class=\"col-sm-6\" colspan=\"2\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4d38e11e2444bc49f54a0227652305397675942113783", async() => {
                WriteLiteral("\r\n                    Ver personajes\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-idserie", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 50 "D:\APIs\ApiTvShowsClient\ClientTvShowsCoreOAuth\Views\Series\Index.cshtml"
                           WriteLiteral(serie.IdSerie);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idserie"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-idserie", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idserie"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 55 "D:\APIs\ApiTvShowsClient\ClientTvShowsCoreOAuth\Views\Series\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        $(document).ready(function(){\r\n            $(\'.rating-loading\').rating({ displayOnly: true, step: 0.01, size: \'sm\', language: \'es\' });\r\n        });\r\n    </script>\r\n");
            }
            );
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Serie>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591