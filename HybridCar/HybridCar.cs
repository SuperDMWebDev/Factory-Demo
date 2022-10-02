using CarLibrary;
using System;
// xe hibrrid
namespace HybridCar
{
    public class HybridCar : Car
    {
        public string Name { get => "Hybrid"; }

        public void Depart()
        {
            Console.WriteLine("Checking battery level...");
            Console.WriteLine("Checking gasoline level...");
            Console.WriteLine("HybridCar is starting");
        }

        public Car Clone()
        {
            return new HybridCar();
        }
    }
}
