// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace HiddenVilla_Server.Pages.HotelAmenity
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
#line 3 "C:\Users\Rositsa Ruseva\HiddenVilla\HiddenVilla_Server\Pages\HotelAmenity\HotelAmenityUpsert.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Rositsa Ruseva\HiddenVilla\HiddenVilla_Server\Pages\HotelAmenity\HotelAmenityUpsert.razor"
using Business.Repository.IRepository;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/hotel-amenity/create")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/hotel-amenity/edit/{Id:int}")]
    public partial class HotelAmenityUpsert : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 47 "C:\Users\Rositsa Ruseva\HiddenVilla\HiddenVilla_Server\Pages\HotelAmenity\HotelAmenityUpsert.razor"
       
    [Parameter]
    public int? Id { get; set; }
    internal HotelAmenityDto HotelAmenityModel { get; set; } = new HotelAmenityDto();
    internal string Title { get; set; } = "Create";
    internal bool IsProcessingStart { get; set; } = false;

    protected override async Task OnInitializedAsync()
    {
        if (Id != null)
        {
            //update
            Title = "Update";
            HotelAmenityModel = await HotelAmenityRepository.GetHotelAmenity(Id.Value);
        }
        else
        {
            HotelAmenityModel = new HotelAmenityDto();
        }
    }

    internal async Task HandleHotelAmenityCreate()
    {
        try
        {
            IsProcessingStart = true;
            if (HotelAmenityModel.Id != 0 && Title == "Update")
            {
                var amenityDetailsByName = await HotelAmenityRepository.IsSameNameAmenityAlreadyExists(HotelAmenityModel.Name);
                if (amenityDetailsByName != null && amenityDetailsByName.Id != HotelAmenityModel.Id)
                {
                    await JsRuntime.ToastrError("Hotel Amenity already exists");
                    return;
                }
                //Update the hotel amenity here
                var updateHotelAmenityResult = await HotelAmenityRepository.UpdateHotelAmenity(HotelAmenityModel.Id, HotelAmenityModel);

                await JsRuntime.ToastrSuccess("Hotel Amenity updated successfully");
            }
            else
            {
                var amenityDetailsByName = await HotelAmenityRepository.IsSameNameAmenityAlreadyExists(HotelAmenityModel.Name);
                if (amenityDetailsByName != null)
                {
                    await JsRuntime.ToastrError("Hotel Amenity name already exists");
                }

                //Create new hotel amenity here
                var createResult = await HotelAmenityRepository.CreateHotelAmenity(HotelAmenityModel);
                HotelAmenityModel = new HotelAmenityDto();
                await JsRuntime.ToastrSuccess("Hotel amenity created successfully");
            }
            NavigationManager.NavigateTo("hotel-amenity");
            IsProcessingStart = false;
        }
        catch (Exception ex)
        {
            IsProcessingStart = false;
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHotelAmenityRepository HotelAmenityRepository { get; set; }
    }
}
#pragma warning restore 1591