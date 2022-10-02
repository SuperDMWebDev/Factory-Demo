//19120588
using CarLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace FactoryDemo
{
    class CarFactory
    {
        List<Car> _prototypes;

        public CarFactory()
        {
            _prototypes = new List<Car>();

      
            string exePath = Assembly.GetExecutingAssembly().Location;
            string folder = Path.GetDirectoryName(exePath);
            var fis = new DirectoryInfo(folder).GetFiles("*.dll");

       
            foreach (var f in fis) 
            {
                var assembly = Assembly.LoadFile(f.FullName);
                var types = assembly.GetTypes();

                foreach (var t in types)
                {
                    if (t.IsClass && typeof(Car).IsAssignableFrom(t))
                    {
                        Car c = (Car)Activator.CreateInstance(t);
                        _prototypes.Add(c);
                    }
                }
            }
        }

        public Car Create(int choice)
        {
            Car result = _prototypes[choice - 1].Clone();
            return result;
        }

        public void DisplayMenu()
        {
            for (int i = 0; i < _prototypes.Count; i++)
            {
                Car car = _prototypes[i];
                Console.WriteLine($"{i + 1}. {car.Name}");
            }
        }
    }
    class Program
    {
        static void Main()
        {
          
            CarFactory factory = new CarFactory();
            Console.WriteLine("Which car do you want to create?");
            factory.DisplayMenu();

            int choice = int.Parse(Console.ReadLine());

            Car c1 = factory.Create(choice);
            c1.Depart();

            Console.ReadLine();
        }
    }
}
