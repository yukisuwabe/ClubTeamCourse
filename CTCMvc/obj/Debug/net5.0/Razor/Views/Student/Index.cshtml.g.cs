#pragma checksum "C:\Users\yukis\OneDrive\Documents\AppDev\Code\ClubTeamCourse\CTCMvc\Views\Student\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f52e2fbe9ad88f7d67a8f008abe451daec93024b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Index), @"mvc.1.0.view", @"/Views/Student/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f52e2fbe9ad88f7d67a8f008abe451daec93024b", @"/Views/Student/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1ce59a68a77587430278fbae22d7568b92f5bee", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ClubTeamCourse.Student>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\yukis\OneDrive\Documents\AppDev\Code\ClubTeamCourse\CTCMvc\Views\Student\Index.cshtml"
  
    ViewBag.Title = "Register";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Index</h2>\r\n");
#nullable restore
#line 7 "C:\Users\yukis\OneDrive\Documents\AppDev\Code\ClubTeamCourse\CTCMvc\Views\Student\Index.cshtml"
 using (Html.BeginForm("Index", "Home", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 12 "C:\Users\yukis\OneDrive\Documents\AppDev\Code\ClubTeamCourse\CTCMvc\Views\Student\Index.cshtml"
       Write(Html.LabelFor( model => model.StudentID, new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 13 "C:\Users\yukis\OneDrive\Documents\AppDev\Code\ClubTeamCourse\CTCMvc\Views\Student\Index.cshtml"
       Write(Html.TextBoxFor( model => model.StudentID, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 14 "C:\Users\yukis\OneDrive\Documents\AppDev\Code\ClubTeamCourse\CTCMvc\Views\Student\Index.cshtml"
       Write(Html.ValidationMessageFor( model => model.StudentID, null, new { @class= "text-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 19 "C:\Users\yukis\OneDrive\Documents\AppDev\Code\ClubTeamCourse\CTCMvc\Views\Student\Index.cshtml"
       Write(Html.LabelFor( model => model.FirstName, new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 20 "C:\Users\yukis\OneDrive\Documents\AppDev\Code\ClubTeamCourse\CTCMvc\Views\Student\Index.cshtml"
       Write(Html.TextBoxFor( model => model.FirstName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 21 "C:\Users\yukis\OneDrive\Documents\AppDev\Code\ClubTeamCourse\CTCMvc\Views\Student\Index.cshtml"
       Write(Html.ValidationMessageFor( model => model.FirstName, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 26 "C:\Users\yukis\OneDrive\Documents\AppDev\Code\ClubTeamCourse\CTCMvc\Views\Student\Index.cshtml"
       Write(Html.LabelFor( model => model.LastName, new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 27 "C:\Users\yukis\OneDrive\Documents\AppDev\Code\ClubTeamCourse\CTCMvc\Views\Student\Index.cshtml"
       Write(Html.TextBoxFor( model => model.LastName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 28 "C:\Users\yukis\OneDrive\Documents\AppDev\Code\ClubTeamCourse\CTCMvc\Views\Student\Index.cshtml"
       Write(Html.ValidationMessageFor( model => model.LastName, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 33 "C:\Users\yukis\OneDrive\Documents\AppDev\Code\ClubTeamCourse\CTCMvc\Views\Student\Index.cshtml"
       Write(Html.LabelFor( model => model.Grade, new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 34 "C:\Users\yukis\OneDrive\Documents\AppDev\Code\ClubTeamCourse\CTCMvc\Views\Student\Index.cshtml"
       Write(Html.TextBoxFor( model => model.Grade, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 35 "C:\Users\yukis\OneDrive\Documents\AppDev\Code\ClubTeamCourse\CTCMvc\Views\Student\Index.cshtml"
       Write(Html.ValidationMessageFor( model => model.Grade, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 40 "C:\Users\yukis\OneDrive\Documents\AppDev\Code\ClubTeamCourse\CTCMvc\Views\Student\Index.cshtml"
       Write(Html.LabelFor( model => model.Email, new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 41 "C:\Users\yukis\OneDrive\Documents\AppDev\Code\ClubTeamCourse\CTCMvc\Views\Student\Index.cshtml"
       Write(Html.TextBoxFor( model => model.Email, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 42 "C:\Users\yukis\OneDrive\Documents\AppDev\Code\ClubTeamCourse\CTCMvc\Views\Student\Index.cshtml"
       Write(Html.ValidationMessageFor( model => model.Email, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 47 "C:\Users\yukis\OneDrive\Documents\AppDev\Code\ClubTeamCourse\CTCMvc\Views\Student\Index.cshtml"
       Write(Html.LabelFor( model => model.Password, new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 48 "C:\Users\yukis\OneDrive\Documents\AppDev\Code\ClubTeamCourse\CTCMvc\Views\Student\Index.cshtml"
       Write(Html.PasswordFor( model => model.Password, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 49 "C:\Users\yukis\OneDrive\Documents\AppDev\Code\ClubTeamCourse\CTCMvc\Views\Student\Index.cshtml"
       Write(Html.ValidationMessageFor( model => model.Password, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 54 "C:\Users\yukis\OneDrive\Documents\AppDev\Code\ClubTeamCourse\CTCMvc\Views\Student\Index.cshtml"
       Write(Html.LabelFor( model => model.Gender, new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 55 "C:\Users\yukis\OneDrive\Documents\AppDev\Code\ClubTeamCourse\CTCMvc\Views\Student\Index.cshtml"
       Write(Html.TextBoxFor( model => model.Gender, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 56 "C:\Users\yukis\OneDrive\Documents\AppDev\Code\ClubTeamCourse\CTCMvc\Views\Student\Index.cshtml"
       Write(Html.ValidationMessageFor( model => model.Gender, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 61 "C:\Users\yukis\OneDrive\Documents\AppDev\Code\ClubTeamCourse\CTCMvc\Views\Student\Index.cshtml"
       Write(Html.LabelFor( model => model.FavoriteSubject, new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 62 "C:\Users\yukis\OneDrive\Documents\AppDev\Code\ClubTeamCourse\CTCMvc\Views\Student\Index.cshtml"
       Write(Html.TextBoxFor( model => model.FavoriteSubject, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 63 "C:\Users\yukis\OneDrive\Documents\AppDev\Code\ClubTeamCourse\CTCMvc\Views\Student\Index.cshtml"
       Write(Html.ValidationMessageFor( model => model.FavoriteSubject, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 68 "C:\Users\yukis\OneDrive\Documents\AppDev\Code\ClubTeamCourse\CTCMvc\Views\Student\Index.cshtml"
       Write(Html.LabelFor( model => model.ProfilePic, new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 69 "C:\Users\yukis\OneDrive\Documents\AppDev\Code\ClubTeamCourse\CTCMvc\Views\Student\Index.cshtml"
       Write(Html.TextBoxFor( model => model.ProfilePic, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 70 "C:\Users\yukis\OneDrive\Documents\AppDev\Code\ClubTeamCourse\CTCMvc\Views\Student\Index.cshtml"
       Write(Html.ValidationMessageFor( model => model.ProfilePic, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"form-group\">\r\n            <input type=\"submit\" value=\"Save\" name=\"save\" class=\"btn btn-primary\"/>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 79 "C:\Users\yukis\OneDrive\Documents\AppDev\Code\ClubTeamCourse\CTCMvc\Views\Student\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
