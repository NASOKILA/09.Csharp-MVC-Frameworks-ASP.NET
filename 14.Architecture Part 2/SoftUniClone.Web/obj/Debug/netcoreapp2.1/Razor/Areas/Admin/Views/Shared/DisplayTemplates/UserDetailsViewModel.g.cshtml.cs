#pragma checksum "C:\Users\Asus\SoftUni\9.C# Web\C# Web MVC Frameworks ASP.NET\14.Architecture Part 2\SoftUniClone.Web\Areas\Admin\Views\Shared\DisplayTemplates\UserDetailsViewModel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2d0460bcdc7b1c8d73a8771c7546b951515108c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SoftUniClone.Web.Areas.Admin.Shared.DisplayTemplates.Areas_Admin_Views_Shared_DisplayTemplates_UserDetailsViewModel), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/DisplayTemplates/UserDetailsViewModel.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Shared/DisplayTemplates/UserDetailsViewModel.cshtml", typeof(SoftUniClone.Web.Areas.Admin.Shared.DisplayTemplates.Areas_Admin_Views_Shared_DisplayTemplates_UserDetailsViewModel))]
namespace SoftUniClone.Web.Areas.Admin.Shared.DisplayTemplates
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Asus\SoftUni\9.C# Web\C# Web MVC Frameworks ASP.NET\14.Architecture Part 2\SoftUniClone.Web\Areas\Admin\Views\_ViewImports.cshtml"
using SoftUniClone.Models;

#line default
#line hidden
#line 2 "C:\Users\Asus\SoftUni\9.C# Web\C# Web MVC Frameworks ASP.NET\14.Architecture Part 2\SoftUniClone.Web\Areas\Admin\Views\_ViewImports.cshtml"
using SoftUniClone.Web.Areas.Admin.Models.BindingModels;

#line default
#line hidden
#line 3 "C:\Users\Asus\SoftUni\9.C# Web\C# Web MVC Frameworks ASP.NET\14.Architecture Part 2\SoftUniClone.Web\Areas\Admin\Views\_ViewImports.cshtml"
using SoftUniClone.Web.Areas.Admin.Models.ViewModels;

#line default
#line hidden
#line 4 "C:\Users\Asus\SoftUni\9.C# Web\C# Web MVC Frameworks ASP.NET\14.Architecture Part 2\SoftUniClone.Web\Areas\Admin\Views\_ViewImports.cshtml"
using SoftUniClone.Web.Helpers;

#line default
#line hidden
#line 5 "C:\Users\Asus\SoftUni\9.C# Web\C# Web MVC Frameworks ASP.NET\14.Architecture Part 2\SoftUniClone.Web\Areas\Admin\Views\_ViewImports.cshtml"
using SoftUniClone.Web.Helpers.Messages;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2d0460bcdc7b1c8d73a8771c7546b951515108c", @"/Areas/Admin/Views/Shared/DisplayTemplates/UserDetailsViewModel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2ed979692283e2c1c5076a7bc94c13df9a85cb3", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared_DisplayTemplates_UserDetailsViewModel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserDetailsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(29, 30, true);
            WriteLiteral("<p><strong>Username:</strong> ");
            EndContext();
            BeginContext(60, 14, false);
#line 2 "C:\Users\Asus\SoftUni\9.C# Web\C# Web MVC Frameworks ASP.NET\14.Architecture Part 2\SoftUniClone.Web\Areas\Admin\Views\Shared\DisplayTemplates\UserDetailsViewModel.cshtml"
                         Write(Model.Username);

#line default
#line hidden
            EndContext();
            BeginContext(74, 35, true);
            WriteLiteral("</p>\r\n<p><strong>Email:</strong> <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 109, "\"", 137, 2);
            WriteAttributeValue("", 116, "mailto://", 116, 9, true);
#line 3 "C:\Users\Asus\SoftUni\9.C# Web\C# Web MVC Frameworks ASP.NET\14.Architecture Part 2\SoftUniClone.Web\Areas\Admin\Views\Shared\DisplayTemplates\UserDetailsViewModel.cshtml"
WriteAttributeValue("", 125, Model.Email, 125, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(138, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(140, 11, false);
#line 3 "C:\Users\Asus\SoftUni\9.C# Web\C# Web MVC Frameworks ASP.NET\14.Architecture Part 2\SoftUniClone.Web\Areas\Admin\Views\Shared\DisplayTemplates\UserDetailsViewModel.cshtml"
                                                      Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(151, 41, true);
            WriteLiteral("</a></p>\r\n<p><strong>Full name:</strong> ");
            EndContext();
            BeginContext(193, 14, false);
#line 4 "C:\Users\Asus\SoftUni\9.C# Web\C# Web MVC Frameworks ASP.NET\14.Architecture Part 2\SoftUniClone.Web\Areas\Admin\Views\Shared\DisplayTemplates\UserDetailsViewModel.cshtml"
                          Write(Model.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(207, 76, true);
            WriteLiteral("</p>\r\n<p>\r\n    <strong>Roles:</strong>\r\n    <ul>\r\n        <li>Student</li>\r\n");
            EndContext();
#line 9 "C:\Users\Asus\SoftUni\9.C# Web\C# Web MVC Frameworks ASP.NET\14.Architecture Part 2\SoftUniClone.Web\Areas\Admin\Views\Shared\DisplayTemplates\UserDetailsViewModel.cshtml"
         if (Model.Roles.Any())
        {
            

#line default
#line hidden
#line 11 "C:\Users\Asus\SoftUni\9.C# Web\C# Web MVC Frameworks ASP.NET\14.Architecture Part 2\SoftUniClone.Web\Areas\Admin\Views\Shared\DisplayTemplates\UserDetailsViewModel.cshtml"
             foreach (string role in Model.Roles)
            {

#line default
#line hidden
            BeginContext(393, 20, true);
            WriteLiteral("                <li>");
            EndContext();
            BeginContext(414, 4, false);
#line 13 "C:\Users\Asus\SoftUni\9.C# Web\C# Web MVC Frameworks ASP.NET\14.Architecture Part 2\SoftUniClone.Web\Areas\Admin\Views\Shared\DisplayTemplates\UserDetailsViewModel.cshtml"
               Write(role);

#line default
#line hidden
            EndContext();
            BeginContext(418, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 14 "C:\Users\Asus\SoftUni\9.C# Web\C# Web MVC Frameworks ASP.NET\14.Architecture Part 2\SoftUniClone.Web\Areas\Admin\Views\Shared\DisplayTemplates\UserDetailsViewModel.cshtml"
            }

#line default
#line hidden
#line 14 "C:\Users\Asus\SoftUni\9.C# Web\C# Web MVC Frameworks ASP.NET\14.Architecture Part 2\SoftUniClone.Web\Areas\Admin\Views\Shared\DisplayTemplates\UserDetailsViewModel.cshtml"
             
        }

#line default
#line hidden
            BeginContext(451, 15, true);
            WriteLiteral("    </ul>\r\n</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591