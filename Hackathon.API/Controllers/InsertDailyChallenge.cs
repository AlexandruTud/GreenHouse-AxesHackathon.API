using Hackathon.API.DTOs;
using Hackathon.API.Entities;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace Hackathon.API.Controllers
{
    [ApiController]
    [Route("/api/InsertDailyChallenge")]
    public class InsertDailyChallenge : ControllerBase
    {
        
        [HttpPost]
        public IActionResult InsertUserChallengeComplete(UserChallengeDTO userChallengeDTO)
        {
            DailyChallenges dailyChallenges = new DailyChallenges();
            var idChallenge = dailyChallenges.GetDailyChallengeIdByName(userChallengeDTO.ChallengeDescription);
            dailyChallenges.insertUserChallenge(userChallengeDTO.IdUser, idChallenge);
            return Ok("Challenge finished successfully");
        }
    }
}
