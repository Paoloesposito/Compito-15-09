using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Compito_15_09.Models
{
    public static class Cart
    {
        public static List<Product> Products { get; } = new List<Product>();

        public static int ProductCount => Products.Count;

        public static decimal Total => Products.Sum(p => p.Price);
    }
}