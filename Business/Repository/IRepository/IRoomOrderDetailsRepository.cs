using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository.IRepository
{
    public interface IRoomOrderDetailsRepository
    {
        public Task<RoomOrderDetailsDto> Create(RoomOrderDetailsDto details);
        public Task<RoomOrderDetailsDto> MarkPaymentSuccessful(int id);
        public Task<RoomOrderDetailsDto> GetRoomOrderDetail(int roomOrderId);
        public Task<IEnumerable<RoomOrderDetailsDto>> GetAllRoomOrderDetails();
        public Task<bool> UpdateOrderStatus(int roomOrderId, string status);
        public Task<bool> IsRoomBooked(int roomId, DateTime checkInDate, DateTime checkOutDate);
    }
}
