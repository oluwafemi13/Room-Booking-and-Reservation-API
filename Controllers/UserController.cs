using AutoMapper;
using Hotel_API.DTO;
using Hotel_API.Repository.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Hotel_API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class UserController : ControllerBase
    {


        private readonly IUserRepository _SuiteRepository;
        private readonly IMapper _Mapper;
        private readonly ILogger<SuiteController> _Logger;

        public UserController(IUserRepository SuiteRepository,
                                IMapper Mapper,
                                ILogger<SuiteController> Logger)

        {
            _Logger = Logger;
            _SuiteRepository = SuiteRepository;
            _Mapper = Mapper;
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status202Accepted)]
        [HttpPost("CreateUser")]
        public async Task<ActionResult> CreateUser([FromBody] UserDTO userDto)
        {
            _Logger.LogInformation($"Attempt to Create User");
  
             var create = _SuiteRepository.CreateUser(userDto);
            return Ok(create);


        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status202Accepted)]
        [HttpPut("UpdateUser")]
        public async Task<ActionResult> UpdateUser([FromBody] UserDTO userDto)
        {
            _Logger.LogInformation($"Attempt to Update User");

            var create =await _SuiteRepository.UpdateUser(userDto);
            return Ok(create);


        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status202Accepted)]
        [HttpDelete("DeleteUser")]
        public async Task<ActionResult<bool>> DeleteUser(int UserId)
        {
            _Logger.LogInformation($"Attempt to Delete User");

            var delete = await _SuiteRepository.DeleteUser(UserId);
            return Ok(delete);
            


        }


        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status202Accepted)]
        [HttpGet("GetUser")]
        public async Task<ActionResult> GetUserByEmail(string Email)
        {
            var check =await _SuiteRepository.GetUserByEmail(Email);
            return Ok(check);



        }

    }
}
