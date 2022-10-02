using CarLibrary;
using System;
//xe gasoline
namespace GasolineCar
{
    public class GasolineCar : Car
    {
        public string Name { get => "Gasoline"; }

        public void Depart()
        {
            Console.WriteLine("Checking gasoline level");
            Console.WriteLine("GasolineCar is starting");
        }

        public Car Clone()
        {
            return new GasolineCar();
        }
    }
}
