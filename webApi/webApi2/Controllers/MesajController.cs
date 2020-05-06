
using wepApi.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace wepApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MesajController : ControllerBase
    {
        private readonly appContext _context;
        public MesajController(appContext context)
        {
            _context = context;
        }

        // GET: api/mesaj
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Mesaj>>> GetMesajs()
        {

            return await _context.Mesajs.ToListAsync();
        }
         [HttpGet("{id}")]
        public async Task<ActionResult<Mesaj>> GetMesaj(int id)
        {
            var mesaj=await _context.Mesajs.FindAsync(id);
            //Console.WriteLine(mesajs);
            if(mesaj.isRead==1)
            {
                mesaj.isRead=0;
                 _context.Entry(mesaj).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }
            
            return mesaj;
           
        }
        // PO*ST: api/mesaj
        [HttpPost]
        public async Task<ActionResult<Mesaj>> Postuser(Mesaj mesaj)
        {
            _context.Mesajs.Add(mesaj);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMesajs", new { id = mesaj.ID }, mesaj);
        }
       
    }
}