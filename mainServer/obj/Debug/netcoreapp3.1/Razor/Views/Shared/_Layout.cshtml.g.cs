#pragma checksum "C:\WebAPIProjects\MediShare\mainServer\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c760ea97872295483855d642add931213a8e4eab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c760ea97872295483855d642add931213a8e4eab", @"/Views/Shared/_Layout.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MediShare.Models.LoginModel>
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
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\WebAPIProjects\MediShare\mainServer\Views\Shared\_Layout.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n<!DOCTYPE html>\n<html lang=\"en\">\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c760ea97872295483855d642add931213a8e4eab2948", async() => {
                WriteLiteral("\n        <meta charset=\"utf-8\" />\n        <meta name=\"viewport\" content=\"width=device-width, initial-scale=1, shrink-to-fit=no\" />\n        <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 268, "\"", 278, 0);
                EndWriteAttribute();
                WriteLiteral(" />\n        <meta name=\"author\"");
                BeginWriteAttribute("content", " content=\"", 310, "\"", 320, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
        <title>MediShare - Your Daily Medical Store</title>
        <!-- Favicon-->
        <link rel=""icon"" type=""image/x-icon"" href=""dist/HomePageLayout/assets/favicon.ico"" />
        <!-- Core theme CSS (includes Bootstrap)-->
        <link href=""dist/HomePageLayout/css/styles.css"" rel=""stylesheet"" />

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
            WriteLiteral("\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c760ea97872295483855d642add931213a8e4eab4758", async() => {
                WriteLiteral(@"
        <!-- Navigation-->
        <nav class=""navbar navbar-expand-lg navbar-dark bg-dark"">
            <div class=""container"">
                <a href=""/"" class=""logo"">
                    <span class=""logo-lg""><i class=""fas fa-clinic-medical"" style=""color: #c5eaff""></i>MediShare</span>
                </a>
                <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarResponsive"" aria-controls=""navbarResponsive"" aria-expanded=""false"" aria-label=""Toggle navigation""><span class=""navbar-toggler-icon""></span></button>
                <div class=""collapse navbar-collapse"" id=""navbarResponsive"">
                    <ul class=""navbar-nav ml-auto"">
                        <li class=""nav-item""><a class=""nav-link"" href=""https://www.google.com/"">
                            <svg xmlns=""http://www.w3.org/2000/svg"" width=""16"" height=""16"" fill=""currentColor"" class=""bi bi-cart"" viewBox=""0 0 16 16"">
                            <path d=""M0 1.5A.5.5 0 0 1 .5 1H2a.5.5 0 0 1 .485.379L");
                WriteLiteral(@"2.89 3H14.5a.5.5 0 0 1 .491.592l-1.5 8A.5.5 0 0 1 13 12H4a.5.5 0 0 1-.491-.408L2.01 3.607 1.61 2H.5a.5.5 0 0 1-.5-.5zM3.102 4l1.313 7h8.17l1.313-7H3.102zM5 12a2 2 0 1 0 0 4 2 2 0 0 0 0-4zm7 0a2 2 0 1 0 0 4 2 2 0 0 0 0-4zm-7 1a1 1 0 1 1 0 2 1 1 0 0 1 0-2zm7 0a1 1 0 1 1 0 2 1 1 0 0 1 0-2z""/>
                            </svg><i class=""bi bi-cart"">cart</i></a></li>
                        <li class=""nav-item""><a class=""nav-link"" href=""#!"">Services</a></li>
");
#nullable restore
#line 38 "C:\WebAPIProjects\MediShare\mainServer\Views\Shared\_Layout.cshtml"
                          
                            if(Model.password != "n"){
                                

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                <div class=""btn-group"">
                                    <button type=""button"" class=""btn btn-secondary dropdown-toggle"" data-toggle=""dropdown"" aria-haspopup=""true""
                                                    aria-expanded=""false"">
                                                    ");
#nullable restore
#line 44 "C:\WebAPIProjects\MediShare\mainServer\Views\Shared\_Layout.cshtml"
                                               Write(Model.email);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                    </button>
                                        <div class=""dropdown-menu"">
                                            <a class=""dropdown-item"" href=""/UserDashboard"">Dashboard</a>
                                            <a class=""dropdown-item"" href=""/Logout"">Logout</a>
                                        </div>
                                </div>
");
#nullable restore
#line 51 "C:\WebAPIProjects\MediShare\mainServer\Views\Shared\_Layout.cshtml"
                            }else{

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <li class=\"nav-item\"><a class=\"nav-link\" href=\"/Login\">Login/Register</a></li>\n");
#nullable restore
#line 53 "C:\WebAPIProjects\MediShare\mainServer\Views\Shared\_Layout.cshtml"
                            }
                        

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </ul>\n                </div>\n            </div>\n        </nav>\n\n        <div>\n            ");
#nullable restore
#line 61 "C:\WebAPIProjects\MediShare\mainServer\Views\Shared\_Layout.cshtml"
       Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@";
        </div>


        <footer class=""py-5 bg-dark"">
            <div class=""container"">
                <p class=""m-0 text-center text-white"">Copyright &copy; Your Website 2021</p>
            </div>
            <li class=""nav-item""><a class=""nav-link"" href=""#!"">Test Button</a></li>
        </footer>
        <!-- Bootstrap core JS-->
        <script src=""https://code.jquery.com/jquery-3.5.1.slim.min.js""></script>
        <script src=""https://cdn.jsdelivr.net/npm/bootstrap@4.6.0/dist/js/bootstrap.bundle.min.js""></script>
        <!-- Core theme JS-->
        <script src=""dist/HomePageLayout/js/scripts.js""></script>
    ");
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
            WriteLiteral(@"
</html>










<div class=""header navigation"">
  
  <div class=""col-xl-9 col-lg-10 col-sm-8 col-7"">

    <ul class=""navbar-nav flex-row justify-content-end flex-wrap align-items-center mr-lg-4 mr-xl-0"">

      <li class=""nav-item px-3 text-uppercase mb-0 position-relative d-lg-flex"">
        <div id=""cart"" class=""d-none"">

        </div>
        <a href=""/store/cart.stml"" class=""cart position-relative d-inline-flex"" aria-label=""View your shopping cart"">
          <i class=""fas fa fa-shopping-cart fa-lg""></i>
          <span class=""cart-basket d-flex align-items-center justify-content-center"">
            0
          </span>
        </a>
      </li>
      <button id=""sidenav-open-btn"" class=""menu-hamburger position-absolute pointer p-0"">
        <span class=""icon-bar""></span>
        <span class=""icon-bar""></span>
        <span class=""icon-bar""></span>
      </button>
    </ul>
  </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MediShare.Models.LoginModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
