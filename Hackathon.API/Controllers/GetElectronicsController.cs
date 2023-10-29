using Hackathon.API.DTOs;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace Hackathon.API.Controllers
{
    [ApiController]
    [Route("/api/GetElectronics")]
    public class GetElectronicsController : ControllerBase
    {
      
        [HttpGet("{id}")]
        public IActionResult GetElectronics(int id)
        {
            ElectronicsDTO dto = new ElectronicsDTO();
            var result = dto.returnElectronicsList(id);
            return Ok(result);
        }
    }
}
