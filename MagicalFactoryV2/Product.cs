using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicalFactoryV2
{
    public class Product
    {
        public string ProductType { get; init; }
        public List<Material> Blueprint { get; init; }
        public Product(string type)
        {
            ProductType = type;
        }
    }
}
