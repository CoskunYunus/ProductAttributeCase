using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductAttributeCase.ProductAttributeServices.Model.Entity.Base;

namespace ProductAttributeCase.ProductAttributeServices.Model.Entity
{
    public class SubProduct : BaseEntityIdentity
    {
        public string Slug { get; set; }
        public string MetaTitle { get; set; }
       
        //
        //....
        //

        public ICollection<SubProductAttributeOptionMapping> AttributeOptionMappings { get; set; }
    }
}
