using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace eCommerce.Models
{
    public class User
    {
        
        [Key]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string ProfilePic { get; set; }

        public string Address { get; set; }

        //Relationships
        public List<Order> Orders { get; set; }
        public List<Product> Products { get; set; }

    }
}

