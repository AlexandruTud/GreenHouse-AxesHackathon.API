using Hackathon.API.DTOs;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Hackathon.API.Controllers
{
    [ApiController]
    [Route("/api/Register")]
    public class RegisterController : ControllerBase
    {
        
        [HttpPost]
        public IActionResult RegisterUser([FromBody]UserDTO userCredentials)
        {
            if(userCredentials.CheckLoginCredentials(userCredentials)!=0)
            { 
                return BadRequest("Sorry, an account with this email adress already exists");
            }
            else
            {
                userCredentials.RegisterUser(userCredentials);
                return Ok(userCredentials.CheckLoginCredentials(userCredentials));
            }          
        }
    }
}
