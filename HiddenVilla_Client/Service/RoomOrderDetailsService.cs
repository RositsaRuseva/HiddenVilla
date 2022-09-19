using HiddenVilla_Client.Service.IService;
using Models;

namespace HiddenVilla_Client.Service
{
    public class RoomOrderDetailsService : IRoomOrderDetailsService
    {
        private readonly HttpClient _client;

        public RoomOrderDetailsService(HttpClient client)
        {
            _client = client;
        }
        public Task<RoomOrderDetailsDto> MarkPaymentSuccessful(RoomOrderDetailsDto roomOrderDetailsDto)
        {
            throw new NotImplementedException();
        }

        public Task<RoomOrderDetailsDto> SaveRoomOrderDetails(RoomOrderDetailsDto roomOrderDetailsDto)
        {
            throw new NotImplementedException();
        }
    }
}
