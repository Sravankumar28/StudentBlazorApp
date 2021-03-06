#pragma checksum "C:\Users\azxye\source\repos\sravan\StudentApplication\StudentBlazor\Pages\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f630a63ba845f6c1c42f6e6dc3ab346da04f9d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Login), @"mvc.1.0.razor-page", @"/Pages/Login.cshtml")]
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
#line 2 "C:\Users\azxye\source\repos\sravan\StudentApplication\StudentBlazor\Pages\Login.cshtml"
using StudentModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\azxye\source\repos\sravan\StudentApplication\StudentBlazor\Pages\Login.cshtml"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\azxye\source\repos\sravan\StudentApplication\StudentBlazor\Pages\Login.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "/login")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f630a63ba845f6c1c42f6e6dc3ab346da04f9d7", @"/Pages/Login.cshtml")]
    public class Pages_Login : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n<div class=\"container\">\r\n    <h1>Log in to JWT Authentication!</h1>\r\n    <div class=\"form-group\">\r\n        <label for=\"email\">Email</label>\r\n        <input type=\"text\" name=\"email\" placeholder=\"Email\" class=\"form-control\"");
            BeginWriteAttribute("bind", " bind=\"", 376, "\"", 389, 1);
#nullable restore
#line 13 "C:\Users\azxye\source\repos\sravan\StudentApplication\StudentBlazor\Pages\Login.cshtml"
WriteAttributeValue("", 383, Email, 383, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label for=\"password\">Password</label>\r\n        <input type=\"password\" name=\"password\" placeholder=\"Password\" class=\"form-control\"");
            BeginWriteAttribute("bind", " bind=\"", 575, "\"", 591, 1);
#nullable restore
#line 17 "C:\Users\azxye\source\repos\sravan\StudentApplication\StudentBlazor\Pages\Login.cshtml"
WriteAttributeValue("", 582, Password, 582, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    </div>\r\n\r\n    <button");
            BeginWriteAttribute("onclick", " onclick=\"", 622, "\"", 645, 1);
#nullable restore
#line 20 "C:\Users\azxye\source\repos\sravan\StudentApplication\StudentBlazor\Pages\Login.cshtml"
WriteAttributeValue("", 632, SubmitForm(), 632, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Submit</button>\r\n</div>\r\n\r\n");
        }
        #pragma warning restore 1998
#nullable restore
#line 23 "C:\Users\azxye\source\repos\sravan\StudentApplication\StudentBlazor\Pages\Login.cshtml"
            
    public string Email { get; set; } = "";
    public string Password { get; set; } = "";
    public string Token { get; set; } = "";

    private async Task SubmitForm()
    {
        var vm = JsonConvert.SerializeObject(new UserView
        {
            Email = Email,
            Password = Password
        });
        var Http = new HttpClient();
        var response = await Http.PostAsync("http://localhost:8013/api/Login", new StringContent(vm, System.Text.Encoding.UTF8, "application/json"));

        await LocalStore.SetItemAsync<string>("token", $"{response}");
        // Console.WriteLine(response);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Blazored.LocalStorage.ILocalStorageService LocalStore { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pages_Login> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Login> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Login>)PageContext?.ViewData;
        public Pages_Login Model => ViewData.Model;
    }
}
#pragma warning restore 1591
