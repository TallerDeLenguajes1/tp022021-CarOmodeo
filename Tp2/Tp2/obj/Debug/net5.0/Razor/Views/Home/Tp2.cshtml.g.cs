#pragma checksum "C:\Users\Caro\source\repos\tp022021-CarOmodeo\Tp2\Tp2\Views\Home\Tp2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "56a9bea7eb23b73f34b170012b1946200b62dc3b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Tp2), @"mvc.1.0.view", @"/Views/Home/Tp2.cshtml")]
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
#line 1 "C:\Users\Caro\source\repos\tp022021-CarOmodeo\Tp2\Tp2\Views\_ViewImports.cshtml"
using Tp2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Caro\source\repos\tp022021-CarOmodeo\Tp2\Tp2\Views\_ViewImports.cshtml"
using Tp2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56a9bea7eb23b73f34b170012b1946200b62dc3b", @"/Views/Home/Tp2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df9b11fd71c441359d1c2edd9d589ddf71cda76b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Tp2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h2> Datos del Empleado</h2>\r\n");
#nullable restore
#line 8 "C:\Users\Caro\source\repos\tp022021-CarOmodeo\Tp2\Tp2\Views\Home\Tp2.cshtml"
 if (ViewBag.empleado != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p class=\"fw-bold\">Apellido:</p> <p>");
#nullable restore
#line 10 "C:\Users\Caro\source\repos\tp022021-CarOmodeo\Tp2\Tp2\Views\Home\Tp2.cshtml"
                                   Write(ViewBag.empleado.Apellido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Nombre: ");
#nullable restore
#line 11 "C:\Users\Caro\source\repos\tp022021-CarOmodeo\Tp2\Tp2\Views\Home\Tp2.cshtml"
          Write(ViewBag.empleado.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Fecha de Nacimiento: ");
#nullable restore
#line 12 "C:\Users\Caro\source\repos\tp022021-CarOmodeo\Tp2\Tp2\Views\Home\Tp2.cshtml"
                       Write(ViewBag.empleado.FechaNacimiento.ToString("d"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Edad: ");
#nullable restore
#line 13 "C:\Users\Caro\source\repos\tp022021-CarOmodeo\Tp2\Tp2\Views\Home\Tp2.cshtml"
        Write(ViewBag.empleado.Edad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Telefono: ");
#nullable restore
#line 14 "C:\Users\Caro\source\repos\tp022021-CarOmodeo\Tp2\Tp2\Views\Home\Tp2.cshtml"
            Write(ViewBag.empleado.Telefono);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Domicilio: ");
#nullable restore
#line 15 "C:\Users\Caro\source\repos\tp022021-CarOmodeo\Tp2\Tp2\Views\Home\Tp2.cshtml"
             Write(ViewBag.empleado.Domicilio);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Rol en la Empresa: ");
#nullable restore
#line 16 "C:\Users\Caro\source\repos\tp022021-CarOmodeo\Tp2\Tp2\Views\Home\Tp2.cshtml"
                     Write(ViewBag.empleado.Rol);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Fecha de Ingreso: ");
#nullable restore
#line 17 "C:\Users\Caro\source\repos\tp022021-CarOmodeo\Tp2\Tp2\Views\Home\Tp2.cshtml"
                    Write(ViewBag.empleado.FechaIngreso.ToString("d"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Antiguedad: ");
#nullable restore
#line 18 "C:\Users\Caro\source\repos\tp022021-CarOmodeo\Tp2\Tp2\Views\Home\Tp2.cshtml"
              Write(ViewBag.empleado.Antiguedad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Salario: $");
#nullable restore
#line 19 "C:\Users\Caro\source\repos\tp022021-CarOmodeo\Tp2\Tp2\Views\Home\Tp2.cshtml"
            Write(ViewBag.empleado.Salario);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 20 "C:\Users\Caro\source\repos\tp022021-CarOmodeo\Tp2\Tp2\Views\Home\Tp2.cshtml"
} 
else 
{ 

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>");
#nullable restore
#line 23 "C:\Users\Caro\source\repos\tp022021-CarOmodeo\Tp2\Tp2\Views\Home\Tp2.cshtml"
  Write(ViewBag.mensaje);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>        \r\n");
#nullable restore
#line 24 "C:\Users\Caro\source\repos\tp022021-CarOmodeo\Tp2\Tp2\Views\Home\Tp2.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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