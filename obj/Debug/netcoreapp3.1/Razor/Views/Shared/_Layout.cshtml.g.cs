#pragma checksum "C:\Users\Admin\source\repos\ProductStore\ProductStore\Views\Shared\_Layout.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0099b72375a7f53723ab35a40d127d5b26f515aa234ce25530ddc5577e2d69dc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
namespace AspNetCore
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Admin\source\repos\ProductStore\ProductStore\Views\_ViewImports.cshtml"
using ProductStore

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\Admin\source\repos\ProductStore\ProductStore\Views\_ViewImports.cshtml"
using ProductStore.Models

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"0099b72375a7f53723ab35a40d127d5b26f515aa234ce25530ddc5577e2d69dc", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"a194bb9660a27f237d9a53f00600cf291148bf33fbf88d445134623c830b4142", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0099b72375a7f53723ab35a40d127d5b26f515aa234ce25530ddc5577e2d69dc3432", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\r\n    <title>");
                Write(
#nullable restore
#line 6 "C:\Users\Admin\source\repos\ProductStore\ProductStore\Views\Shared\_Layout.cshtml"
            ViewData["Title"]

#line default
#line hidden
#nullable disable
                );
                WriteLiteral(@" - Gastronom</title>
    <link rel=""stylesheet"" href=""https://cdn.jsdelivr.net/npm/bootstrap@4.1.3/dist/css/bootstrap.min.css"">
    <style>
        html, body {
            height: 100%;
        }

        .green-custom {
            background-color: green;
        }

            .green-custom .nav-link, .green-custom  div {
                color: white;
            }

                .green-custom .nav-link:hover {
                    font-weight: bold;
                }

        .navbar-toggler-icon {
            background-image: url(""data:image/svg+xml;charset=utf8,%3Csvg viewBox='0 0 30 30' xmlns='http://www.w3.org/2000/svg'%3E%3Cpath stroke='rgba%28255, 255, 255, 0.5%29' stroke-width='2' stroke-linecap='round' stroke-miterlimit='10' d='M4 7h22M4 15h22M4 23h22'/%3E%3C/svg%3E"");
        }

        main {
            flex: 1;
        }

        .footer {
            background-color: green;
            color: white;
        }

            .footer a {
                color:");
                WriteLiteral(@" white;
            }

            .footer .text-muted {
                color: white !important;
            }

        .footer-bottom {
            display: flex;
            justify-content: center;
            align-items: center;
        }
    </style>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0099b72375a7f53723ab35a40d127d5b26f515aa234ce25530ddc5577e2d69dc6161", async() => {
                WriteLiteral("\r\n    <header>\r\n        <nav class=\"navbar navbar-expand-lg green-custom\">\r\n            <a class=\"navbar-brand text-white\"");
                BeginWriteAttribute("href", " href=\"", 1612, "\"", 1647, 1);
                WriteAttributeValue("", 1619, 
#nullable restore
#line 56 "C:\Users\Admin\source\repos\ProductStore\ProductStore\Views\Shared\_Layout.cshtml"
                                                      Url.Action("Index", "Home")

#line default
#line hidden
#nullable disable
                , 1619, 28, false);
                EndWriteAttribute();
                WriteLiteral(@">Gastronom</a>
            <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarNav"" aria-controls=""navbarNav"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                <span class=""navbar-toggler-icon""></span>
            </button>
            <div class=""collapse navbar-collapse"" id=""navbarNav"">
                <ul class=""navbar-nav mr-auto"">
                    <li class=""nav-item"">
                        <a class=""nav-link""");
                BeginWriteAttribute("href", " href=\"", 2134, "\"", 2172, 1);
                WriteAttributeValue("", 2141, 
#nullable restore
#line 63 "C:\Users\Admin\source\repos\ProductStore\ProductStore\Views\Shared\_Layout.cshtml"
                                                   Url.Action("Index", "Product")

#line default
#line hidden
#nullable disable
                , 2141, 31, false);
                EndWriteAttribute();
                WriteLiteral(">Продукти</a>\r\n                    </li>\r\n                    <li class=\"nav-item\">\r\n                        <a class=\"nav-link\"");
                BeginWriteAttribute("href", " href=\"", 2301, "\"", 2336, 1);
                WriteAttributeValue("", 2308, 
#nullable restore
#line 66 "C:\Users\Admin\source\repos\ProductStore\ProductStore\Views\Shared\_Layout.cshtml"
                                                   Url.Action("Index", "Cart")

#line default
#line hidden
#nullable disable
                , 2308, 28, false);
                EndWriteAttribute();
                WriteLiteral(">Кошик</a>\r\n                    </li>\r\n                </ul>\r\n            </div>\r\n        </nav>\r\n    </header>\r\n    <main class=\"container my-4\">\r\n        ");
                Write(
#nullable restore
#line 73 "C:\Users\Admin\source\repos\ProductStore\ProductStore\Views\Shared\_Layout.cshtml"
         RenderBody()

#line default
#line hidden
#nullable disable
                );
                WriteLiteral(@"
    </main>
    <footer class=""footer green-custom py-4"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-md-4"">
                    <h5>Посилання</h5>
                    <ul class=""list-unstyled"">
                        <li><a");
                BeginWriteAttribute("href", " href=\"", 2790, "\"", 2825, 1);
                WriteAttributeValue("", 2797, 
#nullable restore
#line 81 "C:\Users\Admin\source\repos\ProductStore\ProductStore\Views\Shared\_Layout.cshtml"
                                      Url.Action("Index", "Home")

#line default
#line hidden
#nullable disable
                , 2797, 28, false);
                EndWriteAttribute();
                WriteLiteral(">Головна</a></li>\r\n                        <li><a");
                BeginWriteAttribute("href", " href=\"", 2875, "\"", 2913, 1);
                WriteAttributeValue("", 2882, 
#nullable restore
#line 82 "C:\Users\Admin\source\repos\ProductStore\ProductStore\Views\Shared\_Layout.cshtml"
                                      Url.Action("Index", "Product")

#line default
#line hidden
#nullable disable
                , 2882, 31, false);
                EndWriteAttribute();
                WriteLiteral(">Продукти</a></li>\r\n                        <li><a");
                BeginWriteAttribute("href", " href=\"", 2964, "\"", 2999, 1);
                WriteAttributeValue("", 2971, 
#nullable restore
#line 83 "C:\Users\Admin\source\repos\ProductStore\ProductStore\Views\Shared\_Layout.cshtml"
                                      Url.Action("Index", "Cart")

#line default
#line hidden
#nullable disable
                , 2971, 28, false);
                EndWriteAttribute();
                WriteLiteral(@">Кошик</a></li>
                    </ul>
                </div>
                <div class=""col-md-4"">
                    <h5>Контакти</h5>
                    <ul class=""list-unstyled"">
                        <li>example@example.com</li>
                        <li>example2@example.com</li>
                        <li>+1234567890</li>
                        <li>+0987654321</li>
                    </ul>
                </div>
                <div class=""col-md-4"">
                    <h5>Час роботи</h5>
                    <p>Пн-Нд: 09:00 - 24:00</p>
                </div>
            </div>
        </div>
        <div class=""container footer-bottom py-2"">
            <span class=""text-muted"">&copy; 2024 Магазин</span>
        </div>
    </footer>
    <script src=""https://code.jquery.com/jquery-3.3.1.slim.min.js""></script>
    <script src=""https://cdn.jsdelivr.net/npm/popper.js@1.14.3/dist/umd/popper.min.js""></script>
    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@4.1.3/d");
                WriteLiteral("ist/js/bootstrap.min.js\"></script>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
