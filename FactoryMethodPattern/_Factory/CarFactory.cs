using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethodPattern._Car;

namespace FactoryMethodPattern._Factory
{
    class CarFactory
    {
        public enum CarType {Bmw,Fiat }
        public ICar GetCar(CarType Type)
        {
            switch(Type)
            {
                case CarType.Bmw :   return new Bmw();
                case CarType.Fiat:   return new Fiat();
                default          :   return null;
            }
        }
    }
}
