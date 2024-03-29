﻿using AutoMapper;
using DataAcess.Data;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<HotelRoomDto, HotelRoom>();
            CreateMap<HotelRoom, HotelRoomDto>();
            CreateMap<HotelRoomImage, HotelRoomImageDTO>().ReverseMap();
            CreateMap<HotelAmenity, HotelAmenityDto>().ReverseMap();
            CreateMap<RoomOrderDetails, RoomOrderDetailsDto>().ReverseMap();
        }
    }
}
