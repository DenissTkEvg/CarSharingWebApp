#pragma checksum "C:\Projects\CarSharingApp\CarSharingApp\CarSharingApp\Views\Account\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ca1876d003b3a7d4f1ce57c2781ab592f0ae1a8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Login), @"mvc.1.0.view", @"/Views/Account/Login.cshtml")]
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
#line 1 "C:\Projects\CarSharingApp\CarSharingApp\CarSharingApp\Views\_ViewImports.cshtml"
using CarSharingApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projects\CarSharingApp\CarSharingApp\CarSharingApp\Views\_ViewImports.cshtml"
using CarSharingApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ca1876d003b3a7d4f1ce57c2781ab592f0ae1a8", @"/Views/Account/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7b8bd3b37c9e7fe3b57a257da21f201b2d61120", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CarSharingApp.Models.LoginModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"modal-content\" style=\"width:750px\">\r\n    <div class=\"modal-header\" style=\"display:flex\">\r\n");
            WriteLiteral("        <h4 style=\"margin:auto\">Войти или зарегистрироваться</h4>\r\n    </div>\r\n    <div class=\"modal-body\" style=\"display: flex;flex-direction:column;width:750px\">\r\n");
#nullable restore
#line 10 "C:\Projects\CarSharingApp\CarSharingApp\CarSharingApp\Views\Account\Login.cshtml"
         using (Html.BeginForm("Login", "Account", FormMethod.Post, new { @class = "form-2", @onsubmit = "return loginSubmit()" }))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <p class=""float"">
                <label for=""login""><i class=""icon-user""></i>Логин</label>
                <input type=""text"" name=""Login"" id=""login"" placeholder=""Логин"">
            </p>
            <p class=""float"">
                <label for=""password""><i class=""icon-lock""></i>Пароль</label>
                <input type=""password"" name=""Password"" id=""pass"" placeholder=""Пароль"" class=""showpassword"" />
            </p>
            <p class=""clearfix"">
                <input type=""submit"" name=""submit"" value=""Войти"">
            </p>
");
#nullable restore
#line 23 "C:\Projects\CarSharingApp\CarSharingApp\CarSharingApp\Views\Account\Login.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <p id=""empty_login_pass_message"" style=""color:red; margin:auto; display:none"">Заполните все обязательные поля (Логин, Пароль)</p>
    </div>
    <div class=""modal-footer"">
        <a href=""javascript:signUpForm()"" style=""color:white; margin-left:20px"" class=""btn btn-info"">Регистрация</a>
    </div>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CarSharingApp.Models.LoginModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
