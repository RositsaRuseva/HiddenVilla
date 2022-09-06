using Business.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace HiddenVilla_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelRoomController : ControllerBase
    {
        private readonly IHotelRoomRepository _hotelRoomRepository;

        public HotelRoomController(IHotelRoomRepository hotelRoomRepository)
        {
            _hotelRoomRepository = hotelRoomRepository;
        }
        /// <summary>
        /// Gets All hotel rooms
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetHotelRooms()
        {
            var allRooms = await _hotelRoomRepository.GetAllHotelRoom();
            return Ok(allRooms);
        }
    }
}
