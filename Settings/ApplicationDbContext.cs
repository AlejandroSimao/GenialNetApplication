using GenialNetApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace GenialNetApplication.Settings
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var entity = PreferencesDb.GetConnectionModels();
            if (entity != null)
            {
                if(!string.IsNullOrEmpty(entity.UserID) && !string.IsNullOrEmpty(entity.Password))
                    optionsBuilder.UseSqlServer($"Data Source={entity.InitialCatalog};Initial Catalog={entity.DataSource};Persist Security Info=True;User ID={entity.UserID};Password={entity.Password};TrustServerCertificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Supplier>()
                .HasOne<Product>()
                .WithMany()
                .HasForeignKey(o => o.ProductId);
        }
    }
}
