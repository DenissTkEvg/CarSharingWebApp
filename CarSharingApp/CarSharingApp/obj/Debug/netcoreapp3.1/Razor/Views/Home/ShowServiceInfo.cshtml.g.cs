#pragma checksum "C:\Projects\CarSharingApp\CarSharingApp\CarSharingApp\Views\Home\ShowServiceInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb97f3d45408b0f7e08db192fbcfc242365a26fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ShowServiceInfo), @"mvc.1.0.view", @"/Views/Home/ShowServiceInfo.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb97f3d45408b0f7e08db192fbcfc242365a26fe", @"/Views/Home/ShowServiceInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7b8bd3b37c9e7fe3b57a257da21f201b2d61120", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ShowServiceInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Projects\CarSharingApp\CarSharingApp\CarSharingApp\Views\Home\ShowServiceInfo.cshtml"
  
    ViewData["Title"] = "Info";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<br />
<br />
<p style=""font-size:22px"">
    Данный сервис предназначен для аренды автомобилей, доступных в каталоге.
    Арендовать транспортное средство возможно только в указанных пунктах выдачи.
    Для аренды необходимо иметь учетную запись на сервисе.
</p>
<p style=""font-size:22px"">
    Порядок действий при аренде автомобиля:
</p>
<ul style=""font-size:22px"">
    <li>
        Завести учетную запись или авторизоваться в системе;
    </li>
    <li>
        Выбрать автомобиль со статусом ""Свободна"";
    </li>
    <li>
        Из карточки автомобиля перейти к оформлению аренды;
    </li>
    <li>
        При оформлении необходимо указать время аренды, а также выбрать пункт выдачи;
    </li>
    <li>
        После завершения оформления все необходимые документы и указания по оплате будут высланы на Ваш email, указанный при регистрации.
    </li>
</ul>");
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
