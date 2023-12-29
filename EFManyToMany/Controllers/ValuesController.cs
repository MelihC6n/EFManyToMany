using EFManyToMany.Models.ORM;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EFManyToMany.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly WebuserDbContext _context;

        public ValuesController()
        {
            _context = new WebuserDbContext();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.WebUsers);
        }


    }
}
