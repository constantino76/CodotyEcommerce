using Catalog.Domaing;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Persistence.Database.Configuration
{
    public class ProductInStockConfiguration
    {

        public ProductInStockConfiguration(EntityTypeBuilder<ProductInStock> entityBuilder)
        {

            entityBuilder.HasIndex(x=>x.ProductInStockId);

            //var products = new List<ProductInStock>();
            
            //var random = new Random();
            //for (var i = 2; i < 100; i++)
            //{

            //    products.Add(new ProductInStock
            //    {
            //        ProducInStockId = i,
            //        ProductId = i,
            //        stock = random.Next(0, 20)



            //    });


            //    entityBuilder.HasData(products);
            //}


        }
    }
}
