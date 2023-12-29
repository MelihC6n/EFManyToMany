using EFManyToMany.Models.ORM;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
            var webUser = _context.WebUsers.Include(x => x.Orders).ToList();
            return Ok(webUser);
        }


    }
}
