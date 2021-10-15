using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicalFactoryV2
{
    class Warehouse
    {
        public List<Material> wInventory = new List<Material>()
        {
            new Material("Steel"),
            new Material("Steel"),
            new Material("Wood"),
            new Material("Rubber"),
            new Material("Glass"),
            new Material("Glass"),
        };
        public List<Material> wTruck = new List<Material>();
        public Warehouse()
        {

        }

        public void ListInventory()
        {
            Console.WriteLine("Inventory");
            Console.WriteLine("---------------------------");
            foreach (var item in wInventory)
            {
                Console.WriteLine(item.MaterialType);
            }
            Console.WriteLine("---------------------------");
        }
        public void ListTruck()
        {
            if(wTruck.Count > 0)
            {
                Console.WriteLine("Truck");
                Console.WriteLine("---------------------------");
                foreach (var item in wTruck)
                {
                    Console.WriteLine(item.MaterialType);
                }
                Console.WriteLine("---------------------------");
            }  
        }
        public void AddToTruck(string material)
        {
            foreach (var item in wInventory)
            {
                if(material.ToLower() == item.MaterialType.ToLower())
                {
                    wInventory.Remove(item);
                    wTruck.Add(new Material($"{item.MaterialType}"));
                    break;
                }
            }
        }
        public void AddToInventory(List<Material> materials)
        {
            foreach (var item in wInventory)
            {
                wInventory.Add(item);
            }
        }
    }
}
