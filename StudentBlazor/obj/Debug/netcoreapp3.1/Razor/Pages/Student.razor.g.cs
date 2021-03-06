#pragma checksum "C:\Users\azxye\source\repos\sravan\StudentApplication\StudentBlazor\Pages\Student.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "940d69dca4255463816fdb9e7d531ff0dd4dea87"
// <auto-generated/>
#pragma warning disable 1591
namespace StudentBlazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\azxye\source\repos\sravan\StudentApplication\StudentBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\azxye\source\repos\sravan\StudentApplication\StudentBlazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\azxye\source\repos\sravan\StudentApplication\StudentBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\azxye\source\repos\sravan\StudentApplication\StudentBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\azxye\source\repos\sravan\StudentApplication\StudentBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\azxye\source\repos\sravan\StudentApplication\StudentBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\azxye\source\repos\sravan\StudentApplication\StudentBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\azxye\source\repos\sravan\StudentApplication\StudentBlazor\_Imports.razor"
using StudentBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\azxye\source\repos\sravan\StudentApplication\StudentBlazor\_Imports.razor"
using StudentBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\azxye\source\repos\sravan\StudentApplication\StudentBlazor\_Imports.razor"
using Blazored;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\azxye\source\repos\sravan\StudentApplication\StudentBlazor\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\azxye\source\repos\sravan\StudentApplication\StudentBlazor\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\azxye\source\repos\sravan\StudentApplication\StudentBlazor\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\azxye\source\repos\sravan\StudentApplication\StudentBlazor\Pages\Student.razor"
using StudentBlazor.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\azxye\source\repos\sravan\StudentApplication\StudentBlazor\Pages\Student.razor"
using StudentModels;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/students")]
    public partial class Student : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 10 "C:\Users\azxye\source\repos\sravan\StudentApplication\StudentBlazor\Pages\Student.razor"
 if (!IsLoggedIn)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.AddMarkupContent(1, "<h1>Please Login to access this info........</h1>\r\n    ");
            __builder.AddMarkupContent(2, "<div><a href=\"/\">Login</a></div>\r\n");
#nullable restore
#line 14 "C:\Users\azxye\source\repos\sravan\StudentApplication\StudentBlazor\Pages\Student.razor"
}

else if (studentDetails == null)
{


#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __builder.AddMarkupContent(4, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 20 "C:\Users\azxye\source\repos\sravan\StudentApplication\StudentBlazor\Pages\Student.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(5, "    ");
            __builder.AddMarkupContent(6, "<h1>Students</h1>\r\n");
            __builder.AddContent(7, "    ");
            __builder.AddMarkupContent(8, "<p>This component demonstrates fetching Student data from a service.</p>\r\n    ");
            __builder.OpenElement(9, "table");
            __builder.AddAttribute(10, "class", "table");
            __builder.AddMarkupContent(11, "\r\n        ");
            __builder.AddMarkupContent(12, "<thead>\r\n            <tr>\r\n                <th>Id</th>\r\n                <th>First Name</th>\r\n                <th>Last Name</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(13, "tbody");
            __builder.AddMarkupContent(14, "\r\n");
#nullable restore
#line 35 "C:\Users\azxye\source\repos\sravan\StudentApplication\StudentBlazor\Pages\Student.razor"
             foreach (var studentDetail in studentDetails)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(15, "                ");
            __builder.OpenElement(16, "tr");
            __builder.AddMarkupContent(17, "\r\n                    ");
            __builder.OpenElement(18, "td");
            __builder.OpenElement(19, "a");
            __builder.AddAttribute(20, "href", "/studentdetails/" + (
#nullable restore
#line 38 "C:\Users\azxye\source\repos\sravan\StudentApplication\StudentBlazor\Pages\Student.razor"
                                                  studentDetail.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(21, 
#nullable restore
#line 38 "C:\Users\azxye\source\repos\sravan\StudentApplication\StudentBlazor\Pages\Student.razor"
                                                                     studentDetail.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                    ");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
#line 39 "C:\Users\azxye\source\repos\sravan\StudentApplication\StudentBlazor\Pages\Student.razor"
                         studentDetail.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                    ");
            __builder.OpenElement(26, "td");
            __builder.AddContent(27, 
#nullable restore
#line 40 "C:\Users\azxye\source\repos\sravan\StudentApplication\StudentBlazor\Pages\Student.razor"
                         studentDetail.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n");
#nullable restore
#line 42 "C:\Users\azxye\source\repos\sravan\StudentApplication\StudentBlazor\Pages\Student.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(30, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n");
#nullable restore
#line 45 "C:\Users\azxye\source\repos\sravan\StudentApplication\StudentBlazor\Pages\Student.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 47 "C:\Users\azxye\source\repos\sravan\StudentApplication\StudentBlazor\Pages\Student.razor"
       
    public bool IsLoggedIn = false;
    private StudentModels.Student[] studentDetails;

    protected override async Task OnInitializedAsync()
    {

        studentDetails = await studentService.GetAllStudentAsync(await LocalStore.GetItemAsync<string>("token"));
    }
    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        IsLoggedIn = await LocalStore.ContainKeyAsync("token");
        StateHasChanged();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.LocalStorage.ILocalStorageService LocalStore { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private StudentService studentService { get; set; }
    }
}
#pragma warning restore 1591
