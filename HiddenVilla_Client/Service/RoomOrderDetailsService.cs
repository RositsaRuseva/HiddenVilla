using HiddenVilla_Client.Service.IService;
using Models;
using Newtonsoft.Json;
using System.Text;

namespace HiddenVilla_Client.Service
{
    public class RoomOrderDetailsService : IRoomOrderDetailsService
    {
        private readonly HttpClient _client;

        public RoomOrderDetailsService(HttpClient client)
        {
            _client = client;
        }
        public async Task<RoomOrderDetailsDto> MarkPaymentSuccessful(RoomOrderDetailsDto roomOrderDetailsDto)
        {
            var content = JsonConvert.SerializeObject(roomOrderDetailsDto);
            var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");
            var response = await _client.PostAsync("api/roomorder/paymentsuccessful", bodyContent);
            if (response.IsSuccessStatusCode)
            {
                var contentTemp = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<RoomOrderDetailsDto>(contentTemp);
                return result;
            }
            else
            {
                var contentTemp = await response.Content.ReadAsStringAsync();
                var errorModel = JsonConvert.DeserializeObject<ErrorModel>(contentTemp);
                throw new Exception(errorModel.ErrorMessage);
            }
        }

        public async Task<RoomOrderDetailsDto> SaveRoomOrderDetails(RoomOrderDetailsDto roomOrderDetailsDto)
        {
            roomOrderDetailsDto.UserId = "dummy user";
            var content = JsonConvert.SerializeObject(roomOrderDetailsDto);
            var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");
            var response = await _client.PostAsync("api/roomorder/create", bodyContent);
            if (response.IsSuccessStatusCode)
            {
                var contentTemp = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<RoomOrderDetailsDto>(contentTemp);
                return result;
            }
            else
            {
                var contentTemp = await response.Content.ReadAsStringAsync();
                var errorModel = JsonConvert.DeserializeObject<ErrorModel>(contentTemp);
                throw new Exception(errorModel.ErrorMessage);
            }
        }
    }
}
