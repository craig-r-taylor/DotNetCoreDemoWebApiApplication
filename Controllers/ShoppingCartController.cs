﻿namespace DotNetCoreDemoWebApiApplication.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using DotNetCoreDemoWebApiApplication.Data;
    using DotNetCoreDemoWebApiApplication.Models;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;

    [Route("api/[controller]")]
    [ApiController]
    public class ShoppingCartController : ControllerBase
    {
        private readonly DatabaseContext _context;

        public ShoppingCartController(DatabaseContext context)
        {
            _context = context;
        }

        // GET: api/ShoppingCart
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ShoppingCart>>> GetShoppingCart()
        {
            return await _context.ShoppingCart.ToListAsync();
        }

        // GET: api/ShoppingCart/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ShoppingCart>> GetShoppingCart(int id)
        {
            var shoppingCart = await _context.ShoppingCart.FindAsync(id);

            if (shoppingCart == null)
            {
                return NotFound();
            }

            return shoppingCart;
        }

        // PUT: api/ShoppingCart/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutShoppingCart(int id, ShoppingCart shoppingCart)
        {
            if (id != shoppingCart.ShoppingCartId)
            {
                return BadRequest();
            }

            _context.Entry(shoppingCart).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ShoppingCartExists(id))
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

        // POST: api/ShoppingCart
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ShoppingCart>> PostShoppingCart(ShoppingCart shoppingCart)
        {
            _context.ShoppingCart.Add(shoppingCart);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetShoppingCart", new { id = shoppingCart.ShoppingCartId }, shoppingCart);
        }

        // DELETE: api/ShoppingCart/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteShoppingCart(int id)
        {
            var shoppingCart = await _context.ShoppingCart.FindAsync(id);
            if (shoppingCart == null)
            {
                return NotFound();
            }

            _context.ShoppingCart.Remove(shoppingCart);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ShoppingCartExists(int id)
        {
            return _context.ShoppingCart.Any(e => e.ShoppingCartId == id);
        }
    }
}
