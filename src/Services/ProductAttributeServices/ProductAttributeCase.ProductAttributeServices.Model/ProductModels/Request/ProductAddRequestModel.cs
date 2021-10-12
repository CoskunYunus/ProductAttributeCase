using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductAttributeCase.ProductAttributeServices.Model.ProductModels.Response;

namespace ProductAttributeCase.ProductAttributeServices.Model.ProductModels.Request
{
    public class ProductAddRequestModel
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int ProductCategoryId { get; set; }
        public List<ProductAttributeResponseModel> ProductAttributes { get; set; }
    }
}
