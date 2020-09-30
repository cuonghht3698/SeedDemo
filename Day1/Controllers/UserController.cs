using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Day1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly DemoContext _context;

        public UserController(DemoContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<Product>> getAll()
        {
            return await _context.Products.ToListAsync();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Product>> Update(int id, [FromBody] Product product)
        {
            if(id!=product.Id)
            {
                return BadRequest();
            }
            else
            {
                _context.Entry(product).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return Ok("update thanh cong");
            }
        }
    }
}
