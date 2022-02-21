#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Foodie360.Models;

namespace Foodie360.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductTypeController : ControllerBase
    {
        private readonly foodieContext _context;

        public ProductTypeController(foodieContext context)
        {
            _context = context;
        }

        // GET: api/productType
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductType>>> GetProductTypes()
        {
            return await _context.ProductTypes.ToListAsync();
        }

        // GET: api/productType/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductType>> GetProductType(int id)
        {
            var productType = await _context.ProductTypes.FindAsync(id);

            if (productType == null)
            {
                return NotFound();
            }

            return productType;
        }

        // PUT: api/productType/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProductType(int id, ProductType productType)
        {
            if (id != productType.TypeId)
            {
                return BadRequest();
            }

            _context.Entry(productType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductTypeExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/productType
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ProductType>> PostProductType(ProductType productType)
        {
            _context.ProductTypes.Add(productType);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProductType", new { id = productType.TypeId }, productType);
        }

        // DELETE: api/productType/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProductType(int id)
        {
            var productType = await _context.ProductTypes.FindAsync(id);
            if (productType == null)
            {
                return NotFound();
            }

            _context.ProductTypes.Remove(productType);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProductTypeExists(int id)
        {
            return _context.ProductTypes.Any(e => e.TypeId == id);
        }
    }
}
