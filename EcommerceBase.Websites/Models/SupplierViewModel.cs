using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EcommerceBase.Websites.Models
{
    public class SupplierViewModel
    {
        //public SupplierViewModel(string Name,string Address, string Phone)
        //{

        //}
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
    }
}