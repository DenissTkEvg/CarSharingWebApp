#pragma checksum "C:\Projects\CarSharingApp\CarSharingApp\CarSharingApp\Views\Account\SignUp.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b530c7eb93fdff658c46827e9ee9dfead3bcc1d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_SignUp), @"mvc.1.0.view", @"/Views/Account/SignUp.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b530c7eb93fdff658c46827e9ee9dfead3bcc1d3", @"/Views/Account/SignUp.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7b8bd3b37c9e7fe3b57a257da21f201b2d61120", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_SignUp : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CarSharingApp.Models.LoginModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"modal-content\" style=\"width:550px\">\r\n    <div class=\"modal-header\" style=\"display:flex\">\r\n        <h4 style=\"margin:auto\">Регистрация</h4>\r\n    </div>\r\n    <div class=\"modal-body\">\r\n");
#nullable restore
#line 8 "C:\Projects\CarSharingApp\CarSharingApp\CarSharingApp\Views\Account\SignUp.cshtml"
     using (Html.BeginForm("SignUp", "Account", FormMethod.Post, new { @onsubmit = "return signUpSubmit()" }))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""form-group"">
            <label for=""sign_up_full_name"">ФИО</label>
            <input type=""text"" name=""Full_name"" class=""form-control"" id=""sign_up_full_name"" placeholder=""Иванов Иван Иванович"">
        </div>
        <div class=""form-group"">
            <label for=""sign_up_login"">Логин (Email)</label>
            <input type=""hidden"" id=""login_check"" />
            <input type=""email"" name=""Login"" class=""form-control"" id=""sign_up_login"" placeholder=""Email"" onchange=""checkNewAdminLogin(this.value)"">
            <p style=""color:red;display:none"" id=""check_login_message"">Пользователь с таким логином уже существует</p>
        </div>
        <div class=""form-group"">
            <label for=""sign_up_pass"">Пароль</label>
            <input type=""password"" name=""Password"" class=""form-control"" id=""sign_up_pass"" placeholder=""Password"">
        </div>
        <div class=""form-group"">
            <label for=""sign_up_phone"">Номер телефона</label>
            <input type=""text"" name=""P");
            WriteLiteral(@"hone"" class=""form-control"" id=""sign_up_phone"" placeholder=""+79112223344"">
        </div>
        <div style=""display:flex; flex-direction:column"">
            <p style=""color:red;display:none; margin:auto"" id=""sign_up_check_empty_fields_message"">Необходимо заполнить все поля</p>
            <br/>
            <button type=""submit"" class=""btn btn-success"" style=""margin:auto"">Зарегистрироваться</button>
        </div>
");
#nullable restore
#line 33 "C:\Projects\CarSharingApp\CarSharingApp\CarSharingApp\Views\Account\SignUp.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n");
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
