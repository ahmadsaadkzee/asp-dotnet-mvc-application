using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
namespace eCommerce.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }

        //Relationships

        public List<Product_Order> Products_Orders { get; set; }
    }
}
