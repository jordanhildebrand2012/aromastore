using System.Text.Json;
using Core.Entities;
using Core.Entities.OrderAggregate;

namespace Infrastructure.Data
{
    public class StoreContextSeed
    {
        public static async Task Seed(StoreContext context)
        {
            if (!context.ProductBrand.Any())
            {
                var seedData = File.ReadAllText("../Infrastructure/Data/SeedData/brands.json");
                var brands = JsonSerializer.Deserialize<List<ProductBrand>>(seedData);
                context.AddRange(brands);
            }

            if (!context.ProductType.Any())
            {
                var seedData = File.ReadAllText("../Infrastructure/Data/SeedData/types.json");
                var types = JsonSerializer.Deserialize<List<ProductType>>(seedData);
                context.AddRange(types);
            }

            if (!context.Products.Any())
            {
                var seedData = File.ReadAllText("../Infrastructure/Data/SeedData/products.json");
                var products = JsonSerializer.Deserialize<List<Product>>(seedData);
                context.AddRange(products);
            }

            if (!context.DeliveryMethods.Any())
            {
                var deliveryData = File.ReadAllText("../Infrastructure/Data/SeedData/delivery.json");
                var methods = JsonSerializer.Deserialize<List<DeliveryMethod>>(deliveryData);
                context.DeliveryMethods.AddRange(methods);
            }

            if (context.ChangeTracker.HasChanges()) await context.SaveChangesAsync();
        }
    }
}