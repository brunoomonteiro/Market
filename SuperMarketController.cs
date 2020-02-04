using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Supermarket.Data;
using Supermarket.Model;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;

namespace Supermarket.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperMarketController : ControllerBase
    {


        private readonly SuperMarketDBContext _context;

        public SuperMarketController(SuperMarketDBContext context)
        {
            _context = context;
        }

        // GET api/supermarket
        [HttpGet]
        [Route("ListProducts")]
        public async Task<IEnumerable<Product>> List()
        {
            return await _context.Product.ToListAsync();
        }


        // POST api/supermarket
        [HttpPost]
        [Route("Add")]
        public async Task<int> Add([FromBody] Product product)
        {
            await _context.Product.AddAsync(product);
            await _context.SaveChangesAsync();
            return product.Code;
        }

        // PUT api/supermarket
        [HttpPut("Update")]
        public async Task<int> Update([FromBody] Product product)
        {
            _context.Product.Update(product);
            await _context.SaveChangesAsync();
            return product.Code;
        }

        // DELETE api/supermarket/5
        [HttpDelete("{code}")]
        public async Task<int> Delete(int code)
        {
            _context.Product.Remove(await _context.Product.FindAsync(code));
            await _context.SaveChangesAsync();
            return code;
        }
    }
}
