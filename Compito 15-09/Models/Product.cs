using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Compito_15_09.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
    }
}