using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProductAttributeCase.ProductAttributeServices.Model.Entity;
using Attribute = ProductAttributeCase.ProductAttributeServices.Model.Entity.Attribute;

namespace ProductAttributeCase.ProductAttributeServices.EFBusiness.Context
{
    public class ProductAttributeContext : DbContext, IProductAttributeContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //var connection = _configuration.GetSection("connectionString");
            optionsBuilder.UseSqlServer("Server=localhost;Database=ProductAttributeCaseDb;Trusted_Connection=True;");
        }
        public DbSet<Product> Product { get; set; }
        public DbSet<Attribute> Attribute { get; set; }
        public DbSet<AttributeOption> AttributeOption { get; set; }
        public DbSet<ProductCategory> ProductCategory { get; set; }
        public DbSet<SubProduct> SubProduct { get; set; }
        public DbSet<SubProductAttributeOptionMapping> SubProductAttributeOptionMapping { get; set; }

        public int Save() => SaveChanges();

    }
}
