using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChunabAPI.Controllers
{
    [Route("api/[controller]")]
    public class Candidates : ControllerBase
    {
        [HttpGet]
        public IActionResult Index()
        {
            return Ok();
        }
    }
}
