using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAttributeCase.ProductAttributeServices.Model.Entity.Base
{
   public class BaseEntityIdentity: BaseEntity
    {
        public int Id { get; set; }
        public bool IsDelete { get; set; }
    }
}
