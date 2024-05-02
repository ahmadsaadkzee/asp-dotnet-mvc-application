using eCommerce.Models;

namespace eCommerce.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();

                //Users
                if (!context.Users.Any())
                {
                    context.Users.AddRange(new List<User>()
                    {
                        new User()
                        {
                            Username = "ahmad123",
                            ProfilePic = "https://drive.google.com/file/d/1JWToM3MBe-APNbax24MR-SYXPh6J3sJ0/view?usp=sharing",
                            Email = "ahmad123@gmail.com",
                            Address = "Lahore"

                        },
                        new User()
                        {
                            Username = "saad123",
                            ProfilePic = "https://drive.google.com/file/d/1cUc2N4PCbEPCUhKO6R84QSRAFZOj82Gc/view?usp=sharing",
                            Email = "saad123@gmail.com",
                            Address = "Multan"
                        },
                        new User()
                        {
                            Username = "ghalib123",
                            ProfilePic = "https://drive.google.com/file/d/1FzKcGfXcgTO18CSnOSwoIXXrcbMf5v2d/view?usp=sharing",
                            Email = "ghalib123@gmail.com",
                            Address = "Dera Ghazi Khan"
                        },

                    });
                    context.SaveChanges();
                }
                //Products
                if (!context.Products.Any())
                {
                    context.Products.AddRange(new List<Product>()
                    {
                        new Product()
                        {
                            Name = "Men Hoodie",
                            Price = 3500,
                            ImageURL = "https://drive.google.com/file/d/14vP5LlvEp1jPZ8xNCYnqd9liCoX3vzsP/view?usp=sharing",
                            Description = "This is the description of the first product",
                            ProductCategory = Enums.ProductCategory.Hoodie,
                            Stock = 15
                        },
                        new Product()
                        {
                            Name = "SILK LAWN STITCHED",
                            Price = 8055,
                            ImageURL = "https://drive.google.com/file/d/1TZJe8CSPw5p60JCfut05IHxR7K9qg2UC/view?usp=sharing",
                            Description = "This is the description of the first product",
                            ProductCategory = Enums.ProductCategory.Pret,
                            Stock = 20
                        },
                        new Product()
                        {
                            Name = "KARANDI EMBROIDERED SHAWL",
                            Price = 6950,
                            ImageURL = "https://drive.google.com/file/d/19R7hf9SSPnmf-2ajDrspvSSbXDaXvv-I/view?usp=sharing",
                            Description = "This is the description of the first product",
                            ProductCategory = Enums.ProductCategory.Shawl,
                            Stock = 25
                        }
                        ,
                    });

                    context.SaveChanges();
                }
                //Orders
                if (!context.Orders.Any())
                {

                }
                //Products and Orders
                if (!context.Product_Orders.Any())
                {

                }

            }

        }



    }
}


