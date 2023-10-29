using Hackathon.API.Entities;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace Hackathon.API.Controllers
{
    [ApiController]
    [Route("/api/getDailyChallenge")]
    public class DailyChallengeController : ControllerBase
    {
        
        [HttpGet]
        public IActionResult getDailyChallenge()
        {
            DailyChallenges daily = new DailyChallenges();
            return Ok(daily.getDailyChallenge());
        }
    }
}
