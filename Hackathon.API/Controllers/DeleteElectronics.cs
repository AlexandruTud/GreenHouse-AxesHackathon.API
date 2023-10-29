using Hackathon.API.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace Hackathon.API.Controllers
{
    [ApiController]
    [Route("/api/deleteElectro")]
    public class DeleteElectronics : ControllerBase
    {
        [HttpDelete]
        public IActionResult deleteElectronicDevice(int IdDevice)
        {
            ElectronicsDTO electronicsDTO = new ElectronicsDTO();
            electronicsDTO.DeleteDeviceById(IdDevice);
            return Ok();
        }
    }
}
