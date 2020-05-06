
using wepApi.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Cors;

namespace wepApi.Controllers
{
    [EnableCors("AllowAll")]
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly appContext _context;
        public UserController(appContext context)
        {
            _context = context;
        }

        // GET: api/users
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {

            return await _context.Users.ToListAsync();
        }
         [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(int id)
        {
            var mesajs=await _context.Mesajs.ToListAsync();
            var user = await _context.Users.FindAsync(id);

            return user;
           
        }
        // PO*ST: api/users
        [HttpPost]
        public async Task<ActionResult<User>> Postuser(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUsers", new { id = user.ID }, user);
        }
    }
}