using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProductAttributeCase.ProductAttributeServices.EFBusiness.Context;
using ProductAttributeCase.ProductAttributeServices.Model.Entity;
using ProductAttributeCase.ProductAttributeServices.Provider.Repo;

namespace ProductAttributeCase.ProductAttributeServices.EFBusiness.Repo
{
    public class ProductRepo : IProductRepo
    {
        private IProductAttributeContext _context;

        public ProductRepo(IProductAttributeContext context)
        {
            _context = context;
        }
        public Product GetById(int id)
        {
            return _context.Product
                .Include(c => c.ProductCategory)
                .Include(c => c.SubProducts)
                .FirstOrDefault(c => c.IsDelete == false && c.Id == id);
        }

        public void Add(Product product)
        {
            _context.Product.Add(product);
            _context.Save();
        }

        public void AddSubProduct(SubProduct subProduct)
        {
            _context.SubProduct.Add(subProduct);
            _context.Save();
        }

        public void SetAttribute(int subProductId, List<int> optionIds)
        {
            var addOptionsMapping = optionIds.Select(c => new SubProductAttributeOptionMapping
            {
                AttributeOptionId = c,
                SubProductId = subProductId
            }).ToList();
            _context.SubProductAttributeOptionMapping.AddRange(addOptionsMapping);
            _context.Save();
        }
    }
}
