namespace eCommerce.Models
{
    public class Product_Order
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int OrderId { get; set; }

        //Relationship
        public Order Order{ get; set; }
    }
}
