using Microsoft.AspNetCore.Mvc;
using PcsHackday1.Models;
using PcsHackday1.Services;

namespace PcsHackday1.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class RobotController : ControllerBase
    {
        private readonly IRobotService _robotService;

        public RobotController(IRobotService robotService) => _robotService = robotService;

        [HttpGet]
        public string Get()
        {
            return "Sandnesforfa1";
        }

        // POST: /Robot/Move
        [HttpPost("move")]
        public MoveResult Move(RobotMove robotMove)
        {
            return _robotService.Move(robotMove);
        }
    }
}
