using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAttributeCase.ProductAttributeServices.Model.ProductModels.Response
{
    public class ProductDetailResponseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string CategoryName { get; set; }
        public List<SubProductResponseModel> ProductAttributes { get; set; }
    }

    public class SubProductResponseModel
    {
        public List<ProductAttributeResponseModel> ProductAttributes { get; set; }

    }
  
}
