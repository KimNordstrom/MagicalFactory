using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicalFactoryV2
{
    public class Material
    {
        public string MaterialType { get; init; }
        public Material(string type)
        {
            MaterialType = type;
        }
    }
}
