using AutoMapper;
using Business.Repository.IRepository;
using DataAcess.Data;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository
{
    public class HotelRoomRepository : IHotelRoomRepository
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;

        public HotelRoomRepository(ApplicationDbContext db, IMapper mapper)
        {
            _mapper = mapper;
            _db = db;
        }
        public async Task<HotelRoomDto> CreateHotelRoom(HotelRoomDto hotelRoomDto)
        {
            HotelRoom hotelRoom = _mapper.Map<HotelRoomDto, HotelRoom>(hotelRoomDto);
            hotelRoom.CreatedDate = DateTime.Now;
            hotelRoom.CreatedBy = "";
            var addedHotelRoom = await _db.HotelRooms.AddAsync(hotelRoom); //automapper is used to get hotelroom
            await _db.SaveChangesAsync();
            return _mapper.Map<HotelRoom, HotelRoomDto>(addedHotelRoom.Entity);
        }

        public async Task<int> DeleteHotelRoom(int roomId)
        {
            var roomDetails = await _db.HotelRooms.FindAsync(roomId);
            if (roomDetails != null)
            {
                var allImages = await _db.HotelRoomImages.Where(x => x.RoomId == roomId).ToListAsync();
                
                _db.HotelRoomImages.RemoveRange(allImages);
                _db.HotelRooms.Remove(roomDetails);
                return await _db.SaveChangesAsync();
            }
            return 0;
        }

        public async Task<IEnumerable<HotelRoomDto>> GetAllHotelRoom(string checkInDatestr, string checkOutDatestr)
        {
            try
            {
                IEnumerable<HotelRoomDto> hotelRoomDtos = _mapper.Map<IEnumerable<HotelRoom>, IEnumerable<HotelRoomDto>>(_db.HotelRooms.Include(x => x.HotelRoomImages));
                if (!string.IsNullOrEmpty(checkInDatestr) && !string.IsNullOrEmpty(checkOutDatestr))
                {
                    foreach (HotelRoomDto hotelRoom in hotelRoomDtos)
                    {
                        hotelRoom.IsBooked = await IsRoomBooked(hotelRoom.Id, checkInDatestr, checkOutDatestr);
                    }
                }
                return hotelRoomDtos;
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        public async Task<HotelRoomDto> GetHotelRoom(int roomId, string checkInDatestr, string checkOutDatestr)
        {
            try
            {
                HotelRoomDto hotelRoom = _mapper.Map<HotelRoom,HotelRoomDto>(
                    await _db.HotelRooms.Include(x=>x.HotelRoomImages).FirstOrDefaultAsync(x => x.Id == roomId));
                if (!string.IsNullOrEmpty(checkInDatestr) && !string.IsNullOrEmpty(checkOutDatestr))
                {
                    hotelRoom.IsBooked = await IsRoomBooked(roomId, checkInDatestr, checkOutDatestr);
                }
                return hotelRoom;
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        public async Task<bool> IsRoomBooked(int roomId, string checkInDatestr, string checkOutDatestr)
        {
            try
            {
                if (!string.IsNullOrEmpty(checkOutDatestr) && !string.IsNullOrEmpty(checkInDatestr))
                {
                    DateTime checkInDate = DateTime.ParseExact(checkInDatestr, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    DateTime checkOutDate = DateTime.ParseExact(checkOutDatestr, "dd/MM/yyyy", CultureInfo.InvariantCulture);

                    var existingBooking = await _db.RoomOrderDetails.Where(x => x.RoomId == roomId && x.IsPaymentSuccessful &&
                        //check if check in date that user wants does not fall in between any dates for room that is booked
                        ((checkInDate < x.CheckOutDate && checkInDate.Date >= x.CheckInDate)
                        //check if checkout date that the user wantch does not fall in between any dates for room that is booked
                        || (checkOutDate.Date > x.CheckInDate.Date && checkInDate <= x.CheckInDate)
                        )).FirstOrDefaultAsync();
                    if (existingBooking != null)
                    {
                        return true;
                    }
                    return false;
                }
                return true;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public async Task<HotelRoomDto> IsRoomUnique(string name, int roomId = 0)
        {
            try
            {
                if (roomId == 0)
                {
                    HotelRoomDto hotelRoom = _mapper.Map<HotelRoom, HotelRoomDto>(
                        await _db.HotelRooms.FirstOrDefaultAsync(x => x.Name.ToLower() == name.ToLower()));
                    return hotelRoom;
                }
                else
                {
                    HotelRoomDto hotelRoom = _mapper.Map<HotelRoom, HotelRoomDto>(
                        await _db.HotelRooms.FirstOrDefaultAsync(x => x.Name.ToLower() == name.ToLower() 
                        && x.Id != roomId));
                    return hotelRoom;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<HotelRoomDto> UpdateHotelRoom(int roomId, HotelRoomDto hotelRoomDto)
        {
            try
            {
                if (roomId == hotelRoomDto.Id)
                {
                    HotelRoom roomDetails = await _db.HotelRooms.FindAsync(roomId);
                    HotelRoom room = _mapper.Map<HotelRoomDto, HotelRoom>(hotelRoomDto, roomDetails);
                    room.UpdatedBy = "";
                    room.UpdateDate = DateTime.Now;
                    var updatedRoom = _db.HotelRooms.Update(room);
                    await _db.SaveChangesAsync();
                    return _mapper.Map<HotelRoom, HotelRoomDto>(updatedRoom.Entity);
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
