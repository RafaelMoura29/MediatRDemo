// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorUi.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\rafae\source\repos\MediatRDemo\BlazorUi\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rafae\source\repos\MediatRDemo\BlazorUi\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\rafae\source\repos\MediatRDemo\BlazorUi\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\rafae\source\repos\MediatRDemo\BlazorUi\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\rafae\source\repos\MediatRDemo\BlazorUi\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\rafae\source\repos\MediatRDemo\BlazorUi\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\rafae\source\repos\MediatRDemo\BlazorUi\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\rafae\source\repos\MediatRDemo\BlazorUi\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\rafae\source\repos\MediatRDemo\BlazorUi\_Imports.razor"
using BlazorUi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\rafae\source\repos\MediatRDemo\BlazorUi\_Imports.razor"
using BlazorUi.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\rafae\source\repos\MediatRDemo\BlazorUi\_Imports.razor"
using DemoLibrary.DataAccess.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\rafae\source\repos\MediatRDemo\BlazorUi\_Imports.razor"
using DemoLibrary.Handlers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\rafae\source\repos\MediatRDemo\BlazorUi\_Imports.razor"
using DemoLibrary.Queries;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\rafae\source\repos\MediatRDemo\BlazorUi\Pages\FetchData.razor"
using BlazorUi.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "C:\Users\rafae\source\repos\MediatRDemo\BlazorUi\Pages\FetchData.razor"
       
    private WeatherForecast[] forecasts;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await ForecastService.GetForecastAsync(DateTime.Now);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private WeatherForecastService ForecastService { get; set; }
    }
}
#pragma warning restore 1591
