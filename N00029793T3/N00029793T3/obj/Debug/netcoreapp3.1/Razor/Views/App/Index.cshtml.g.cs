#pragma checksum "C:\Mistery\N00029793T3\N00029793T3\Views\App\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e1c251acd6c68c91f1524bd43abc67d543a89ffd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_App_Index), @"mvc.1.0.view", @"/Views/App/Index.cshtml")]
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
#line 1 "C:\Mistery\N00029793T3\N00029793T3\Views\_ViewImports.cshtml"
using N00029793T3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Mistery\N00029793T3\N00029793T3\Views\_ViewImports.cshtml"
using N00029793T3.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1c251acd6c68c91f1524bd43abc67d543a89ffd", @"/Views/App/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92cd238782ad744fefe77862997b44211e2b2e52", @"/Views/_ViewImports.cshtml")]
    public class Views_App_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<a href=""/app/crearR"">Crear rutina</a>
<br />
<label>
    Rutinas Creadas
</label>
<table class=""table table-striped"">
    <thead>
        <tr>
            <th scope=""col"">#</th>
            <th scope=""col"">Nombre</th>
            <th scope=""col""></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 15 "C:\Mistery\N00029793T3\N00029793T3\Views\App\Index.cshtml"
           int i = 0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Mistery\N00029793T3\N00029793T3\Views\App\Index.cshtml"
         foreach (var item in ViewBag.Rutinas)
        {
            if (item.Nivel == 0)
            {
                i++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <th scope=\"row\">");
#nullable restore
#line 22 "C:\Mistery\N00029793T3\N00029793T3\Views\App\Index.cshtml"
                               Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <td>");
#nullable restore
#line 23 "C:\Mistery\N00029793T3\N00029793T3\Views\App\Index.cshtml"
                   Write(item.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td><a");
            BeginWriteAttribute("href", " href=\"", 596, "\"", 628, 2);
            WriteAttributeValue("", 603, "/app/AsignarN?id=", 603, 17, true);
#nullable restore
#line 24 "C:\Mistery\N00029793T3\N00029793T3\Views\App\Index.cshtml"
WriteAttributeValue("", 620, item.Id, 620, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Asignar Nivel</a></td>\r\n                </tr>\r\n");
#nullable restore
#line 26 "C:\Mistery\N00029793T3\N00029793T3\Views\App\Index.cshtml"
            }

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n<br />\r\n<label>\r\n    Rutinas  de ");
#nullable restore
#line 33 "C:\Mistery\N00029793T3\N00029793T3\Views\App\Index.cshtml"
           Write(User.Claims.FirstOrDefault().Value);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
</label>
<table class=""table table-info"">
    <thead>
        <tr>
            <th scope=""col"">#</th>
            <th scope=""col"">Nombre</th>
            <th scope=""col"">Nivel</th>
            <th scope=""col""></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 45 "C:\Mistery\N00029793T3\N00029793T3\Views\App\Index.cshtml"
           int inc = 0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Mistery\N00029793T3\N00029793T3\Views\App\Index.cshtml"
         foreach (var item in ViewBag.Rutinas)
        {
            if (item.Nivel != 0)
            {
                inc++;

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <th scope=\"row\">");
#nullable restore
#line 52 "C:\Mistery\N00029793T3\N00029793T3\Views\App\Index.cshtml"
                       Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <td>");
#nullable restore
#line 53 "C:\Mistery\N00029793T3\N00029793T3\Views\App\Index.cshtml"
           Write(item.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 54 "C:\Mistery\N00029793T3\N00029793T3\Views\App\Index.cshtml"
           Write(item.Nivel);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 1360, "\"", 1394, 2);
            WriteAttributeValue("", 1367, "/app/ejercicioL?id=", 1367, 19, true);
#nullable restore
#line 55 "C:\Mistery\N00029793T3\N00029793T3\Views\App\Index.cshtml"
WriteAttributeValue("", 1386, item.Id, 1386, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Ver</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 57 "C:\Mistery\N00029793T3\N00029793T3\Views\App\Index.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
