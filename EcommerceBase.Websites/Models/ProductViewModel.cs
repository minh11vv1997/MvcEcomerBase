using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EcommerceBase.Websites.Models
{
    public class ProductViewModel
    {
        public Guid Id { get; set; }
        public string UrlName { get; set; }
        public string Title { get; set; }
        public string Sku { get; set; }
        public DateTime? PublicationDate { get; set; }
        public double? Weight { get; set; }
        public double? Height { get; set; }
    }
}