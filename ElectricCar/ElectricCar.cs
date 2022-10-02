using CarLibrary;
using System;
// xe electric
namespace ElectricCar
{
    public class ElectricCar : Car
    {
        public string Name { get => "Electric"; }

        public Car Clone()
        {
            return new ElectricCar();
        }
        public void Depart()
        {
            Console.WriteLine("Checking battery level");
            Console.WriteLine("ElectricCar is starting");
        }
    }
}
