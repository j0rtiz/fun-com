#pragma checksum "C:\Dev\fun-com\Views\produto\Update.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14d5bb3385158dcd2870328feee87aff3c3fd43b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_produto_Update), @"mvc.1.0.view", @"/Views/produto/Update.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/produto/Update.cshtml", typeof(AspNetCore.Views_produto_Update))]
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
#line 1 "C:\Dev\fun-com\Views\_ViewImports.cshtml"
using fun_com;

#line default
#line hidden
#line 2 "C:\Dev\fun-com\Views\_ViewImports.cshtml"
using fun_com.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14d5bb3385158dcd2870328feee87aff3c3fd43b", @"/Views/produto/Update.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c038c370c853bf23840d64eefff98a6678891498", @"/Views/_ViewImports.cshtml")]
    public class Views_produto_Update : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<fun_com.Models.Produto>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(31, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Dev\fun-com\Views\produto\Update.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(68, 23, false);
#line 5 "C:\Dev\fun-com\Views\produto\Update.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(95, 97, true);
            WriteLiteral("    <div class=\"form-row mx-auto\" style=\"width: 40%;\">\r\n        <h3>Editar Produto</h3>\r\n        ");
            EndContext();
            BeginContext(193, 64, false);
#line 9 "C:\Dev\fun-com\Views\produto\Update.cshtml"
   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(257, 63, true);
            WriteLiteral("\r\n        <div class=\"form-group col-md-12 pt-4\">\r\n            ");
            EndContext();
            BeginContext(321, 34, false);
#line 11 "C:\Dev\fun-com\Views\produto\Update.cshtml"
       Write(Html.LabelFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(355, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(370, 93, false);
#line 12 "C:\Dev\fun-com\Views\produto\Update.cshtml"
       Write(Html.EditorFor(model => model.Nome, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(463, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(478, 82, false);
#line 13 "C:\Dev\fun-com\Views\produto\Update.cshtml"
       Write(Html.ValidationMessageFor(model => model.Nome, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(560, 76, true);
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"form-group col-md-12\">\r\n            ");
            EndContext();
            BeginContext(637, 34, false);
#line 17 "C:\Dev\fun-com\Views\produto\Update.cshtml"
       Write(Html.LabelFor(model => model.Tipo));

#line default
#line hidden
            EndContext();
            BeginContext(671, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(686, 93, false);
#line 18 "C:\Dev\fun-com\Views\produto\Update.cshtml"
       Write(Html.EditorFor(model => model.Tipo, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(779, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(794, 82, false);
#line 19 "C:\Dev\fun-com\Views\produto\Update.cshtml"
       Write(Html.ValidationMessageFor(model => model.Tipo, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(876, 76, true);
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"form-group col-md-12\">\r\n            ");
            EndContext();
            BeginContext(953, 35, false);
#line 23 "C:\Dev\fun-com\Views\produto\Update.cshtml"
       Write(Html.LabelFor(model => model.Local));

#line default
#line hidden
            EndContext();
            BeginContext(988, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(1003, 94, false);
#line 24 "C:\Dev\fun-com\Views\produto\Update.cshtml"
       Write(Html.EditorFor(model => model.Local, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1097, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(1112, 83, false);
#line 25 "C:\Dev\fun-com\Views\produto\Update.cshtml"
       Write(Html.ValidationMessageFor(model => model.Local, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1195, 76, true);
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"form-group col-md-12\">\r\n            ");
            EndContext();
            BeginContext(1272, 35, false);
#line 29 "C:\Dev\fun-com\Views\produto\Update.cshtml"
       Write(Html.LabelFor(model => model.Valor));

#line default
#line hidden
            EndContext();
            BeginContext(1307, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(1322, 94, false);
#line 30 "C:\Dev\fun-com\Views\produto\Update.cshtml"
       Write(Html.EditorFor(model => model.Valor, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1416, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(1431, 83, false);
#line 31 "C:\Dev\fun-com\Views\produto\Update.cshtml"
       Write(Html.ValidationMessageFor(model => model.Valor, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1514, 180, true);
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"form-group col-md-12 pt-3\">\r\n            <input type=\"submit\" value=\"Salvar\" class=\"btn btn-dark btn-block\" />\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 38 "C:\Dev\fun-com\Views\produto\Update.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<fun_com.Models.Produto> Html { get; private set; }
    }
}
#pragma warning restore 1591
