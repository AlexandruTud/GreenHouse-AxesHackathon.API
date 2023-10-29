using Hackathon.API.DTOs;
using Hackathon.API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Hackathon.API.Controllers
{
    [ApiController]
    [Route("/api/CO2")]
    public class CO2Controller : ControllerBase
    {
        [HttpGet("{IdUser}")]
        public IActionResult getCO2LevelsByID(int IdUser)
        {
            UserDTO userDTO = new UserDTO();
            var result = userDTO.getCo2Levels(IdUser);
            return Ok(result);
        }
    }
}
