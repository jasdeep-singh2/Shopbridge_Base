using Domain;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)
        {
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
