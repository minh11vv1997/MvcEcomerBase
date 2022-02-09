using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EcommerceBase.Websites.Models
{
    public class CategoryViewModel
    {
        //public CategoryViewModel(Guid id, string name, string description, int sort, string url)
        //{
        //    Id = id;
        //    Name = name;
        //    Description = description;
        //    Url = url;
        //    Sort = sort;
        //}
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Sort { get; set; }
        public string Url { get; set; }
    }
}