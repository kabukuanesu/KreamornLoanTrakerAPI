using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;

namespace KreamornLoanTrakerAPI.Models
{
    public class PersonalDetailContext : DbContext
    {
        public PersonalDetailContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<PersonalDetail> PersonalDetails { get; set; }
        public DbSet<LoanDetail> LoanDetails { get; set; }
        public DbSet<AdminDetail> AdminDetails { get; set; }
    }
}
