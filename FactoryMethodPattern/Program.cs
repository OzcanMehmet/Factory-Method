using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethodPattern._Factory;
namespace FactoryMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            CarFactory Factory = new CarFactory();
            ICar newcar = Factory.GetCar(CarFactory.CarType.Fiat);
            Console.WriteLine("Car Name= " + newcar.CarName);
            Console.WriteLine("Car Logo= " + newcar.Logo);
            Console.WriteLine("Car Market Value = " + newcar.Marketvalue);
            Console.ReadLine();
        }
    }
}
