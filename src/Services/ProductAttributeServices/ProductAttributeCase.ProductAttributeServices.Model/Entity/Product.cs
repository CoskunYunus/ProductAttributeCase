using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductAttributeCase.ProductAttributeServices.Model.Entity.Base;

namespace ProductAttributeCase.ProductAttributeServices.Model.Entity
{
    public class Product: BaseEntityIdentity
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public int ProductCategoryId { get; set; }
        public ProductCategory ProductCategory { get; set; }

        public ICollection<SubProduct> SubProducts { get; set; }
    }
}
