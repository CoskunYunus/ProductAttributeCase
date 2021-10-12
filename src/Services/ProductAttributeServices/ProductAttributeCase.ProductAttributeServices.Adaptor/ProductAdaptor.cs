using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductAttributeCase.ProductAttributeServices.Model.Entity;
using ProductAttributeCase.ProductAttributeServices.Model.ProductModels.Request;
using ProductAttributeCase.ProductAttributeServices.Model.ProductModels.Response;

namespace ProductAttributeCase.ProductAttributeServices.Adaptor
{
    public static class ProductAdaptor
    {
        public static ProductDetailResponseModel ToProductDetailResponseModel(this Product model)
        {
            return new ProductDetailResponseModel
            {
                Id = model.Id,
                Name = model.Name,
                Price = model.Price,
                CategoryName = model?.ProductCategory?.Name,
                ProductAttributes = model.SubProducts.Select(c => new SubProductResponseModel
                {
                    ProductAttributes = c.AttributeOptionMappings?.Select(y => new ProductAttributeResponseModel
                    {
                        AttributeName = y.AttributeOption?.Attribute?.Title,
                        OptionValue = y.AttributeOption?.Name,
                        OptionId = y.AttributeOptionId
                    }).ToList()

                }).ToList(),
            };
        }

        public static Product ToProduct(this ProductAddRequestModel model)
        {
            return new Product
            {
                IsDelete = false,
                Name = model.Name,
                Price = model.Price,
                ProductCategoryId = model.ProductCategoryId,
            };
        }
    }
}
