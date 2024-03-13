using Microsoft.EntityFrameworkCore;

namespace KreamornLoanTrakerAPI.Models
{
    public class PersonalDetailContext : DbContext
    {
        public PersonalDetailContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<PersonalDetail> PersonalDetails { get; set; }
        public DbSet<LoanDetail> LoanDetails { get; set; }
    }
}
