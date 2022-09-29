using Business.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;
using Models;
using Stripe.Checkout;

namespace HiddenVilla_API.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class RoomOrderController : Controller
    {
        private readonly IRoomOrderDetailsRepository _repository;
        public RoomOrderController(IRoomOrderDetailsRepository repository)
        {
            _repository = repository;
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] RoomOrderDetailsDto details)
        {
            if (ModelState.IsValid)
            {
                var result = await _repository.Create(details);
                return Ok(result);
            }
            else
            {
                return BadRequest(new ErrorModel()
                {
                    ErrorMessage = "Error while creating Room Details/ Booking"
                });
            }
        }
        [HttpPost]
        public async Task<IActionResult> PaymentSuccessful([FromBody] RoomOrderDetailsDto details)
        {
            var service = new SessionService();
            var sessionDetails = service.Get(details.StripeSeccionId);
            if (sessionDetails.PaymentStatus == "paid")
            {
                var result = await _repository.MarkPaymentSuccessful(details.Id);
                if(result == null)
                {
                    return BadRequest(new ErrorModel()
                    {
                        ErrorMessage = "Can not mark payment as successful"
                    });
                }
                return Ok(result);
            }
            else
            {
                return BadRequest(new ErrorModel()
                {
                    ErrorMessage = "Can not mark payment as successfull"
                });
            }
        }
    }
}
