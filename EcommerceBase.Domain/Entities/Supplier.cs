using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceBase.Domain.Entities
{
    public class Supplier: BaseEntity
    {
      
        [Required]
        [MaxLength(256)]
        public Guid Id { get; set; }
        public string Name { get; set; }
        [MaxLength(256)]
        public string Address { get; set; }
        [MaxLength(15)]
        public string Phone { get; set; }
        [MaxLength(50)]
        public string CodeName { get; set; }
        [MaxLength(50)]
        public string Email { get; set; }
    }
}
