#pragma checksum "C:\Users\user\Desktop\SqlProject\SqlProject\Views\Home\Pricing.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af496b5e07bca9f85b84227126a34ef834324ccb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Pricing), @"mvc.1.0.view", @"/Views/Home/Pricing.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af496b5e07bca9f85b84227126a34ef834324ccb", @"/Views/Home/Pricing.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9207b240c4e0ccf1e81b04a32e38a2be59aa22b9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Pricing : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Payment>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\user\Desktop\SqlProject\SqlProject\Views\Home\Pricing.cshtml"
  
    ViewData["Title"] = "Pricing";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

    <main id=""main"">
        <!-- ======= Breadcrumbs ======= -->
        <div class=""breadcrumbs"" data-aos=""fade-in"">
            <div class=""container"">
                <h2>Pricing</h2>
                <p>Est dolorum ut non facere possimus quibusdam eligendi voluptatem. Quia id aut similique quia voluptas sit quaerat debitis. Rerum omnis ipsam aperiam consequatur laboriosam nemo harum praesentium. </p>
            </div>
        </div><!-- End Breadcrumbs -->
        <!-- ======= Pricing Section ======= -->
        <section id=""pricing"" class=""pricing"">
            <div class=""container"" data-aos=""fade-up"">

                <div class=""row"">

");
#nullable restore
#line 21 "C:\Users\user\Desktop\SqlProject\SqlProject\Views\Home\Pricing.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-lg-3 col-md-6\">\r\n                            <div class=\"box\">\r\n                                <h3>");
#nullable restore
#line 25 "C:\Users\user\Desktop\SqlProject\SqlProject\Views\Home\Pricing.cshtml"
                               Write(item.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                <h4>");
#nullable restore
#line 26 "C:\Users\user\Desktop\SqlProject\SqlProject\Views\Home\Pricing.cshtml"
                               Write(item.Cost);

#line default
#line hidden
#nullable disable
            WriteLiteral("<span> / month</span></h4>\r\n                                <ul>\r\n                                    <li>");
#nullable restore
#line 28 "C:\Users\user\Desktop\SqlProject\SqlProject\Views\Home\Pricing.cshtml"
                                   Write(item.Possible);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                    <li>");
#nullable restore
#line 29 "C:\Users\user\Desktop\SqlProject\SqlProject\Views\Home\Pricing.cshtml"
                                   Write(item.Possible);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                    <li>");
#nullable restore
#line 30 "C:\Users\user\Desktop\SqlProject\SqlProject\Views\Home\Pricing.cshtml"
                                   Write(item.Possible);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
                                    <li class=""na"">Pharetra massa</li>
                                    <li class=""na"">Massa ultricies mi</li>
                                </ul>
                                <div class=""btn-wrap"">
                                    <a");
            BeginWriteAttribute("href", " href=\"", 1542, "\"", 1559, 1);
#nullable restore
#line 35 "C:\Users\user\Desktop\SqlProject\SqlProject\Views\Home\Pricing.cshtml"
WriteAttributeValue("", 1549, item.Link, 1549, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn-buy\">Buy Now</a>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 39 "C:\Users\user\Desktop\SqlProject\SqlProject\Views\Home\Pricing.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n                </div>\r\n\r\n            </div>\r\n        </section><!-- End Pricing Section -->\r\n\r\n    </main><!-- End #main -->\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Payment>> Html { get; private set; }
    }
}
#pragma warning restore 1591
