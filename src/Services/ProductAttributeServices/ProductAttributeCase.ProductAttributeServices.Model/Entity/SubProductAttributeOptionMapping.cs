using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductAttributeCase.ProductAttributeServices.Model.Entity.Base;

namespace ProductAttributeCase.ProductAttributeServices.Model.Entity
{
    public class SubProductAttributeOptionMapping:BaseEntity
    {
        [Key]
        public int   SubProductId{ get; set; }
        public SubProduct   SubProduct{ get; set; }

        [Key]
        public int AttributeOptionId { get; set; }
        public AttributeOption AttributeOption { get; set; }
    }
}
