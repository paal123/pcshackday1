using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PcsHackday1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RobotController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Sandnesforfa1";
        }

        // POST: api/Robot
        [HttpPost]
        public void Post([FromBody] string value)
        {

        }
    }
}
