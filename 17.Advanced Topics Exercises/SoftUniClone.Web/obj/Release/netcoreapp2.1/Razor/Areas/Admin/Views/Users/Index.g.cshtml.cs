#pragma checksum "C:\Users\Yordan\Desktop\C# MVC Frameworks\SoftUniClone\SoftUniClone.Web\Areas\Admin\Views\Users\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2299af723f56c21736b9267e5e9322ab4c4ba98b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SoftUniClone.Web.Areas.Admin.Users.Areas_Admin_Views_Users_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Users/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Users/Index.cshtml", typeof(SoftUniClone.Web.Areas.Admin.Users.Areas_Admin_Views_Users_Index))]
namespace SoftUniClone.Web.Areas.Admin.Users
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Yordan\Desktop\C# MVC Frameworks\SoftUniClone\SoftUniClone.Web\Areas\Admin\Views\_ViewImports.cshtml"
using SoftUniClone.Models;

#line default
#line hidden
#line 2 "C:\Users\Yordan\Desktop\C# MVC Frameworks\SoftUniClone\SoftUniClone.Web\Areas\Admin\Views\_ViewImports.cshtml"
using SoftUniClone.Web.Areas.Admin.Models.BindingModels;

#line default
#line hidden
#line 3 "C:\Users\Yordan\Desktop\C# MVC Frameworks\SoftUniClone\SoftUniClone.Web\Areas\Admin\Views\_ViewImports.cshtml"
using SoftUniClone.Web.Areas.Admin.Models.ViewModels;

#line default
#line hidden
#line 4 "C:\Users\Yordan\Desktop\C# MVC Frameworks\SoftUniClone\SoftUniClone.Web\Areas\Admin\Views\_ViewImports.cshtml"
using SoftUniClone.Web.Helpers;

#line default
#line hidden
#line 5 "C:\Users\Yordan\Desktop\C# MVC Frameworks\SoftUniClone\SoftUniClone.Web\Areas\Admin\Views\_ViewImports.cshtml"
using SoftUniClone.Web.Helpers.Messages;

#line default
#line hidden
#line 6 "C:\Users\Yordan\Desktop\C# MVC Frameworks\SoftUniClone\SoftUniClone.Web\Areas\Admin\Views\_ViewImports.cshtml"
using SoftUniClone.Services.Admin;

#line default
#line hidden
#line 7 "C:\Users\Yordan\Desktop\C# MVC Frameworks\SoftUniClone\SoftUniClone.Web\Areas\Admin\Views\_ViewImports.cshtml"
using SoftUniClone.Common.Admin.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2299af723f56c21736b9267e5e9322ab4c4ba98b", @"/Areas/Admin/Views/Users/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69f7b22d4f528f6869e85e717720bf691c904fc5", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Users_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<UserConciseViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Yordan\Desktop\C# MVC Frameworks\SoftUniClone\SoftUniClone.Web\Areas\Admin\Views\Users\Index.cshtml"
  
    ViewData["Title"] = "All Users";

#line default
#line hidden
            BeginContext(87, 286, true);
            WriteLiteral(@"
<h2>All Users</h2>
<table class=""table table-striped"">
    <thead>
        <tr>
            <th>Username</th>
            <th>Email</th>
            <th>Lecturer?</th>
            <th>Admin?</th>
            <th>Actions</th>
        </tr>
    </thead>
    <tbody>
        ");
            EndContext();
            BeginContext(374, 22, false);
#line 18 "C:\Users\Yordan\Desktop\C# MVC Frameworks\SoftUniClone\SoftUniClone.Web\Areas\Admin\Views\Users\Index.cshtml"
   Write(Html.DisplayForModel());

#line default
#line hidden
            EndContext();
            BeginContext(396, 24, true);
            WriteLiteral("\r\n    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<UserConciseViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591