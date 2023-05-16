using Microsoft.EntityFrameworkCore;
using WebApplication1.Model;

namespace WebApplication1.dta
{
    public class DbDataContext : DbContext
    {
        public DbDataContext(DbContextOptions<DbDataContext> options) : base(options) { 
        
        }

        public DbSet<Product> products { get; set; }
    }
}
