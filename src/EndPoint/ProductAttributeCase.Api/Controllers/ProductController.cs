using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductAttributeCase.Core;
using ProductAttributeCase.ProductAttributeServices.Model.ProductModels.Request;
using ProductAttributeCase.ProductAttributeServices.Model.ProductModels.Response;
using ProductAttributeCase.ProductAttributeServices.Provider.Business;
using StatusCodes = ProductAttributeCase.Core.StatusCodes;

namespace ProductAttributeCase.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("Get")]
        public Task<BaseResponseModel<LinkedList<ProductDetailResponseModel>>> GetDetail(int key) => key > 0
            ? _productService.GetProduct(key)
            : Task.FromResult(new BaseResponseModel<LinkedList<ProductDetailResponseModel>>
            {
                Message = "Is Not Validation",
                Result = false,
                StatusCodes = StatusCodes.Error
            });

        [HttpGet("GetAll")]
        public Task<BaseResponseModel<LinkedList<ProductListResponseModel>>> GetAll(ProductListFilterRequestModel filter)
        {
            ///... is validaiton conroller
            return _productService.GetProduct(filter);
        }

        [HttpPost("Add")]
        public Task<BaseResponseModel> Add(ProductAddRequestModel model)
        {
            ///... is validaiton conroller
            return _productService.AddProduct(model);
        }

        [HttpPut("Update")]
        public Task<BaseResponseModel> Update(ProductAddRequestModel model)
        {
            ///... is validaiton conroller
            return _productService.UpdateProduct(model);
        }
        
        [HttpDelete("Delete")]
        public Task<BaseResponseModel> Delete(int key)
        {
            ///... is validaiton conroller
            return _productService.DeleteProduct(key);
        }

    }
}
