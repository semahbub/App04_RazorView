using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App04_RazorView.Models
{
    public class ProductSize
    {
        public int Id { get; set; }
        public string SizeName { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
