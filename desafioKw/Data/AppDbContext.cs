using desafioKw.Models;
using Microsoft.EntityFrameworkCore;

namespace desafioKw.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)
        {
        }

        public DbSet<Cartao> cartoes { get; set; }
    }
}
