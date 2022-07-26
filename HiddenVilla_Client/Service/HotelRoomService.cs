﻿using HiddenVilla_Client.Service.IService;
using Models;
using Newtonsoft.Json;

namespace HiddenVilla_Client.Service
{
    public class HotelRoomService : IHotelRoomService
    {
        private readonly HttpClient _client;
        public HotelRoomService(HttpClient client)
        {
            _client = client;
        }
        public async Task<HotelRoomDto> GetHotelRoomDetails(int roomId, string checkInDate, string checkOutDate)
        {
            var responce = await _client.GetAsync($"api/hotelroom/{roomId}?checkInDate={checkInDate}&checkOutDate={checkOutDate}");
            if(responce.IsSuccessStatusCode)
            {
                var content = await responce.Content.ReadAsStringAsync();
                var room = JsonConvert.DeserializeObject<HotelRoomDto>(content);
                return room;
            }
            else
            {
                var content = await responce.Content.ReadAsStringAsync();
                var errorModel = JsonConvert.DeserializeObject<ErrorModel>(content);
                throw new Exception(errorModel.ErrorMessage);
            }
        }

        public async Task<IEnumerable<HotelRoomDto>> GetHotelRooms(string checkInDate, string checkOutDate)
        {
            var response = await _client.GetAsync($"api/hotelroom?checkInDate={checkInDate}&checkOutDate={checkOutDate}");
            var content = await response.Content.ReadAsStringAsync();
            var rooms = JsonConvert.DeserializeObject<IEnumerable<HotelRoomDto>>(content);
            return rooms;
        }
    }
}
