using PharmacyProjectPhase2.Models;
using Microsoft.EntityFrameworkCore;

namespace PharmacyProjectPhase2.Data
{
    public class PharmacyDbContext:DbContext
    {
        public PharmacyDbContext(DbContextOptions<PharmacyDbContext>options):base(options)
            { 

        }
        public DbSet<Medicines> Medicines { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
