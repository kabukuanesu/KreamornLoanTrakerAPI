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
    public class PersonalDetailController : ControllerBase
    {
        private readonly PersonalDetailContext _context;

        public PersonalDetailController(PersonalDetailContext context)
        {
            _context = context;
        }

        // GET: api/PersonalDetail
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PersonalDetail>>> GetPersonalDetails()
        {
            return await _context.PersonalDetails.ToListAsync();
        }

        // GET: api/PersonalDetail/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PersonalDetail>> GetPersonalDetail(int id)
        {
            var personalDetail = await _context.PersonalDetails.FindAsync(id);

            if (personalDetail == null)
            {
                return NotFound();
            }

            return personalDetail;
        }

        // PUT: api/PersonalDetail/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPersonalDetail(int id, PersonalDetail personalDetail)
        {
            if (id != personalDetail.PersonalDetailId)
            {
                return BadRequest();
            }

            _context.Entry(personalDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PersonalDetailExists(id))
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

        // POST: api/PersonalDetail
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PersonalDetail>> PostPersonalDetail(PersonalDetail personalDetail)
        {
            _context.PersonalDetails.Add(personalDetail);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPersonalDetail", new { id = personalDetail.PersonalDetailId }, personalDetail);
        }

        // DELETE: api/PersonalDetail/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePersonalDetail(int id)
        {
            var personalDetail = await _context.PersonalDetails.FindAsync(id);
            if (personalDetail == null)
            {
                return NotFound();
            }

            _context.PersonalDetails.Remove(personalDetail);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // POST: api/PersonalDetail/Authenticate
        [HttpPost("Authenticate")]
        public async Task<ActionResult<PersonalDetail>> Authenticate(LoginRequest loginRequest)
        {
            var personalDetail = await _context.PersonalDetails.FirstOrDefaultAsync(p => p.EmailAddress == loginRequest.EmailAddress && p.PersonalPassword == loginRequest.Password);

            if (personalDetail == null)
            {
                return NotFound();
            }

            // You can perform additional authentication checks if needed

            return personalDetail;
        }

        public class LoginRequest
        {
            public string EmailAddress { get; set; }
            public string Password { get; set; }
        }

        private bool PersonalDetailExists(int id)
        {
            return _context.PersonalDetails.Any(e => e.PersonalDetailId == id);
        }
    }
}
