#pragma checksum "C:\Users\Asus\SoftUni\9.C# Web\C# Web MVC Frameworks ASP.NET\04.Basics And Razor Pages Exercises\BookLibrary.Web\Views\Movies\Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14fafe0800db186f6da38db9e39a2a7a54d1a804"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies_Add), @"mvc.1.0.view", @"/Views/Movies/Add.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Movies/Add.cshtml", typeof(AspNetCore.Views_Movies_Add))]
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
#line 1 "C:\Users\Asus\SoftUni\9.C# Web\C# Web MVC Frameworks ASP.NET\04.Basics And Razor Pages Exercises\BookLibrary.Web\Views\Movies\Add.cshtml"
using BookLibrary.Web.BindingModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14fafe0800db186f6da38db9e39a2a7a54d1a804", @"/Views/Movies/Add.cshtml")]
    public class Views_Movies_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MovieBindingModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery-validation/dist/jquery.validate.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery-validation-unobtrusive/jquery.validate.unobtrusive.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Asus\SoftUni\9.C# Web\C# Web MVC Frameworks ASP.NET\04.Basics And Razor Pages Exercises\BookLibrary.Web\Views\Movies\Add.cshtml"
  
    Layout = "_Layout";
    ViewData["Title"] = "Add";

#line default
#line hidden
            BeginContext(128, 51, true);
            WriteLiteral("\r\n\r\n  <environment include=\"Development\">\r\n        ");
            EndContext();
            BeginContext(179, 71, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c02d9051f87745ae9d6576c9bab6e462", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(250, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(260, 90, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ab5e922560d42f6a227c51baa82aaca", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(350, 2718, true);
            WriteLiteral(@"
    </environment>
    <environment exclude=""Development"">
        <script src=""https://ajax.aspnetcdn.com/ajax/jquery.validate/1.17.0/jquery.validate.min.js""
                asp-fallback-src=""~/lib/jquery-validation/dist/jquery.validate.min.js""
                asp-fallback-test=""window.jQuery && window.jQuery.validator""
                crossorigin=""anonymous""
                integrity=""sha384-rZfj/ogBloos6wzLGpPkkOr/gpkBNLZ6b6yLy4o+ok+t/SAKlL5mvXLr0OXNi1Hp"">
        </script>
        <script src=""https://ajax.aspnetcdn.com/ajax/jquery.validation.unobtrusive/3.2.9/jquery.validate.unobtrusive.min.js""
                asp-fallback-src=""~/lib/jquery-validation-unobtrusive/jquery.validate.unobtrusive.min.js""
                asp-fallback-test=""window.jQuery && window.jQuery.validator && window.jQuery.validator.unobtrusive""
                crossorigin=""anonymous""
                integrity=""sha384-ifv0TYDWxBHzvAk2Z0n8R434FL1Rlv/Av18DXE43N/1rvHyOG4izKst0f2iSLdds"">
        </script>
    </environment>
");
            WriteLiteral(@"
<h2>Add Movie</h2>

<br />
<form method=""post"" asp-controller=""Movies"" asp-action=""Add"">

    <div class=""form-group row"">
        <label asp-for=""Title"">Title</label>
        <div class=""col-sm-10"">
            <input asp-for=""Title"" name=""title"" class=""form-control custom-input"" placeholder=""Title"">
            <span asp-validation-for=""Title"" class=""text-danger""></span>
        </div>
    </div>
    <div class=""form-group row"">
        <label asp-for=""Director"">Director</label>
        <div class=""col-sm-10"">
            <input asp-for=""Author"" name=""director"" type=""text"" class=""form-control custom-input"" placeholder=""Direcror"">
            <span asp-validation-for=""Director"" class=""text-danger""></span>
        </div>
    </div>
    <div class=""form-group row"">
        <label asp-for=""ImageUrl"">Image Url</label>
        <div class=""col-sm-10"">
            <input asp-for=""ImageUrl"" name=""imageUrl"" type=""url"" class=""form-control custom-input"" placeholder=""ImageUrl"">
            <span");
            WriteLiteral(@" asp-validation-for=""ImageUrl"" class=""text-danger""></span>
        </div>
    </div>
    <div class=""form-group row"">
        <label asp-for=""Description"">Description</label>
        <div class=""col-sm-10"">
            <textarea asp-for=""Description"" name=""description"" class=""form-control custom-input"" placeholder=""Description""></textarea>
            <span asp-validation-for=""Description"" class=""text-danger""></span>
        </div>
    </div>
    <br />
    <div class=""btns"">
        <button type=""submit"" class=""btn btn-success"">Add movie</button>
        <a class=""btn btn-outline-success"" href=""/Movies/All"">Cancel</a>
    </div>

</form>



");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MovieBindingModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
