using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using KreamornLoanTrakerAPI.Models;

namespace KreamornLoanTrakerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminDetailController : ControllerBase
    {
        private readonly PersonalDetailContext _context;

        public AdminDetailController(PersonalDetailContext context)
        {
            _context = context;
        }

        // GET: api/AdminDetail
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AdminDetail>>> GetAdminDetails()
        {
            return await _context.AdminDetails.ToListAsync();
        }

        // GET: api/AdminDetail/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AdminDetail>> GetAdminDetail(int id)
        {
            var adminDetail = await _context.AdminDetails.FindAsync(id);

            if (adminDetail == null)
            {
                return NotFound();
            }

            return adminDetail;
        }

        // PUT: api/AdminDetail/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAdminDetail(int id, AdminDetail adminDetail)
        {
            if (id != adminDetail.AdminDetailId)
            {
                return BadRequest();
            }

            _context.Entry(adminDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AdminDetailExists(id))
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

        // POST: api/AdminDetail
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<AdminDetail>> PostAdminDetail(AdminDetail adminDetail)
        {
            _context.AdminDetails.Add(adminDetail);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAdminDetail", new { id = adminDetail.AdminDetailId }, adminDetail);
        }

        // DELETE: api/AdminDetail/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAdminDetail(int id)
        {
            var adminDetail = await _context.AdminDetails.FindAsync(id);
            if (adminDetail == null)
            {
                return NotFound();
            }

            _context.AdminDetails.Remove(adminDetail);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AdminDetailExists(int id)
        {
            return _context.AdminDetails.Any(e => e.AdminDetailId == id);
        }
    }
}
