using AutoMapper;
using Business.Repository.IRepository;
using DataAcess.Data;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository
{
    public class HotelAmenityRepository : IHotelAmenityRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public HotelAmenityRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<HotelAmenityDto> CreateHotelAmenity(HotelAmenityDto hotelAmenityDto)
        {
            HotelAmenity hotelAmenity = _mapper.Map<HotelAmenityDto, HotelAmenity>(hotelAmenityDto);
            hotelAmenity.CreatedBy = "";
            hotelAmenity.CreatedDate = DateTime.UtcNow;
            var addedHotelAmenity = await _context.HotelAmenities.AddAsync(hotelAmenity);
            await _context.SaveChangesAsync();
            return _mapper.Map<HotelAmenity, HotelAmenityDto>(addedHotelAmenity.Entity);
        }

        public async Task<int> DeleteHotelAmenity(int amenityId, string userId)
        {
            var hotelAmenityDetails = await _context.HotelAmenities.FindAsync(amenityId);
            if (hotelAmenityDetails != null)
            {
                _context.HotelAmenities.Remove(hotelAmenityDetails);
                return await _context.SaveChangesAsync();
            }
            return 0;
        }

        public async Task<IEnumerable<HotelAmenityDto>> GetAllHotelAmenities()
        {
            return _mapper.Map<IEnumerable<HotelAmenity>, IEnumerable<HotelAmenityDto>>(await _context.HotelAmenities.ToListAsync());
        }

        public async Task<HotelAmenityDto> GetHotelAmenity(int amenityId)
        {
            var amenityData = await _context.HotelAmenities
                .FirstOrDefaultAsync(x => x.Id == amenityId);
            if (amenityData == null)
            {
                return null;
            }
            return _mapper.Map<HotelAmenity, HotelAmenityDto>(amenityData);
        }

        public async Task<HotelAmenityDto> IsSameNameAmenityAlreadyExists(string name)
        {
            try
            {
                var amenityDetails = await _context.HotelAmenities
                    .FirstOrDefaultAsync(x => x.Name.ToLower().Trim() == name.ToLower().Trim());
                return _mapper.Map<HotelAmenity, HotelAmenityDto>(amenityDetails);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return new HotelAmenityDto();
        }

        public async Task<HotelAmenityDto> UpdateHotelAmenity(int amenityId, HotelAmenityDto hotelAmenity)
        {
            var amenityDetails = await _context.HotelAmenities.FindAsync(amenityId);
            var amenity = _mapper.Map<HotelAmenityDto, HotelAmenity>(hotelAmenity, amenityDetails);
            amenity.UpdatedBy = "";
            amenity.UpdatedDate = DateTime.UtcNow;
            var updateAmenity = _context.HotelAmenities.Update(amenity);
            await _context.SaveChangesAsync();
            return _mapper.Map<HotelAmenity, HotelAmenityDto>(updateAmenity.Entity);
        }
    }
}
