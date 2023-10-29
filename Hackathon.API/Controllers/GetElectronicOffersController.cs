using Hackathon.API.DTOs;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace Hackathon.API.Controllers
{
    [ApiController]
    [Route("/api/getoffers")]
    public class GetElectronicOffersController : ControllerBase
    {
        
        [HttpGet("{id}")]
        public IActionResult GetElectronicOffers(int id)
        {
            ElectronicsDTO electronicsDTO = new ElectronicsDTO();
            var result = electronicsDTO.returnBestElectronicsById(id);
            return Ok(result);
        }
    }
}
