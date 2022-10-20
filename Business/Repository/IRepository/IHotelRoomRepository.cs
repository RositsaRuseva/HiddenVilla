using Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Business.Repository.IRepository
{
    public interface IHotelRoomRepository
    {
        public Task<HotelRoomDto> CreateHotelRoom(HotelRoomDto hotelRoomDto);
        public Task<HotelRoomDto> UpdateHotelRoom(int roomId, HotelRoomDto hotelRoomDto);
        public Task<HotelRoomDto> GetHotelRoom(int roomId, string checkInDate = null, string checkOutDate = null);
        public Task<int> DeleteHotelRoom(int roomId);
        public Task<IEnumerable<HotelRoomDto>> GetAllHotelRoom(string checkInDate = null, string checkOutDate = null);
        public Task<HotelRoomDto> IsRoomUnique(string name, int roomId = 0);
        public Task<bool> IsRoomBooked(int roomId, string checkInDate, string checkOutDate);
    }
}
