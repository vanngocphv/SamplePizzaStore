using Microsoft.EntityFrameworkCore;
using SampleStoreWebApp.Models;

namespace SampleStoreWebApp.DatabaseContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> opts) : base(opts)
        { }

        public DbSet<PizzaOrder> PizzaOrders { get; set; }
    }
}
