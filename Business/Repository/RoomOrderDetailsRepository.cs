using AutoMapper;
using Business.Repository.IRepository;
using Common;
using DataAcess.Data;
using Models;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Linq;

namespace Business.Repository
{
    public class RoomOrderDetailsRepository : IRoomOrderDetailsRepository
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;
        public RoomOrderDetailsRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public async Task<RoomOrderDetailsDto> Create(RoomOrderDetailsDto details)
        {
            try
            {
                details.CheckInDate = details.CheckInDate.Date;
                details.CheckOutDate = details.CheckOutDate.Date;
                var roomOrder = _mapper.Map<RoomOrderDetailsDto, RoomOrderDetails>(details);
                roomOrder.Status = SD.Status_Pending;
                var result = await _db.RoomOrderDetails.AddAsync(roomOrder);
                await _db.SaveChangesAsync();
                return _mapper.Map<RoomOrderDetails, RoomOrderDetailsDto>(result.Entity);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<IEnumerable<RoomOrderDetailsDto>> GetAllRoomOrderDetails()
        {
            try
            {
                IEnumerable<RoomOrderDetailsDto>  roomOrders = _mapper.Map<IEnumerable<RoomOrderDetails>, IEnumerable<RoomOrderDetailsDto>>
                    (_db.RoomOrderDetails.Include(u => u.HotelRoom));

                return roomOrders;
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        public async Task<RoomOrderDetailsDto> GetRoomOrderDetail(int roomOrderId)
        {
            try
            {
                RoomOrderDetails roomOrder = await _db.RoomOrderDetails
                    .Include(u => u.HotelRoom).ThenInclude(x => x.HotelRoomImages)
                    .FirstOrDefaultAsync(u => u.Id == roomOrderId);

                RoomOrderDetailsDto roomOrderDetailsDto = _mapper.Map<RoomOrderDetails, RoomOrderDetailsDto>(roomOrder);
                roomOrderDetailsDto.HotelRoomDto.TotalDays = roomOrderDetailsDto.CheckOutDate
                    .Subtract(roomOrderDetailsDto.CheckInDate).Days;

                return roomOrderDetailsDto;
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        public async Task<bool> IsRoomBooked(int roomId, DateTime checkInDate, DateTime checkOutDate)
        {
            var status = false;
            var existingBooking = await _db.RoomOrderDetails.Where(x => x.RoomId == roomId && x.IsPaymentSuccessful &&
            //check if check in date that user wants does not fall in between any dates for room that is booked
            (checkInDate<x.CheckOutDate && checkInDate.Date > x.CheckInDate
            //check if checkout date that the user wantch does not fall in between any dates for room that is booked
            ||checkOutDate.Date > x.CheckInDate.Date && checkInDate < x.CheckInDate
            )).FirstOrDefaultAsync();

            if(existingBooking != null)
            {
                status = true;
            }
            return status;
        }

        public Task<RoomOrderDetailsDto> MarkPaymentSuccessful(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateOrderStatus(int roomOrderId, string status)
        {
            throw new NotImplementedException();
        }
    }
}
