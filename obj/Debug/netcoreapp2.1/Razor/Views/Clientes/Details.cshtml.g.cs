#pragma checksum "C:\Users\jl_gu\Downloads\aaaaa\StudentRecordManagementSystem\StudentRecordManagementSystem\Views\Clientes\Details.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "fe1cc2b6bc751d51ff857e7d91cc7ab44e169573dd1c63b929f5a94797500633"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clientes_Details), @"mvc.1.0.view", @"/Views/Clientes/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Clientes/Details.cshtml", typeof(AspNetCore.Views_Clientes_Details))]
namespace AspNetCore
{
    #line default
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\jl_gu\Downloads\aaaaa\StudentRecordManagementSystem\StudentRecordManagementSystem\Views\_ViewImports.cshtml"
using TareasRecordManagementSystem

    ;
#line 2 "C:\Users\jl_gu\Downloads\aaaaa\StudentRecordManagementSystem\StudentRecordManagementSystem\Views\_ViewImports.cshtml"
using TareasRecordManagementSystem.Models

#line default
#line hidden
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"fe1cc2b6bc751d51ff857e7d91cc7ab44e169573dd1c63b929f5a94797500633", @"/Views/Clientes/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"067c769114cdbecc8ba3d7861280688da0edc34c1ecb92c3109304d50b26f406", @"/Views/_ViewImports.cshtml")]
    public class Views_Clientes_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TareasRecordManagementSystem.Models.Personal>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(53, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\jl_gu\Downloads\aaaaa\StudentRecordManagementSystem\StudentRecordManagementSystem\Views\Clientes\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden

            BeginContext(98, 121, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Student</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(220, 38, false);
            Write(
#line 14 "C:\Users\jl_gu\Downloads\aaaaa\StudentRecordManagementSystem\StudentRecordManagementSystem\Views\Clientes\Details.cshtml"
             Html.DisplayNameFor(model => model.Id)

#line default
#line hidden
            );
            EndContext();
            BeginContext(258, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(302, 34, false);
            Write(
#line 17 "C:\Users\jl_gu\Downloads\aaaaa\StudentRecordManagementSystem\StudentRecordManagementSystem\Views\Clientes\Details.cshtml"
             Html.DisplayFor(model => model.Id)

#line default
#line hidden
            );
            EndContext();
            BeginContext(336, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(380, 45, false);
            Write(
#line 20 "C:\Users\jl_gu\Downloads\aaaaa\StudentRecordManagementSystem\StudentRecordManagementSystem\Views\Clientes\Details.cshtml"
             Html.DisplayNameFor(model => model.FirstName)

#line default
#line hidden
            );
            EndContext();
            BeginContext(425, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(469, 41, false);
            Write(
#line 23 "C:\Users\jl_gu\Downloads\aaaaa\StudentRecordManagementSystem\StudentRecordManagementSystem\Views\Clientes\Details.cshtml"
             Html.DisplayFor(model => model.FirstName)

#line default
#line hidden
            );
            EndContext();
            BeginContext(510, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(554, 45, false);
            Write(
#line 26 "C:\Users\jl_gu\Downloads\aaaaa\StudentRecordManagementSystem\StudentRecordManagementSystem\Views\Clientes\Details.cshtml"
             Html.DisplayNameFor(model => model.ApPaterno)

#line default
#line hidden
            );
            EndContext();
            BeginContext(599, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(643, 41, false);
            Write(
#line 29 "C:\Users\jl_gu\Downloads\aaaaa\StudentRecordManagementSystem\StudentRecordManagementSystem\Views\Clientes\Details.cshtml"
             Html.DisplayFor(model => model.ApMaterno)

#line default
#line hidden
            );
            EndContext();
            BeginContext(684, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(728, 44, false);
            Write(
#line 32 "C:\Users\jl_gu\Downloads\aaaaa\StudentRecordManagementSystem\StudentRecordManagementSystem\Views\Clientes\Details.cshtml"
             Html.DisplayNameFor(model => model.FechaNac)

#line default
#line hidden
            );
            EndContext();
            BeginContext(772, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(816, 43, false);
            Write(
#line 35 "C:\Users\jl_gu\Downloads\aaaaa\StudentRecordManagementSystem\StudentRecordManagementSystem\Views\Clientes\Details.cshtml"
             Html.DisplayNameFor(model => model.Address)

#line default
#line hidden
            );
            EndContext();
            BeginContext(859, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(903, 41, false);
            Write(
#line 38 "C:\Users\jl_gu\Downloads\aaaaa\StudentRecordManagementSystem\StudentRecordManagementSystem\Views\Clientes\Details.cshtml"
             Html.DisplayFor(model => model.NumeroDoc)

#line default
#line hidden
            );
            EndContext();
            BeginContext(944, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(992, 56, false);
            Write(
#line 43 "C:\Users\jl_gu\Downloads\aaaaa\StudentRecordManagementSystem\StudentRecordManagementSystem\Views\Clientes\Details.cshtml"
     Html.ActionLink("Edit", "Edit", new {  id = Model.Id  })

#line default
#line hidden
            );
            EndContext();
            BeginContext(1048, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1056, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe1cc2b6bc751d51ff857e7d91cc7ab44e169573dd1c63b929f5a947975006339003", async() => {
                BeginContext(1078, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1094, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TareasRecordManagementSystem.Models.Personal> Html { get; private set; }
    }
}
#pragma warning restore 1591