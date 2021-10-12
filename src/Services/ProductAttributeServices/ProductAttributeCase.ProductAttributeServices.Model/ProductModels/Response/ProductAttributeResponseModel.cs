using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAttributeCase.ProductAttributeServices.Model.ProductModels.Response
{
    public class ProductAttributeResponseModel
    {
        public string AttributeName { get; set; }
        public string OptionValue { get; set; }
        public int OptionId { get; set; }
    }
}
