#pragma checksum "C:\Users\Rositsa Ruseva\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\LifeCycle.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c5b4444d842d6c73bf5affc4652ab96d34300ac4"
// <auto-generated/>
#pragma warning disable 1591
namespace HiddenVilla_Server.Pages.LearnBlazor
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Rositsa Ruseva\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Rositsa Ruseva\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Rositsa Ruseva\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Rositsa Ruseva\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Rositsa Ruseva\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Rositsa Ruseva\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Rositsa Ruseva\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Rositsa Ruseva\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Rositsa Ruseva\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using HiddenVilla_Server;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Rositsa Ruseva\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using HiddenVilla_Server.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Rositsa Ruseva\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using HiddenVilla_Server.Pages.LearnBlazor.LearnBlazorComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Rositsa Ruseva\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using HiddenVilla_Server.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Rositsa Ruseva\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using HiddenVilla_Server.Helper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Rositsa Ruseva\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Blazored.TextEditor;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/lifecycle")]
    public partial class LifeCycle : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>LifeCycle</h3>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "border");
            __builder.OpenComponent<HiddenVilla_Server.Pages.LearnBlazor.LearnBlazorComponents.LifeCycleComponent>(3);
            __builder.AddAttribute(4, "CountValue", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 5 "C:\Users\Rositsa Ruseva\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\LifeCycle.razor"
                                      currentCount

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n");
            __builder.OpenElement(6, "p");
            __builder.AddContent(7, "Current count: ");
            __builder.AddContent(8, 
#nullable restore
#line 7 "C:\Users\Rositsa Ruseva\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\LifeCycle.razor"
                   currentCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n");
            __builder.OpenElement(10, "button");
            __builder.AddAttribute(11, "class", "btn btn-primary");
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "C:\Users\Rositsa Ruseva\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\LifeCycle.razor"
                                          IncrementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(13, "Click me");
            __builder.CloseElement();
#nullable restore
#line 11 "C:\Users\Rositsa Ruseva\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\LifeCycle.razor"
 foreach (var item in EventType)
{
    

#line default
#line hidden
#nullable disable
            __builder.AddContent(14, 
#nullable restore
#line 13 "C:\Users\Rositsa Ruseva\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\LifeCycle.razor"
     item

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(15, "<br>");
#nullable restore
#line 15 "C:\Users\Rositsa Ruseva\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\LifeCycle.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 16 "C:\Users\Rositsa Ruseva\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\LifeCycle.razor"
       
    private int currentCount = 0;
    List<string> EventType = new List<string>();
    private void IncrementCount()
    {
        currentCount++;
    }
    protected override void OnInitialized()
    {
        EventType.Add("OnInitialized is called");
    }

    protected override async Task OnInitializedAsync()
    {
        EventType.Add("OnInitializedAsync is called");
        await Task.Delay(1000);
    }

    protected override void OnParametersSet()
    {
        EventType.Add("OnParametersSet is called");
    }
    protected override async Task OnParametersSetAsync()
    {
        EventType.Add("OnParametersSet is called");
        await Task.Delay(1000);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
