using Models;

namespace HiddenVilla_Client.Service.IService
{
    public interface IRoomOrderDetailsService
    {
        public Task<RoomOrderDetailsDto> SaveRoomOrderDetails(RoomOrderDetailsDto roomOrderDetailsDto);
        public Task<RoomOrderDetailsDto> MarkPaymentSuccessful(RoomOrderDetailsDto roomOrderDetailsDto);
    }
}
