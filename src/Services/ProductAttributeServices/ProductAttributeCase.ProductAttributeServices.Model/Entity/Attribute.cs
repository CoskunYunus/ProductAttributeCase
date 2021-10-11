using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductAttributeCase.ProductAttributeServices.Model.Entity.Base;

namespace ProductAttributeCase.ProductAttributeServices.Model.Entity
{
   public class Attribute: BaseEntityIdentity
    {
        public string Title { get; set; } // Color, Size, Gender
        public ICollection<AttributeOption> AttributeOptions { get; set; }
    }
}
