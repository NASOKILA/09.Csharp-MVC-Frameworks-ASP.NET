#pragma checksum "C:\Users\Asus\SoftUni\9.C# Web\C# Web MVC Frameworks ASP.NET\04.Basics And Razor Pages Exercises\BookLibrary.Web\Pages\Books\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb25542fe5d6b4b0c3badd5938ac07b8985e9878"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(BookLibrary.Web.Pages.Books.Pages_Books_Details), @"mvc.1.0.razor-page", @"/Pages/Books/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Books/Details.cshtml", typeof(BookLibrary.Web.Pages.Books.Pages_Books_Details), @"{id}")]
namespace BookLibrary.Web.Pages.Books
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 2 "C:\Users\Asus\SoftUni\9.C# Web\C# Web MVC Frameworks ASP.NET\04.Basics And Razor Pages Exercises\BookLibrary.Web\Pages\_ViewImports.cshtml"
using BookLibrary.Web;

#line default
#line hidden
#line 3 "C:\Users\Asus\SoftUni\9.C# Web\C# Web MVC Frameworks ASP.NET\04.Basics And Razor Pages Exercises\BookLibrary.Web\Pages\_ViewImports.cshtml"
using BookLibrary.Web.BindingModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{id}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb25542fe5d6b4b0c3badd5938ac07b8985e9878", @"/Pages/Books/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ff36466da1b22f276565f2db2f5eb59ca1c94b5", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Books_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Borrow", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Asus\SoftUni\9.C# Web\C# Web MVC Frameworks ASP.NET\04.Basics And Razor Pages Exercises\BookLibrary.Web\Pages\Books\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(106, 136, true);
            WriteLiteral("\r\n<br />\r\n<br />\r\n<div class=\"container\" style=\"height:400px\">\r\n    <div style=\"float:left; padding:0px 25px\">\r\n        <img width=\"300\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 242, "\"", 275, 1);
#line 11 "C:\Users\Asus\SoftUni\9.C# Web\C# Web MVC Frameworks ASP.NET\04.Basics And Razor Pages Exercises\BookLibrary.Web\Pages\Books\Details.cshtml"
WriteAttributeValue("", 248, this.Model.Book.CoverImage, 248, 27, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 276, "\"", 310, 2);
            WriteAttributeValue("", 282, "Image", 282, 5, true);
#line 11 "C:\Users\Asus\SoftUni\9.C# Web\C# Web MVC Frameworks ASP.NET\04.Basics And Razor Pages Exercises\BookLibrary.Web\Pages\Books\Details.cshtml"
WriteAttributeValue(" ", 287, this.Model.Book.Title, 288, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(311, 40, true);
            WriteLiteral(" />\r\n    </div>\r\n    <div>\r\n        <h1>");
            EndContext();
            BeginContext(352, 21, false);
#line 14 "C:\Users\Asus\SoftUni\9.C# Web\C# Web MVC Frameworks ASP.NET\04.Basics And Razor Pages Exercises\BookLibrary.Web\Pages\Books\Details.cshtml"
       Write(this.Model.Book.Title);

#line default
#line hidden
            EndContext();
            BeginContext(373, 22, true);
            WriteLiteral("</h1>\r\n        <h2>by ");
            EndContext();
            BeginContext(396, 27, false);
#line 15 "C:\Users\Asus\SoftUni\9.C# Web\C# Web MVC Frameworks ASP.NET\04.Basics And Razor Pages Exercises\BookLibrary.Web\Pages\Books\Details.cshtml"
          Write(this.Model.Book.Author.Name);

#line default
#line hidden
            EndContext();
            BeginContext(423, 18, true);
            WriteLiteral("</h2>\r\n        <p>");
            EndContext();
            BeginContext(442, 27, false);
#line 16 "C:\Users\Asus\SoftUni\9.C# Web\C# Web MVC Frameworks ASP.NET\04.Basics And Razor Pages Exercises\BookLibrary.Web\Pages\Books\Details.cshtml"
      Write(this.Model.Book.Description);

#line default
#line hidden
            EndContext();
            BeginContext(469, 41, true);
            WriteLiteral("</p>\r\n        <p><strong>status:</strong>");
            EndContext();
            BeginContext(511, 22, false);
#line 17 "C:\Users\Asus\SoftUni\9.C# Web\C# Web MVC Frameworks ASP.NET\04.Basics And Razor Pages Exercises\BookLibrary.Web\Pages\Books\Details.cshtml"
                              Write(this.Model.Book.Status);

#line default
#line hidden
            EndContext();
            BeginContext(533, 20, true);
            WriteLiteral("</p>\r\n    </div>\r\n\r\n");
            EndContext();
#line 20 "C:\Users\Asus\SoftUni\9.C# Web\C# Web MVC Frameworks ASP.NET\04.Basics And Razor Pages Exercises\BookLibrary.Web\Pages\Books\Details.cshtml"
       
        if (this.Model.Book.Status != "Borrowed") { 


#line default
#line hidden
            BeginContext(618, 11, true);
            WriteLiteral("           ");
            EndContext();
            BeginContext(629, 108, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e63940f595db4ee89a0566ef3d98be8a", async() => {
                BeginContext(717, 16, true);
                WriteLiteral("Borrow this book");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 23 "C:\Users\Asus\SoftUni\9.C# Web\C# Web MVC Frameworks ASP.NET\04.Basics And Razor Pages Exercises\BookLibrary.Web\Pages\Books\Details.cshtml"
                                  WriteLiteral(this.Model.Book.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(737, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 24 "C:\Users\Asus\SoftUni\9.C# Web\C# Web MVC Frameworks ASP.NET\04.Basics And Razor Pages Exercises\BookLibrary.Web\Pages\Books\Details.cshtml"
        }
    

#line default
#line hidden
            BeginContext(757, 8, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookLibrary.Web.Pages.Books.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BookLibrary.Web.Pages.Books.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BookLibrary.Web.Pages.Books.DetailsModel>)PageContext?.ViewData;
        public BookLibrary.Web.Pages.Books.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591