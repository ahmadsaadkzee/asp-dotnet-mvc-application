using eCommerce.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


using System.Linq;
using System.Threading.Tasks;

namespace eCommerce.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
        public decimal Price { get; set; }
        public ProductCategory ProductCategory { get; set; }
        public int Stock { get; set; }


        //Relationships

        public List<Product_Order> Products_Orders { get; set; }



    }
}
