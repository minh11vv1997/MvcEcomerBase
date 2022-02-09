using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceBase.Domain.Entities
{
     public class Manufacturer:BaseEntity
    {
        public string Name { get; set; }
        public string CodeName { get; set; }
        public string Description { get; set; }
        public string Logo { get; set; }
        public Guid SiteId { get; set; }


    }
}
