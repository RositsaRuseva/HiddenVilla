#pragma checksum "C:\Users\Rositsa Ruseva\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazorComponents\IndividualRoom.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0fb0b29ad746d6cb654039468c4235be6be6f5c4"
// <auto-generated/>
#pragma warning disable 1591
namespace HiddenVilla_Server.Pages.LearnBlazor.LearnBlazorComponents
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
    public partial class IndividualRoom : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "bg-light border p-2 col-5 offset-1");
            __builder.OpenElement(2, "h4");
            __builder.AddAttribute(3, "class", "text-secondary");
            __builder.AddContent(4, "Room - ");
            __builder.AddContent(5, 
#nullable restore
#line 3 "C:\Users\Rositsa Ruseva\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazorComponents\IndividualRoom.razor"
                                       Room.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n\r\n    ");
            __builder.AddContent(7, 
#nullable restore
#line 5 "C:\Users\Rositsa Ruseva\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazorComponents\IndividualRoom.razor"
     Room.RoomName

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(8, "<br>\r\n    ");
            __builder.AddContent(9, 
#nullable restore
#line 6 "C:\Users\Rositsa Ruseva\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazorComponents\IndividualRoom.razor"
     Room.Price.ToString("c")

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(10, "<br>\r\n    ");
            __builder.OpenElement(11, "input");
            __builder.AddAttribute(12, "type", "checkbox");
            __builder.AddAttribute(13, "checked", 
#nullable restore
#line 7 "C:\Users\Rositsa Ruseva\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazorComponents\IndividualRoom.razor"
                                                                  Room.IsActive?"checked":null

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(14, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 7 "C:\Users\Rositsa Ruseva\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazorComponents\IndividualRoom.razor"
                                        Room.IsActive

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Room.IsActive = __value, Room.IsActive));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, " &nbsp; Is Active<br>\r\n    ");
            __builder.OpenElement(17, "span");
            __builder.AddContent(18, "This room is ");
            __builder.AddContent(19, 
#nullable restore
#line 8 "C:\Users\Rositsa Ruseva\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazorComponents\IndividualRoom.razor"
                         Room.IsActive?"Active" : "Inactive"

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 9 "C:\Users\Rositsa Ruseva\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazorComponents\IndividualRoom.razor"
     if (Room.IsActive)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Rositsa Ruseva\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazorComponents\IndividualRoom.razor"
         foreach (var roomProp in Room.RoomProps)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(20, "p");
            __builder.AddContent(21, 
#nullable restore
#line 13 "C:\Users\Rositsa Ruseva\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazorComponents\IndividualRoom.razor"
                  roomProp.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(22, " - ");
            __builder.AddContent(23, 
#nullable restore
#line 13 "C:\Users\Rositsa Ruseva\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazorComponents\IndividualRoom.razor"
                                   roomProp.Value

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 14 "C:\Users\Rositsa Ruseva\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazorComponents\IndividualRoom.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Rositsa Ruseva\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazorComponents\IndividualRoom.razor"
         
    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(24, "<br>\r\n    ");
            __builder.OpenComponent<HiddenVilla_Server.Pages.LearnBlazor.LearnBlazorComponents.DeleteEditButtons>(25);
            __builder.AddAttribute(26, "IsAdmin", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 17 "C:\Users\Rositsa Ruseva\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazorComponents\IndividualRoom.razor"
                                true

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 19 "C:\Users\Rositsa Ruseva\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazorComponents\IndividualRoom.razor"
       
    [Parameter]
    public BlazorRoom Room { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
