#pragma checksum "C:\Users\yukis\OneDrive\Documents\AppDev\Code\ClubTeamCourse\CTCMvc\Views\Student\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "90b1d976b7cb05b2c59e26cac495e5c06a5fc668"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Login), @"mvc.1.0.view", @"/Views/Student/Login.cshtml")]
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
#line 1 "C:\Users\yukis\OneDrive\Documents\AppDev\Code\ClubTeamCourse\CTCMvc\Views\_ViewImports.cshtml"
using CTCMvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\yukis\OneDrive\Documents\AppDev\Code\ClubTeamCourse\CTCMvc\Views\_ViewImports.cshtml"
using CTCMvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90b1d976b7cb05b2c59e26cac495e5c06a5fc668", @"/Views/Student/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1ce59a68a77587430278fbae22d7568b92f5bee", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ClubTeamCourse.Student>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\yukis\OneDrive\Documents\AppDev\Code\ClubTeamCourse\CTCMvc\Views\Student\Login.cshtml"
  
    ViewBag.Title = "Login";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row justify-content-md-center\">\r\n    <div class=\"col-md-4\">\r\n        <div class=\"card\">\r\n            <div class=\"card-header\">\r\n                Login\r\n            </div>\r\n            <div class=\"card-body\">\r\n");
#nullable restore
#line 12 "C:\Users\yukis\OneDrive\Documents\AppDev\Code\ClubTeamCourse\CTCMvc\Views\Student\Login.cshtml"
                 using (Html.BeginForm("Login", "Student", FormMethod.Post))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 15 "C:\Users\yukis\OneDrive\Documents\AppDev\Code\ClubTeamCourse\CTCMvc\Views\Student\Login.cshtml"
                   Write(Html.LabelFor(m => m.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 16 "C:\Users\yukis\OneDrive\Documents\AppDev\Code\ClubTeamCourse\CTCMvc\Views\Student\Login.cshtml"
                   Write(Html.TextBoxFor(m => m.Email, "", new {@class = "form-control", @placeholder = "Email"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 19 "C:\Users\yukis\OneDrive\Documents\AppDev\Code\ClubTeamCourse\CTCMvc\Views\Student\Login.cshtml"
                   Write(Html.LabelFor(m => m.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 20 "C:\Users\yukis\OneDrive\Documents\AppDev\Code\ClubTeamCourse\CTCMvc\Views\Student\Login.cshtml"
                   Write(Html.PasswordFor(m => m.Password, new {@class ="form-control", @placeholder="Password"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <input type=\"submit\" name=\"submit\" class=\"btn btn-primary\" vlaue=\"Login\"/>\r\n                    </div>\r\n");
#nullable restore
#line 25 "C:\Users\yukis\OneDrive\Documents\AppDev\Code\ClubTeamCourse\CTCMvc\Views\Student\Login.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ClubTeamCourse.Student> Html { get; private set; }
    }
}
#pragma warning restore 1591
