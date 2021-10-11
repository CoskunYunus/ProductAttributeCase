using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductAttributeCase.Core;
using ProductAttributeCase.ProductAttributeServices.Model.ProductModels.Request;
using ProductAttributeCase.ProductAttributeServices.Model.ProductModels.Response;
using ProductAttributeCase.ProductAttributeServices.Provider.Business.Base;

namespace ProductAttributeCase.ProductAttributeServices.Provider.Business
{
    public interface IProductService : IBaseService
    {
        Task<BaseResponseModel<LinkedList<ProductDetailResponseModel>>> GetProduct(int key);
        Task<BaseResponseModel<LinkedList<ProductListResponseModel>>> GetProduct(ProductListFilterRequestModel filter);
        Task<BaseResponseModel> AddProduct(ProductAddRequestModel model);
        Task<BaseResponseModel> UpdateProduct(ProductAddRequestModel model);
        Task<BaseResponseModel> DeleteProduct(int key);
    }
}
