using Catalog.API.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.API.Data
{
    public class CatalogContextSeed
    {
        public static void SeedData(IMongoCollection<Product> productCollection)
        {
            bool existProduct = productCollection.Find(p => true).Any();
            if (!existProduct)
            {
                productCollection.InsertManyAsync(GetMyProducts());
            }
        }

        private static IEnumerable<Product> GetMyProducts()
        {
            return new List<Product>()
            {
                new Product()
                {
                    Id = "64e67d23f9b725966a1ea799",
                    Name = "Iphone X",
                    Description = "Lorem ipsum dolor sit amet. Cum esse laudantium sed veritatis quia sit autem doloremque. Eum consequatur porro in doloremque omnis et iste blanditiis At rerum voluptas ad reiciendis porro in repellendus sint. Sit laborum rerum sit officia nihil et inventore repudiandae ea Quis dolor.",
                    Image = "product-1.png",
                    Price = "950.00M",
                    Category = "Smart Phone"
                },
                new Product()
                {
                    Id = "64e67da0e6a8a428f7dd2f2d",
                    Name = "Smart Watch",
                    Description = "Lorem ipsum dolor sit amet. Cum esse laudantium sed veritatis quia sit autem doloremque. Eum consequatur porro in doloremque omnis et iste blanditiis At rerum voluptas ad reiciendis porro in repellendus sint. Sit laborum rerum sit officia nihil et inventore repudiandae ea Quis dolor.",
                    Image = "product-1.png",
                    Price = "50.00M",
                    Category = "Clockwork"
                },
                new Product()
                {
                    Id = "64e67e30ab9c46419f7f0a56",
                    Name = "Macbook air pro",
                    Description = "Lorem ipsum dolor sit amet. Cum esse laudantium sed veritatis quia sit autem doloremque. Eum consequatur porro in doloremque omnis et iste blanditiis At rerum voluptas ad reiciendis porro in repellendus sint. Sit laborum rerum sit officia nihil et inventore repudiandae ea Quis dolor.",
                    Image = "product-1.png",
                    Price = "850.00M",
                    Category = "Computer"
                },
                new Product()
                {
                    Id = "64e67e3accf7d116b8ec2f41",
                    Name = "Ipad",
                    Description = "Lorem ipsum dolor sit amet. Cum esse laudantium sed veritatis quia sit autem doloremque. Eum consequatur porro in doloremque omnis et iste blanditiis At rerum voluptas ad reiciendis porro in repellendus sint. Sit laborum rerum sit officia nihil et inventore repudiandae ea Quis dolor.",
                    Image = "product-1.png",
                    Price = "90.00M",
                    Category = "Smart Phone"
                }
            };
        }
    }
}
