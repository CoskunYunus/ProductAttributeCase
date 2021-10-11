using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductAttributeCase.Core;
using ProductAttributeCase.ProductAttributeServices.Adaptor;
using ProductAttributeCase.ProductAttributeServices.Model.ProductModels.Request;
using ProductAttributeCase.ProductAttributeServices.Model.ProductModels.Response;
using ProductAttributeCase.ProductAttributeServices.Provider.Business;
using ProductAttributeCase.ProductAttributeServices.Provider.Repo;

namespace ProductAttributeCase.ProductAttributeServices.Service.Product
{
    public class ProductService : IProductService
    {
        private readonly IProductRepo _productRepo;
        public ProductService(IProductRepo productRepo)
        {
            _productRepo = productRepo;
        }
        public Task<BaseResponseModel<ProductDetailResponseModel>> GetProduct(int key)
        {
            var product = _productRepo.GetById(key);
            if (product == null)
                return Task.FromResult(new BaseResponseModel<ProductDetailResponseModel>
                {
                    Message = "Product Not Found",
                    Result = false,
                });
            var productModel = product.ToProductDetailResponseModel();
            return Task.FromResult(new BaseResponseModel<ProductDetailResponseModel>
            {
                Data = productModel,
                Result = true,
                StatusCodes = StatusCodes.Ok
            });
        }

        public Task<BaseResponseModel<List<ProductListResponseModel>>> GetProduct(ProductListFilterRequestModel filter)
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponseModel> AddProduct(ProductAddRequestModel model)
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponseModel> UpdateProduct(ProductAddRequestModel model)
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponseModel> DeleteProduct(int key)
        {
            throw new NotImplementedException();
        }
    }
}
