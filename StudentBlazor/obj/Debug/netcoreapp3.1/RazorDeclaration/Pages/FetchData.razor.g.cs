#pragma checksum "C:\Users\azxye\source\repos\sravan\StudentApplication\StudentBlazor\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ebf53880b9392eb6e427348d498b073a231b032"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 3 "C:\Users\azxye\source\repos\sravan\StudentApplication\StudentBlazor\Pages\FetchData.razor"
using StudentBlazor.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/subject/{StudentId:int}/{SubjectId:int}")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 24 "C:\Users\azxye\source\repos\sravan\StudentApplication\StudentBlazor\Pages\FetchData.razor"
       
    private StudentModels.SubjectDetails subject;
    [Parameter] public int StudentId { get; set; }
    [Parameter] public int SubjectId { get; set; }

    [CascadingParameter] BlazoredModalInstance BlazoredModal { get; set; }
    protected override async Task OnInitializedAsync()
    {
        subject = await studentService.GetStudentMarksAsync(StudentId, SubjectId, await LocalStore.GetItemAsync<string>("token"));
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.LocalStorage.ILocalStorageService LocalStore { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private StudentService studentService { get; set; }
    }
}
#pragma warning restore 1591
