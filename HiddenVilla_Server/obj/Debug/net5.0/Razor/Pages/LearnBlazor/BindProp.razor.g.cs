#pragma checksum "C:\Users\Rositsa Ruseva\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\BindProp.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "909f1ee13872bfe02fe03a2e6ade8dc4a7b4be9c"
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
#nullable restore
#line 2 "C:\Users\Rositsa Ruseva\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\BindProp.razor"
using Model;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/bindprop")]
    public partial class BindProp : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "bg-light border p-2");
            __builder.AddMarkupContent(2, "<h2 class=\"bg-light border p2\">\r\n        First Room\r\n    </h2>\r\n    Room: ");
            __builder.AddContent(3, 
#nullable restore
#line 12 "C:\Users\Rositsa Ruseva\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\BindProp.razor"
           blazorRoom.RoomName

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(4, "\r\n    <br>\r\n    Price: ");
            __builder.AddContent(5, 
#nullable restore
#line 14 "C:\Users\Rositsa Ruseva\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\BindProp.razor"
            blazorRoom.Price

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(6, "\r\n    <br>\r\n\r\n    ");
            __builder.OpenElement(7, "input");
            __builder.AddAttribute(8, "type", "number");
            __builder.AddAttribute(9, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 17 "C:\Users\Rositsa Ruseva\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\BindProp.razor"
                                       blazorRoom.Price

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(10, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => blazorRoom.Price = __value, blazorRoom.Price, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n    <br>\r\n    ");
            __builder.OpenElement(12, "input");
            __builder.AddAttribute(13, "type", "checkbox");
            __builder.AddAttribute(14, "checked", 
#nullable restore
#line 19 "C:\Users\Rositsa Ruseva\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\BindProp.razor"
                                                                         blazorRoom.IsActive?"checked":null

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(15, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "C:\Users\Rositsa Ruseva\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\BindProp.razor"
                                         blazorRoom.IsActive

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => blazorRoom.IsActive = __value, blazorRoom.IsActive));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, " &nbsp; Is Active <br>\r\n    ");
            __builder.OpenElement(18, "span");
            __builder.AddContent(19, "This room is ");
            __builder.AddContent(20, 
#nullable restore
#line 20 "C:\Users\Rositsa Ruseva\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\BindProp.razor"
                         blazorRoom.IsActive?"Active":"Inactive"

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, " <br>\r\n\r\n    ");
            __builder.OpenElement(22, "select");
            __builder.AddAttribute(23, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 22 "C:\Users\Rositsa Ruseva\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\BindProp.razor"
                   SelectedRoomProp

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => SelectedRoomProp = __value, SelectedRoomProp));
            __builder.SetUpdatesAttributeName("value");
#nullable restore
#line 23 "C:\Users\Rositsa Ruseva\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\BindProp.razor"
         foreach (var prop in blazorRoom.RoomProps)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(25, "option");
            __builder.AddAttribute(26, "value", 
#nullable restore
#line 25 "C:\Users\Rositsa Ruseva\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\BindProp.razor"
                            prop.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(27, 
#nullable restore
#line 25 "C:\Users\Rositsa Ruseva\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\BindProp.razor"
                                        prop.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 26 "C:\Users\Rositsa Ruseva\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\BindProp.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n    <br>\r\n    ");
            __builder.OpenElement(29, "span");
            __builder.AddContent(30, "The Room Prop selected is: ");
            __builder.AddContent(31, 
#nullable restore
#line 29 "C:\Users\Rositsa Ruseva\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\BindProp.razor"
                                      SelectedRoomProp

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n    <br>");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n");
            __builder.OpenElement(34, "div");
            __builder.AddMarkupContent(35, "<h2 class=\"text-info\">Room List</h2>\r\n    ");
            __builder.OpenElement(36, "table");
            __builder.AddAttribute(37, "class", "table table-dark");
#nullable restore
#line 35 "C:\Users\Rositsa Ruseva\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\BindProp.razor"
         foreach(var room in RoomsList)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(38, "tr");
            __builder.OpenElement(39, "td");
            __builder.OpenElement(40, "input");
            __builder.AddAttribute(41, "type", "text");
            __builder.AddAttribute(42, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 39 "C:\Users\Rositsa Ruseva\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\BindProp.razor"
                                                    room.RoomName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(43, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => room.RoomName = __value, room.RoomName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                ");
            __builder.OpenElement(45, "td");
            __builder.OpenElement(46, "input");
            __builder.AddAttribute(47, "type", "text");
            __builder.AddAttribute(48, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 42 "C:\Users\Rositsa Ruseva\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\BindProp.razor"
                                                    room.Price

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(49, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => room.Price = __value, room.Price));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 44 "C:\Users\Rositsa Ruseva\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\BindProp.razor"
                 foreach(var roomProp in room.RoomProps)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(50, "td");
            __builder.AddContent(51, 
#nullable restore
#line 47 "C:\Users\Rositsa Ruseva\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\BindProp.razor"
                         roomProp.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(52, " - ");
            __builder.AddContent(53, 
#nullable restore
#line 47 "C:\Users\Rositsa Ruseva\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\BindProp.razor"
                                          roomProp.Value

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 49 "C:\Users\Rositsa Ruseva\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\BindProp.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 51 "C:\Users\Rositsa Ruseva\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\BindProp.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n    <br>");
#nullable restore
#line 54 "C:\Users\Rositsa Ruseva\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\BindProp.razor"
     foreach(var room in RoomsList)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(55, "p");
            __builder.AddContent(56, 
#nullable restore
#line 56 "C:\Users\Rositsa Ruseva\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\BindProp.razor"
            room.RoomName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(57, "\'s Price is ");
            __builder.AddContent(58, 
#nullable restore
#line 56 "C:\Users\Rositsa Ruseva\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\BindProp.razor"
                                      room.Price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 57 "C:\Users\Rositsa Ruseva\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\BindProp.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 60 "C:\Users\Rositsa Ruseva\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\BindProp.razor"
 
    string SelectedRoomProp = "";
    List<BlazorRoom> RoomsList = new List<BlazorRoom>();
    BlazorRoom blazorRoom = new BlazorRoom()
    {
        Id = 1,
        RoomName = "Villa Suite",
        IsActive = true,
        Price = 499,
        RoomProps = new List<BlazorRoomProp>
        {
            new BlazorRoomProp{Id = 1,Name="Sq Ft", Value="100"},
            new BlazorRoomProp{Id = 2,Name="Occupancy", Value="3"},

        }
    };

    protected override void OnInitialized()
    {
        base.OnInitialized();
        RoomsList.Add(new BlazorRoom()
        {
            Id = 201,
            RoomName = "Villa Suite One Bed Room",
            IsActive = true,
            Price = 399,
            RoomProps = new List<BlazorRoomProp>
        {
            new BlazorRoomProp{Id = 1,Name="Sq Ft", Value="330"},
            new BlazorRoomProp{Id = 2,Name="Occupancy", Value="4"},

        }
        });
        RoomsList.Add(new BlazorRoom()
        {
            Id = 301,
            RoomName = "Villa Suite Two Bed Room",
            IsActive = true,
            Price = 699,
            RoomProps = new List<BlazorRoomProp>
        {
            new BlazorRoomProp{Id = 1,Name="Sq Ft", Value="150"},
            new BlazorRoomProp{Id = 2,Name="Occupancy", Value="6"},

        }
        });
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
