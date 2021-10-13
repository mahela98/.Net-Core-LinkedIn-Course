using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using test2.Models;

namespace test2.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ShopContext _context;

        public ProductsController(ShopContext context)
        {
            _context = context;
            _context.Database.EnsureCreated();

        }

        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            return Ok(await _context.Products.ToArrayAsync());

        }

        [HttpGet ("{id:int}")]
        public async Task<IActionResult> GetProduct(int id)
        {
            var product =await _context.Products.FindAsync(id);
            if (product==null)
            {
                return NotFound();
            }
            else
            {
                return Ok(product);
            }
        }





    }
}
