using Microsoft.EntityFrameworkCore;
using Pronia.Models;

namespace Pronia.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }


        public DbSet<Slider> sliders { get; set; }      
        public DbSet<Category> categories { get; set;  }
        public DbSet<Product> products { get; set;  }           
             
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>()
                .HasMany(c => c.Products)
                .WithOne(x => x.Category)
                .HasForeignKey(a => a.CategoryId);
        }
    }
}
