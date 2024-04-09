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
    public class LoanDetailController : ControllerBase
    {
        private readonly PersonalDetailContext _context;

        public LoanDetailController(PersonalDetailContext context)
        {
            _context = context;
        }

        // GET: api/LoanDetail
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LoanDetail>>> GetLoanDetails()
        {
            return await _context.LoanDetails.ToListAsync();
        }

        // GET: api/LoanDetail/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LoanDetail>> GetLoanDetail(int id)
        {
            var loanDetail = await _context.LoanDetails.FindAsync(id);

            if (loanDetail == null)
            {
                return NotFound();
            }

            return loanDetail;
        }

        // PUT: api/LoanDetail/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLoanDetail(int id, LoanDetail loanDetail)
        {
            if (id != loanDetail.LoanDeatailId)
            {
                return BadRequest();
            }

            _context.Entry(loanDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LoanDetailExists(id))
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

        // POST: api/LoanDetail
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<LoanDetail>> PostLoanDetail(LoanDetail loanDetail)
        {
            _context.LoanDetails.Add(loanDetail);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLoanDetail", new { id = loanDetail.LoanDeatailId }, loanDetail);
        }

        // DELETE: api/LoanDetail/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLoanDetail(int id)
        {
            var loanDetail = await _context.LoanDetails.FindAsync(id);
            if (loanDetail == null)
            {
                return NotFound();
            }

            _context.LoanDetails.Remove(loanDetail);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // GET: api/LoanDetail/NationalId/{nationalId}
        [HttpGet("NationalId/{nationalId}")]
        public async Task<ActionResult<IEnumerable<LoanDetail>>> GetLoanDetailsByNationalId(string nationalId)
        {
            var loanDetails = await _context.LoanDetails
                .Where(ld => ld.NationalId == nationalId)
                .ToListAsync();

            if (loanDetails.Count == 0)
            {
                return NotFound();
            }

            return loanDetails;
        }

        private bool LoanDetailExists(int id)
        {
            return _context.LoanDetails.Any(e => e.LoanDeatailId == id);
        }
    }
}
