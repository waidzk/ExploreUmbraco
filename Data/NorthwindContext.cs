using ExploreUmbraco.Models;
using Microsoft.EntityFrameworkCore;

namespace ExploreUmbraco.Data
{
    public class NorthwindContext : DbContext
    {
        public NorthwindContext(DbContextOptions<NorthwindContext> options)
            : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        // Tambahkan DbSet lain jika perlu
    }
}
