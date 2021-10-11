using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using ProductAttributeCase.ProductAttributeServices.Provider.Business;
using ProductAttributeCase.ProductAttributeServices.Service.Product;

namespace ProductAttributeCase.Provider.Register.ProductServices
{
    public class ServicesRegister
    {
        public ServicesRegister(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IProductCatalogService, ProductCatalogService>();
            serviceCollection.AddScoped<IProductService, ProductService>();

        }
    }
}
