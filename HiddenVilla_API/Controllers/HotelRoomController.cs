﻿using Business.Repository.IRepository;
using Common;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Models;
using System.Globalization;

namespace HiddenVilla_API.Controllers
{
    //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
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
        /// 
        //[Authorize(Roles =  SD.Role_Admin)]
        [HttpGet]
        public async Task<IActionResult> GetHotelRooms(string checkInDate = null, string checkOutDate = null)
        {
            if (string.IsNullOrEmpty(checkInDate) || string.IsNullOrEmpty(checkOutDate))
            {
                return BadRequest(new ErrorModel()
                {
                    StatusCode = StatusCodes.Status400BadRequest,
                    ErrorMessage = "All parameters need to be supplied"
                });
            }
            if (!DateTime.TryParseExact(checkInDate, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out var dtCheckInDate))
            {
                return BadRequest(new ErrorModel()
                {
                    StatusCode = StatusCodes.Status400BadRequest,
                    ErrorMessage = "Invalid CheckIn date format. valid format will be dd/MM/yyyy"
                });
            }
            if (!DateTime.TryParseExact(checkOutDate, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out var dtCheckOutDate))
            {
                return BadRequest(new ErrorModel()
                {
                    StatusCode = StatusCodes.Status400BadRequest,
                    ErrorMessage = "Invalid CheckOut date format. valid format will be dd/MM/yyyy"
                });
            }

            var allRooms = await _hotelRoomRepository.GetAllHotelRoom(checkInDate, checkOutDate);
            return Ok(allRooms);
        }
        [HttpGet("{roomId}")]
        public async Task<IActionResult> GetHotelRoom(int? roomId, string checkInDate = null, string checkOutDate = null)
        {
            if (roomId == null)
            {
                return BadRequest(new ErrorModel()
                {
                    Title = "",
                    ErrorMessage = "Invalid Room Id",
                    StatusCode = StatusCodes.Status400BadRequest
                });
            }
            if (string.IsNullOrEmpty(checkInDate) || string.IsNullOrEmpty(checkOutDate))
            {
                return BadRequest(new ErrorModel()
                {
                    StatusCode = StatusCodes.Status400BadRequest,
                    ErrorMessage = "All parameters need to be supplied"
                });
            }
            if (!DateTime.TryParseExact(checkInDate, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out var dtCheckInDate))
            {
                return BadRequest(new ErrorModel()
                {
                    StatusCode = StatusCodes.Status400BadRequest,
                    ErrorMessage = "Invalid CheckIn date format. valid format will be dd/MM/yyyy"
                });
            }
            if (!DateTime.TryParseExact(checkOutDate, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out var dtCheckOutDate))
            {
                return BadRequest(new ErrorModel()
                {
                    StatusCode = StatusCodes.Status400BadRequest,
                    ErrorMessage = "Invalid CheckOut date format. valid format will be dd/MM/yyyy"
                });
            }
            var roomDetails = await _hotelRoomRepository.GetHotelRoom(roomId.Value, checkInDate, checkOutDate);
            if (roomDetails == null)
            {
                return BadRequest(new ErrorModel()
                {
                    Title = "",
                    ErrorMessage = "Invalid Room Id",
                    StatusCode = StatusCodes.Status404NotFound
                });
            }
            return Ok(roomDetails);
        }
    }
}
