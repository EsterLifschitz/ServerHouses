using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient; 
using System.Data;             
using System.Collections.Generic;
using ServerHouses;
using Microsoft.Extensions.Configuration;

namespace ServerHouses.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HousesController : ControllerBase
    {
        private readonly string _connectionString;

        public HousesController(IConfiguration configuration)
        {
 
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        [HttpPost("exec")]
        public IActionResult Post([FromBody] MyJson request)
        {

            return Ok();
        }

    }
}









