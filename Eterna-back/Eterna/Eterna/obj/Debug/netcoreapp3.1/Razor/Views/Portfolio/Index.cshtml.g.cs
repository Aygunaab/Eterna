#pragma checksum "C:\Users\Admin\OneDrive\Desktop\Eterna-back\Eterna\Eterna\Views\Portfolio\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "54dd91ae253e33e6ab2d20d52e0019691ba9f8e9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Portfolio_Index), @"mvc.1.0.view", @"/Views/Portfolio/Index.cshtml")]
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
#line 1 "C:\Users\Admin\OneDrive\Desktop\Eterna-back\Eterna\Eterna\Views\_ViewImports.cshtml"
using Eterna.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\OneDrive\Desktop\Eterna-back\Eterna\Eterna\Views\_ViewImports.cshtml"
using Eterna.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\OneDrive\Desktop\Eterna-back\Eterna\Eterna\Views\_ViewImports.cshtml"
using Eterna.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54dd91ae253e33e6ab2d20d52e0019691ba9f8e9", @"/Views/Portfolio/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92747f58f99da587c88da002f42c737165ce5bc5", @"/Views/_ViewImports.cshtml")]
    public class Views_Portfolio_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "portfolio", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("More Details"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 3 "C:\Users\Admin\OneDrive\Desktop\Eterna-back\Eterna\Eterna\Views\Portfolio\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<main id=""main"">

    <!-- ======= Breadcrumbs ======= -->
    <section id=""breadcrumbs"" class=""breadcrumbs"">
        <div class=""container"">

            <ol>
                <li><a href=""index.html"">Home</a></li>
                <li>Portfolio</li>
            </ol>
            <h2>Portfolio</h2>

        </div>
    </section><!-- End Breadcrumbs -->
    <!-- ======= Portfolio Section ======= -->
    <section id=""portfolio"" class=""portfolio"">
        <div class=""container"">

            <div class=""row"">
                <div class=""col-lg-12 d-flex justify-content-center"">
                    <ul id=""portfolio-flters"">
                        <li data-filter=""*"" class=""filter-active"">All</li>
");
#nullable restore
#line 31 "C:\Users\Admin\OneDrive\Desktop\Eterna-back\Eterna\Eterna\Views\Portfolio\Index.cshtml"
                         foreach (Portfolio portfolio in Model.Portfolios)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li data-filter=\".filter-");
#nullable restore
#line 33 "C:\Users\Admin\OneDrive\Desktop\Eterna-back\Eterna\Eterna\Views\Portfolio\Index.cshtml"
                                                    Write(portfolio.Category.filterName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 33 "C:\Users\Admin\OneDrive\Desktop\Eterna-back\Eterna\Eterna\Views\Portfolio\Index.cshtml"
                                                                                    Write(portfolio.Category.filterName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 34 "C:\Users\Admin\OneDrive\Desktop\Eterna-back\Eterna\Eterna\Views\Portfolio\Index.cshtml"

                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </ul>\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"row portfolio-container\">\r\n\r\n");
#nullable restore
#line 43 "C:\Users\Admin\OneDrive\Desktop\Eterna-back\Eterna\Eterna\Views\Portfolio\Index.cshtml"
                 foreach (Portfolio portfolio in Model.Portfolios)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div");
            BeginWriteAttribute("class", " class=\"", 1281, "\"", 1360, 6);
            WriteAttributeValue("", 1289, "col-lg-4", 1289, 8, true);
            WriteAttributeValue(" ", 1297, "col-md-6", 1298, 9, true);
            WriteAttributeValue(" ", 1306, "portfolio-item", 1307, 15, true);
            WriteAttributeValue(" ", 1321, "filter-", 1322, 8, true);
#nullable restore
#line 45 "C:\Users\Admin\OneDrive\Desktop\Eterna-back\Eterna\Eterna\Views\Portfolio\Index.cshtml"
WriteAttributeValue("", 1329, portfolio.Category.filterName, 1329, 30, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 1359, "", 1360, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <div class=\"portfolio-wrap\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "54dd91ae253e33e6ab2d20d52e0019691ba9f8e98602", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1456, "~/assets/img/portfolio/", 1456, 23, true);
#nullable restore
#line 47 "C:\Users\Admin\OneDrive\Desktop\Eterna-back\Eterna\Eterna\Views\Portfolio\Index.cshtml"
AddHtmlAttributeValue("", 1479, portfolio.image, 1479, 16, false);

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
            WriteLiteral("\r\n                            <div class=\"portfolio-info\">\r\n                                <h4>");
#nullable restore
#line 49 "C:\Users\Admin\OneDrive\Desktop\Eterna-back\Eterna\Eterna\Views\Portfolio\Index.cshtml"
                               Write(portfolio.Client);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                <p>");
#nullable restore
#line 50 "C:\Users\Admin\OneDrive\Desktop\Eterna-back\Eterna\Eterna\Views\Portfolio\Index.cshtml"
                              Write(portfolio.Client);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                <div class=""portfolio-links"">
                                    <a href=""assets/img/portfolio/portfolio-1.jpg"" data-gallery=""portfolioGallery"" class=""portfolio-lightbox"" title=""App 1""><i class=""bx bx-plus""></i></a>
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "54dd91ae253e33e6ab2d20d52e0019691ba9f8e911234", async() => {
                WriteLiteral("<i class=\"bx bx-link\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 53 "C:\Users\Admin\OneDrive\Desktop\Eterna-back\Eterna\Eterna\Views\Portfolio\Index.cshtml"
                                                                                         WriteLiteral(portfolio.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 58 "C:\Users\Admin\OneDrive\Desktop\Eterna-back\Eterna\Eterna\Views\Portfolio\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>
    </section><!-- End Portfolio Section -->
    <!-- ======= Clients Section ======= -->
    <section id=""clients"" class=""clients"">
        <div class=""container"">

            <div class=""section-title"">
                <h2>Clients</h2>
                <p>Magnam dolores commodi suscipit. Necessitatibus eius consequatur ex aliquid fuga eum quidem. Sit sint consectetur velit. Quisquam quos quisquam cupiditate. Et nemo qui impedit suscipit alias ea. Quia fugiat sit in iste officiis commodi quidem hic quas.</p>
            </div>

            <div class=""clients-slider swiper"">
                <div class=""swiper-wrapper align-items-center"">
");
#nullable restore
#line 73 "C:\Users\Admin\OneDrive\Desktop\Eterna-back\Eterna\Eterna\Views\Portfolio\Index.cshtml"
                     foreach (Client client in Model.Clients)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"swiper-slide\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "54dd91ae253e33e6ab2d20d52e0019691ba9f8e915164", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3116, "~/assets/img/clients/", 3116, 21, true);
#nullable restore
#line 75 "C:\Users\Admin\OneDrive\Desktop\Eterna-back\Eterna\Eterna\Views\Portfolio\Index.cshtml"
AddHtmlAttributeValue("", 3137, client.Image, 3137, 13, false);

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
            WriteLiteral("</div>\r\n");
#nullable restore
#line 76 "C:\Users\Admin\OneDrive\Desktop\Eterna-back\Eterna\Eterna\Views\Portfolio\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n                <div class=\"swiper-pagination\"></div>\r\n            </div>\r\n\r\n        </div>\r\n    </section><!-- End Clients Section -->\r\n\r\n</main><!-- End #main -->\r\n");
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