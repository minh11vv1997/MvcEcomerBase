using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceBase.Domain.Entities
{
    public class Product:BaseEntity
    {
        public Guid Id { get; set; }
        public string UrlName { get; set; }

        public string Title { get; set; }
        public string Sku { get; set; }
        public DateTime? PublicationDate { get; set; }
        public decimal Price { get; set; }
        public int View { get; set; }
        public string Keyword { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public string Description { get; set; }
        public string ShortDescription { get; set; }
        public double? Weight { get; set; }
        public double? Height { get; set; }
        public double? Width { get; set; }
        public double? Depth { get; set; }
        public Guid? SiteId { get; set; }

        // Tao Khoa ngoai.

        public virtual ICollection<Category> Categories { get; set; }

        public virtual ICollection<Supplier> Suppliers { get; set; }


        #region Relation

        #endregion
    }
}
