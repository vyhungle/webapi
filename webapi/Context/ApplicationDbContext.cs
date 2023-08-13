
using Microsoft.EntityFrameworkCore;
using webapi.Model;

namespace webapi.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }

        public DbSet<Product> Test { get; set; }
    }
}