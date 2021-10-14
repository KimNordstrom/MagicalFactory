using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicalFactoryV2
{
    class Factory
    {
        public List<Material> fromWarehouse = new List<Material>();
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
        public void CreateProduct(List<Material> materials)
        {
            foreach (var product in factoryProducts)
            {
                List<bool> correctChecker = new List<bool>(product.Blueprint.Count) { };

                for (int i = 0; i < product.Blueprint.Count; i++)
                {
                    correctChecker.Add(false);
                }

                foreach (var material in materials)
                {
                    bool found = false;
                    for (int i = 0; i < product.Blueprint.Count; i++)
                    {
                        if (product.Blueprint[i] == material)
                        {
                            if (correctChecker[i] == false)
                            {
                                correctChecker[i] = true;
                                found = true;
                                //amountCorrectMaterials++;
                                break;
                            }
                        }
                    }
                    if (found == false)
                    {
                        leftovers.Add(material);
                    }
                }
            }
        }
    }
}
