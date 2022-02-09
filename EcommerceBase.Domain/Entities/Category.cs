using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceBase.Domain.Entities
{
    public class Category : BaseEntity
    {
        public Guid Id { get; set; }
        [Required]
        [MaxLength(256)]
        public string Name { get; set; }
        [Required(ErrorMessage ="Ten danh muc ko de trong")]
        [Display]
        public string Description { get; set; }
        public int Sort { get; set; }
        [Required]
        [MaxLength(256)]
        public string Url { get; set; }
        public Guid ParentId { get; set; }
    }
}
