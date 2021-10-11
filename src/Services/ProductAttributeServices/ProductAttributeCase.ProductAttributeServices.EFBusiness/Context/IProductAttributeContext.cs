using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProductAttributeCase.ProductAttributeServices.Model.Entity;

namespace ProductAttributeCase.ProductAttributeServices.EFBusiness.Context
{
    public interface IProductAttributeContext
    {
        public DbSet<Product> Product { get; set; }
        public DbSet<Model.Entity.Attribute> Attribute { get; set; }
        public DbSet<AttributeOption> AttributeOption { get; set; }
        public DbSet<ProductCategory> ProductCategory { get; set; }
        public DbSet<SubProduct> SubProduct { get; set; }
        public DbSet<SubProductAttributeOptionMapping> SubProductAttributeOptionMapping { get; set; }

        public int Save();
    }
}
