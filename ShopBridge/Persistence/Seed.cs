using Domain;
using Microsoft.AspNetCore.Identity;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context, UserManager<User> userManager)
        {
            if(!userManager.Users.Any())
            {
                var users = new List<User>()
                {
                    new User()
                    {
                        DisplayName = "Jasdeep",
                        UserName = "jasdeep",
                        Email="jas@test.com"
                    },
                    new User()
                    {
                        DisplayName = "tom",
                        UserName = "tom",
                        Email="tom@test.com"
                    },
                    new User()
                    {
                        DisplayName = "bob",
                        UserName = "bob",
                        Email="bob@test.com"
                    }
                };

                foreach(var user in users)
                {
                    await userManager.CreateAsync(user, "Pa$$w0rd");
                }
            }
            if (context.Products.Any()) return;

            var products = new List<Product>
            {
                new Product
                {
                    Name = "Mobile",
                    Description = "Electronic Item",
                    Date = DateTime.Now,
                },
                 new Product
                {
                    Name = "Television",
                    Description = "Electronic Item",
                    Date = DateTime.Now,
                }, new Product
                {
                    Name = "SmartPhone",
                    Description = "Electronic Item",
                    Date = DateTime.Now,
                }, new Product
                {
                    Name = "Alexa",
                    Description = "Electronic Item",
                    Date = DateTime.Now,
                }, new Product
                {
                    Name = "Monitor",
                    Description = "Electronic Item",
                    Date = DateTime.Now,
                }, new Product
                {
                    Name = "Laptop",
                    Description = "Electronic Item",
                    Date = DateTime.Now,
                }, new Product
                {
                    Name = "Airpods",
                    Description = "Electronic Item",
                    Date = DateTime.Now,
                }, new Product
                {
                    Name = "Earbuds",
                    Description = "Electronic Item",
                    Date = DateTime.Now,
                }, new Product
                {
                    Name = "Speakers",
                    Description = "Electronic Item",
                    Date = DateTime.Now,
                }, new Product
                {
                    Name = "Monitor",
                    Description = "Electronic Item",
                    Date = DateTime.Now,
                }, new Product
                {
                    Name = "Mouse",
                    Description = "Electronic Item",
                    Date = DateTime.Now,
                }
            };

            await context.Products.AddRangeAsync(products);
            await context.SaveChangesAsync();
        }
    }
}
