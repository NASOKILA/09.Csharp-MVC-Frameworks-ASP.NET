#pragma checksum "C:\Users\Asus\SoftUni\9.C# Web\C# Web MVC Frameworks ASP.NET\18.Unit Testing\SoftUniClone.Web\Areas\Admin\Views\Courses\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23477d9275e64c565b078afb3c9021f9fed8f84d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SoftUniClone.Web.Areas.Admin.Courses.Areas_Admin_Views_Courses_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Courses/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Courses/Index.cshtml", typeof(SoftUniClone.Web.Areas.Admin.Courses.Areas_Admin_Views_Courses_Index))]
namespace SoftUniClone.Web.Areas.Admin.Courses
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Asus\SoftUni\9.C# Web\C# Web MVC Frameworks ASP.NET\18.Unit Testing\SoftUniClone.Web\Areas\Admin\Views\_ViewImports.cshtml"
using SoftUniClone.Models;

#line default
#line hidden
#line 2 "C:\Users\Asus\SoftUni\9.C# Web\C# Web MVC Frameworks ASP.NET\18.Unit Testing\SoftUniClone.Web\Areas\Admin\Views\_ViewImports.cshtml"
using SoftUniClone.Web.Helpers;

#line default
#line hidden
#line 3 "C:\Users\Asus\SoftUni\9.C# Web\C# Web MVC Frameworks ASP.NET\18.Unit Testing\SoftUniClone.Web\Areas\Admin\Views\_ViewImports.cshtml"
using SoftUniClone.Web.Helpers.Messages;

#line default
#line hidden
#line 4 "C:\Users\Asus\SoftUni\9.C# Web\C# Web MVC Frameworks ASP.NET\18.Unit Testing\SoftUniClone.Web\Areas\Admin\Views\_ViewImports.cshtml"
using SoftUniClone.Services.Admin;

#line default
#line hidden
#line 5 "C:\Users\Asus\SoftUni\9.C# Web\C# Web MVC Frameworks ASP.NET\18.Unit Testing\SoftUniClone.Web\Areas\Admin\Views\_ViewImports.cshtml"
using SoftUniClone.Common.Admin.BindingModels;

#line default
#line hidden
#line 6 "C:\Users\Asus\SoftUni\9.C# Web\C# Web MVC Frameworks ASP.NET\18.Unit Testing\SoftUniClone.Web\Areas\Admin\Views\_ViewImports.cshtml"
using SoftUniClone.Common.Admin.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23477d9275e64c565b078afb3c9021f9fed8f84d", @"/Areas/Admin/Views/Courses/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"299c73edc11a09cb6ebfc7ed0006662814a8393c", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Courses_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CourseConciseViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Courses", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Asus\SoftUni\9.C# Web\C# Web MVC Frameworks ASP.NET\18.Unit Testing\SoftUniClone.Web\Areas\Admin\Views\Courses\Index.cshtml"
  
    ViewData["Title"] = "All Courses";

#line default
#line hidden
            BeginContext(91, 24, true);
            WriteLiteral("\r\n<h2>All Courses</h2>\r\n");
            EndContext();
            BeginContext(115, 145, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "591719519a6447af812321d957be2751", async() => {
                BeginContext(204, 52, true);
                WriteLiteral("\r\n    <i class=\"fa fa-plus\"></i> Create new course\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(260, 12, true);
            WriteLiteral("\r\n<ul>\r\n    ");
            EndContext();
            BeginContext(273, 22, false);
#line 11 "C:\Users\Asus\SoftUni\9.C# Web\C# Web MVC Frameworks ASP.NET\18.Unit Testing\SoftUniClone.Web\Areas\Admin\Views\Courses\Index.cshtml"
Write(Html.DisplayForModel());

#line default
#line hidden
            EndContext();
            BeginContext(295, 7, true);
            WriteLiteral("\r\n</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CourseConciseViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591