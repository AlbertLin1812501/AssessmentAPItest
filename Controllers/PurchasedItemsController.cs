using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PurchasedItemsController : ControllerBase
    {
        private readonly PurchasedItemContext _context;

        public PurchasedItemsController(PurchasedItemContext context)
        {
            _context = context;
        }

        // GET: api/PurchasedItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PurchasedItem>>> GetPruchasedItems()
        {
            return await _context.PruchasedItems.ToListAsync();
        }

        // GET: api/PurchasedItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PurchasedItem>> GetPurchasedItem(double id)
        {
            var purchasedItem = await _context.PruchasedItems.FindAsync(id);

            if (purchasedItem == null)
            {
                return NotFound();
            }

            return purchasedItem;
        }

        // PUT: api/PurchasedItems/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPurchasedItem(double id, PurchasedItem purchasedItem)
        {
            if (id != purchasedItem.PurchasedItemId)
            {
                return BadRequest();
            }

            _context.Entry(purchasedItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PurchasedItemExists(id))
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

        // POST: api/PurchasedItems
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<PurchasedItem>> PostPurchasedItem(PurchasedItem purchasedItem)
        {
            _context.PruchasedItems.Add(purchasedItem);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (PurchasedItemExists(purchasedItem.PurchasedItemId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetPurchasedItem", new { id = purchasedItem.PurchasedItemId }, purchasedItem);
        }

        // DELETE: api/PurchasedItems/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<PurchasedItem>> DeletePurchasedItem(double id)
        {
            var purchasedItem = await _context.PruchasedItems.FindAsync(id);
            if (purchasedItem == null)
            {
                return NotFound();
            }

            _context.PruchasedItems.Remove(purchasedItem);
            await _context.SaveChangesAsync();

            return purchasedItem;
        }

        private bool PurchasedItemExists(double id)
        {
            return _context.PruchasedItems.Any(e => e.PurchasedItemId == id);
        }
    }
}
