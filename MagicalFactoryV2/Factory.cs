using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicalFactoryV2
{
    class Factory
    {
        public List<Material> leftovers = new List<Material>();
        public List<Product> factoryProducts = new List<Product>()
        {
            new Product("Car") 
            {
                Blueprint = new List<Material>()
                {
                    new Material("Glass"),
                    new Material("Steel"),
                    new Material("Rubber") 
                }
            },
            new Product("House")
            {
                Blueprint = new List<Material>()
                {
                    new Material("Glass"),
                    new Material("Glass"),
                    new Material("Wood")
                }
            }

        };
        public Factory()
        {

        }
        public List<Material> CreateProduct(List<Material> materials)
        {
            leftovers.AddRange(materials);
            foreach (var product in factoryProducts)
            {
                if(CheckCorrectBlueprint(product, materials) != null)
                {
                    Console.WriteLine("Creating product...");
                    Console.WriteLine(product.ProductType);
                    return leftovers;
                }
            } return null;
        }
        public Product CheckCorrectBlueprint(Product product, List<Material> materials)
        {
            
            foreach (var item in materials)
            {
                for (int i = 0; i < product.Blueprint.Count; i++)
                {
                    if (product.Blueprint[i].MaterialType == item.MaterialType)
                    {
                        ListLeftovers();
                        Console.WriteLine($"found {item.MaterialType} in {product.ProductType} blueprint");
                        leftovers.Remove(item);
                        ListLeftovers();
                    }
                }
                
            }
            return new Product(product.ProductType);
        }
        public void ListLeftovers()
        {
            foreach (var item in leftovers)
            {
                Console.WriteLine(item.MaterialType);
            }
        }
    }
}
