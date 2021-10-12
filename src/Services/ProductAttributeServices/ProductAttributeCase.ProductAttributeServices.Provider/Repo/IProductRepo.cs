using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductAttributeCase.ProductAttributeServices.Model.Entity;
using ProductAttributeCase.ProductAttributeServices.Provider.Repo.Base;

namespace ProductAttributeCase.ProductAttributeServices.Provider.Repo
{
    public interface IProductRepo: IBaseRepo
    {
        Product GetById(int id);
        void Add(Product product);
        void AddSubProduct(SubProduct subProduct);
        void SetAttribute(int subProductId, List<int> optionIds);
    }
}
