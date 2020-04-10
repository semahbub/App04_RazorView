using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App04_RazorView.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Unit { get; set; }
        public double Price { get; set; }
        public double Quantity { get; set; }
        public List<ProductColor> ProductColor { get; set; }
        public List<ProductSize> ProductSize { get; set; }
    }
}
