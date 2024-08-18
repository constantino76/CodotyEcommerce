using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catalog.Domaing;
using Catalog.Persistence.Database.Configuration;
namespace Catalog.Persistence.Database
{
    public class AplicationDbContext:DbContext
    {
        public AplicationDbContext(
            DbContextOptions<AplicationDbContext>options):base(options) { }
        

        public DbSet<Product>ProductsProducts { get; set; } 
        
        public DbSet<ProductInStock> Stocks { get; set; }

        protected override  void OnModelCreating(ModelBuilder builder) { 

            base.OnModelCreating(builder);
            builder.HasDefaultSchema("Catalog");
            ModelConfig(builder);
        }
        private void ModelConfig(ModelBuilder modelBuilder) {


            new ProductConfiguration(modelBuilder.Entity<Product>());
            new ProductInStockConfiguration(modelBuilder.Entity<ProductInStock>());
        }
    }
}
