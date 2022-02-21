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
    public class StoreTypeController : ControllerBase
    {
        private readonly foodieContext _context;

        public StoreTypeController(foodieContext context)
        {
            _context = context;
        }

        // GET: api/StoreType
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StoreType>>> GetStoreTypes()
        {
            return await _context.StoreTypes.ToListAsync();
        }

        // GET: api/StoreType/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StoreType>> GetStoreType(int id)
        {
            var storeType = await _context.StoreTypes.FindAsync(id);

            if (storeType == null)
            {
                return NotFound();
            }

            return storeType;
        }

        // PUT: api/StoreType/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStoreType(int id, StoreType storeType)
        {
            if (id != storeType.StoreTypeId)
            {
                return BadRequest();
            }

            _context.Entry(storeType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StoreTypeExists(id))
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

        // POST: api/StoreType
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<StoreType>> PostStoreType(StoreType storeType)
        {
            _context.StoreTypes.Add(storeType);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetStoreType", new { id = storeType.StoreTypeId }, storeType);
        }

        // DELETE: api/StoreType/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStoreType(int id)
        {
            var storeType = await _context.StoreTypes.FindAsync(id);
            if (storeType == null)
            {
                return NotFound();
            }

            _context.StoreTypes.Remove(storeType);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool StoreTypeExists(int id)
        {
            return _context.StoreTypes.Any(e => e.StoreTypeId == id);
        }
    }
}
