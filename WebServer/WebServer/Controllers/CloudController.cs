using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebServer.Controllers
{
    [ApiController]
    public class CloudController : ControllerBase
    {
        [HttpGet]
        [Route("api/message")]
        public IActionResult GetAllCountries()
        {
            return Ok("Hello world.");
        }
    }
}
