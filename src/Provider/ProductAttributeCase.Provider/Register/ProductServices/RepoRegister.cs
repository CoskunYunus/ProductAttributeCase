using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using ProductAttributeCase.ProductAttributeServices.EFBusiness.Context;
using ProductAttributeCase.ProductAttributeServices.EFBusiness.Repo;
using ProductAttributeCase.ProductAttributeServices.Provider.Repo;

namespace ProductAttributeCase.Provider.Register.ProductServices
{
    public class RepoRegister
    {
        public RepoRegister(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IProductAttributeContext, ProductAttributeContext>();
            serviceCollection.AddScoped<IAttributeRepo, AttributeRepo>();
            serviceCollection.AddScoped<IProductCategoryRepo, ProductCategoryRepo>();
            serviceCollection.AddScoped<IProductRepo, ProductRepo>();
            serviceCollection.AddScoped<ISubProductRepo, SubProductRepo>();

        }

    }
}
