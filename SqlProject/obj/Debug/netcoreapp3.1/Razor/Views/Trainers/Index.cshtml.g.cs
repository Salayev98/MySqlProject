#pragma checksum "C:\Users\user\Desktop\SqlProject\SqlProject\Views\Trainers\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dde458772b1f4c70dd5c158995809ee43ee702b0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Trainers_Index), @"mvc.1.0.view", @"/Views/Trainers/Index.cshtml")]
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
#line 1 "C:\Users\user\Desktop\SqlProject\SqlProject\Views\_ViewImports.cshtml"
using SqlProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\Desktop\SqlProject\SqlProject\Views\_ViewImports.cshtml"
using SqlProject.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dde458772b1f4c70dd5c158995809ee43ee702b0", @"/Views/Trainers/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9207b240c4e0ccf1e81b04a32e38a2be59aa22b9", @"/Views/_ViewImports.cshtml")]
    public class Views_Trainers_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Trainers>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\user\Desktop\SqlProject\SqlProject\Views\Trainers\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <main id=""main"" data-aos=""fade-in"">

        <!-- ======= Breadcrumbs ======= -->
        <div class=""breadcrumbs"">
            <div class=""container"">
                <h2>Trainers</h2>
                <p>Est dolorum ut non facere possimus quibusdam eligendi voluptatem. Quia id aut similique quia voluptas sit quaerat debitis. Rerum omnis ipsam aperiam consequatur laboriosam nemo harum praesentium. </p>
            </div>
        </div><!-- End Breadcrumbs -->
        <!-- ======= Trainers Section ======= -->
        <section id=""trainers"" class=""trainers"">
            <div class=""container"" data-aos=""fade-up"">

                <div class=""row"" data-aos=""zoom-in"" data-aos-delay=""100"">
");
#nullable restore
#line 20 "C:\Users\user\Desktop\SqlProject\SqlProject\Views\Trainers\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-lg-4 col-md-6 d-flex align-items-stretch\">\r\n                            <div class=\"member\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "dde458772b1f4c70dd5c158995809ee43ee702b05135", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1026, "~/assets/img/trainers/", 1026, 22, true);
#nullable restore
#line 24 "C:\Users\user\Desktop\SqlProject\SqlProject\Views\Trainers\Index.cshtml"
AddHtmlAttributeValue("", 1048, item.Photo, 1048, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                <div class=\"member-content\">\r\n                                    <h4>");
#nullable restore
#line 26 "C:\Users\user\Desktop\SqlProject\SqlProject\Views\Trainers\Index.cshtml"
                                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                    <span>");
#nullable restore
#line 27 "C:\Users\user\Desktop\SqlProject\SqlProject\Views\Trainers\Index.cshtml"
                                     Write(item.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                    <p>\r\n                                        ");
#nullable restore
#line 29 "C:\Users\user\Desktop\SqlProject\SqlProject\Views\Trainers\Index.cshtml"
                                   Write(item.About);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </p>\r\n                                    <div class=\"social\">\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 1508, "\"", 1515, 0);
            EndWriteAttribute();
            WriteLiteral("><i");
            BeginWriteAttribute("class", " class=\"", 1519, "\"", 1541, 1);
#nullable restore
#line 32 "C:\Users\user\Desktop\SqlProject\SqlProject\Views\Trainers\Index.cshtml"
WriteAttributeValue("", 1527, item.Contact1, 1527, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i></a>\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 1595, "\"", 1602, 0);
            EndWriteAttribute();
            WriteLiteral("><i");
            BeginWriteAttribute("class", " class=\"", 1606, "\"", 1628, 1);
#nullable restore
#line 33 "C:\Users\user\Desktop\SqlProject\SqlProject\Views\Trainers\Index.cshtml"
WriteAttributeValue("", 1614, item.Contact2, 1614, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i></a>\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 1682, "\"", 1689, 0);
            EndWriteAttribute();
            WriteLiteral("><i");
            BeginWriteAttribute("class", " class=\"", 1693, "\"", 1715, 1);
#nullable restore
#line 34 "C:\Users\user\Desktop\SqlProject\SqlProject\Views\Trainers\Index.cshtml"
WriteAttributeValue("", 1701, item.Contact3, 1701, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i></a>\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 1769, "\"", 1776, 0);
            EndWriteAttribute();
            WriteLiteral("><i");
            BeginWriteAttribute("class", " class=\"", 1780, "\"", 1802, 1);
#nullable restore
#line 35 "C:\Users\user\Desktop\SqlProject\SqlProject\Views\Trainers\Index.cshtml"
WriteAttributeValue("", 1788, item.Contact4, 1788, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i></a>\r\n\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 41 "C:\Users\user\Desktop\SqlProject\SqlProject\Views\Trainers\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n\r\n            </div>\r\n        </section><!-- End Trainers Section -->\r\n\r\n    </main><!-- End #main -->\r\n    \r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Trainers>> Html { get; private set; }
    }
}
#pragma warning restore 1591
