using Microsoft.EntityFrameworkCore;
using EmiPlanner.Api.Models;

namespace EmiPlanner.Api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Loan> Loans { get; set; }
    }
}