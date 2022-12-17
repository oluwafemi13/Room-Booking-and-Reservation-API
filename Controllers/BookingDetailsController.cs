using Hotel_API.Entities;
using Hotel_API.Repository.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Hotel_API.Controllers
{
    [ApiController]
    [Route("Api/v1/[controller]")]
    public class BookingDetailsController : ControllerBase
    {
        private readonly IBookingDetailsRepository _Br;

        public BookingDetailsController(IBookingDetailsRepository Br)
        {
            _Br = Br;
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status202Accepted)]
        [HttpPost("CreateBooking")]
        public async Task<ActionResult> CreateBooking([FromBody] BookingDetail bookingDetails)
        {
 
            var create = _Br.CreateBooking(bookingDetails);
            return Ok(create);

        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status202Accepted)]
        [HttpPut("UpdateBooking")]
        public async Task<ActionResult> UpdateBooking([FromBody] BookingDetail bookingDetails)
        {

            var create = await _Br.UpdateBookingDetails(bookingDetails);
            return Ok(create);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status202Accepted)]
        [HttpDelete("DeleteBooking")]
        public async Task<ActionResult<bool>> DeleteBooking(int UserId)
        {

            var delete = await _Br.DeleteBookingDetails(UserId);
            return Ok(delete);



        }


        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status202Accepted)]
        [HttpGet("GetBookingByEmail")]
        public async Task<ActionResult> GetBookingByEmail(string Email)
        {
            var check = await _Br.GetBookingDetailsByEmail(Email);
            return Ok(check);



        }

    }
}
   
