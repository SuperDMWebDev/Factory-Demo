using CarLibrary;
using System;
// xe flying
namespace FlyingCar
{
    public class FlyingCar : Car
    {
        public string Name { get => "Flying"; }
        public Car Clone()
        {
            return new FlyingCar();
        }
        public void Depart()
        {
            Console.WriteLine("Checking fuel exist");
            Console.WriteLine("Checking Wind Direction And Can it flying");
            Console.WriteLine("FlyingCar is starting");
        }
    }
}
