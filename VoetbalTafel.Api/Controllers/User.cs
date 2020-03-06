using Microsoft.AspNetCore.Mvc;
using VoetbalTafel.Core;

namespace VoetbalTafel.Api.Controllers
{
    [ApiController]
    // [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        
        public UserController(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Index()
        {
            // _context
        }

    }
}