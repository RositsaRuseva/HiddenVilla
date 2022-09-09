using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository.IRepository
{
    public interface IHotelAmenityRepository
    {
        public Task<HotelAmenityDto> CreateHotelAmenity(HotelAmenityDto hotelAmenityDto);
        public Task<HotelAmenityDto> UpdateHotelAmenity(int amenityId, HotelAmenityDto hotelAmenityDto);
        public Task<int> DeleteHotelAmenity(int amenityId, string userId);
        public Task<IEnumerable<HotelAmenityDto>> GetAllHotelAmenities();
        public Task<HotelAmenityDto> GetHotelAmenity(int amenityId);
        public Task<HotelAmenityDto> IsSameNameAmenityAlreadyExists(string name);
    }
}
