using Dapper;
using Hackathon.API.DTOs;
using Hackathon.API.Entities;
using Hackathon.API.Infrastructure;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;

namespace Hackathon.API.Controllers
{

    [ApiController]
    [Route("/api/Login")]
    public class LoginController : ControllerBase
    {
        
        [HttpPost]
        public IActionResult LoginUser([FromBody]UserDTO userCredentials)
        {

            if (userCredentials.CheckLoginCredentials(userCredentials)!=0)
            {
                return Ok($"{userCredentials.CheckLoginCredentials(userCredentials)}");
            }
            return BadRequest("Login Failed, User or Password are invalid");
        }

    }
}
