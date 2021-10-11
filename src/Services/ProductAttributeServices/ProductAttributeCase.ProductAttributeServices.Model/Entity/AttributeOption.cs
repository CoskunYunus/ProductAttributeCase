using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductAttributeCase.ProductAttributeServices.Model.Entity.Base;

namespace ProductAttributeCase.ProductAttributeServices.Model.Entity
{
    public class AttributeOption: BaseEntityIdentity
    {
        public string Name { get; set; } // Red, Green, xxl, xl, Male

        public int AttributeId { get; set; }
        public Attribute Attribute { get; set; }
    }
}
