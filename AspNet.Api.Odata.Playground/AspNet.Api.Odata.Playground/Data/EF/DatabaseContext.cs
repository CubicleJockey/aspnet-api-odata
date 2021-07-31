using AspNet.Api.Odata.Playground.Model;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace AspNet.Api.Odata.Playground.Data.EF
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) 
            : base(options) { }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Product>();

            base.OnModelCreating(builder);
        }
    }
}
