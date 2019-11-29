using Microsoft.AspNetCore.Mvc;
using PcsHackday1.Models;

namespace PcsHackday1.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class RobotController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Sandnesforfa1";
        }

        // POST: /Robot/Move
        [HttpPost("move")]
        public MoveResult Move(RobotMove robotMove)
        {
            var foo = robotMove;

            return new MoveResult
            {
                Result = 10,
                Duration = 13.37m
            };
        }
    }
}
