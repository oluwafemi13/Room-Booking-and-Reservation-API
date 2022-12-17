using AutoMapper;
using Hotel_API.DTO;
using Hotel_API.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Hotel_API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class SuiteController : ControllerBase
    {
        private readonly ISuiteRepository _SuiteRepository;
        private readonly IMapper _Mapper;
        private readonly ILogger<SuiteController> _Logger;
        public SuiteController(ISuiteRepository SuiteRepository,
                                IMapper Mapper,
                                ILogger<SuiteController> Logger)

        {
            _Logger = Logger;
            _SuiteRepository = SuiteRepository;
            _Mapper = Mapper;
        }

        [HttpPost("CreateSuite")]
        [ProducesResponseType( typeof(SuiteDTO), (int)HttpStatusCode.OK)]
        public async Task<ActionResult> CreateSuite([FromBody] SuiteDTO suiteDTO)
        {
           var create =  await _SuiteRepository.CreateSuite(suiteDTO);

            return Ok(create);

        }

        [HttpDelete("DeleteSuite")]
        
        [ProducesResponseType(typeof(SuiteDTO), (int)HttpStatusCode.OK)]
        public async Task<ActionResult> DeleteSuite(int id)
        {
            
            
            return Ok(await _SuiteRepository.DeleteSuite(id));
        }

        [HttpPut("UpdateSuite")]
        [ProducesResponseType(typeof(SuiteDTO), (int)HttpStatusCode.OK)]
        public async Task<ActionResult> UpdateSuite([FromBody]SuiteDTO suiteDTO)
        {
            if (suiteDTO == null)
                return BadRequest(suiteDTO);
            
            return Ok(await _SuiteRepository.UpdateSuite(suiteDTO));
        }

        [HttpGet("GetSuiteById")]
        //[ProducesResponseType(typeof(SuiteDTO), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<SuiteDTO>> GetSuiteById(int id)
        {
            var found = await _SuiteRepository.GetSuiteById(id);
            return Ok(found);

        }

        [HttpGet("GetSuiteByPrice")]
        //[ProducesResponseType(typeof(SuiteDTO), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<SuiteDTO>> GetSuiteByPrice(int price)
        {
            var found = await _SuiteRepository.GetSuiteByPrice(price);
            return Ok(found);

        }



    }
}
