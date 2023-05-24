using Microsoft.EntityFrameworkCore;

namespace Outlay_Tracker.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions options):base(options)
        {
            // Constructor that receives DbContextOptions and passes them to the base DbContext class
        }
        // Represents a collection of Transaction entities in the database
        public DbSet<Transaction> Transactions { get; set; }
        // Represents a collection of Category entities in the database
        public DbSet<Category> Categories { get; set; }
    }
}
