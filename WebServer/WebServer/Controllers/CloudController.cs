using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebServer.Data;

namespace WebServer.Controllers
{
    [ApiController]
    public class CloudController : ControllerBase
    {
        DataDBContext dbc = new DataDBContext();

        [HttpGet]
        [Route("api/message")]
        public IActionResult GetMessage()
        {
            return Ok("Hello world.");
        }

        [HttpGet]
        [Route("api/value")]
        public IActionResult GetValue()
        {
            return Ok(dbc.GetNumOfConns());
        }
    }
}
