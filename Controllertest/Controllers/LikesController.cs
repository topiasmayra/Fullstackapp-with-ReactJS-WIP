using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sealgram.Data;
using Sealgram.Models;

namespace Sealgram.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LikesController : ControllerBase
    {
        private readonly SealgramDbContext _context;

        public LikesController(SealgramDbContext context)
        {
            _context = context;
        }

        // GET: api/Likes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Likes>>> GetLikes()
        {
          if (_context.Likes == null)
          {
              return NotFound();
          }
            return await _context.Likes.ToListAsync();
        }

        // GET: api/Likes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Likes>> GetLikes(int id)
        {
          if (_context.Likes == null)
          {
              return NotFound();
          }
            var likes = await _context.Likes.FindAsync(id);

            if (likes == null)
            {
                return NotFound();
            }

            return likes;
        }

        // PUT: api/Likes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLikes(int id, Likes likes)
        {
            if (id != likes.LikeId)
            {
                return BadRequest();
            }

            _context.Entry(likes).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LikesExists(id))
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

        // POST: api/Likes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Likes>> PostLikes(Likes likes)
        {
          if (_context.Likes == null)
          {
              return Problem("Entity set 'SealgramDbContext.Likes'  is null.");
          }
            _context.Likes.Add(likes);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLikes", new { id = likes.LikeId }, likes);
        }

        // DELETE: api/Likes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLikes(int id)
        {
            if (_context.Likes == null)
            {
                return NotFound();
            }
            var likes = await _context.Likes.FindAsync(id);
            if (likes == null)
            {
                return NotFound();
            }

            _context.Likes.Remove(likes);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool LikesExists(int id)
        {
            return (_context.Likes?.Any(e => e.LikeId == id)).GetValueOrDefault();
        }
    }
}
