using MyShop.Core.Infrastructure.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Core.Models
{
    public class Product : BaseEntity
    {
        

        [StringLength(20)]
        public string Name { get; set; }
        public string Description { get; set; }

        [Range(0, 200)]
        public decimal Price { get; set; }
        public string category { get; set; }
        public string Image { get; set; }

        
    }
}
