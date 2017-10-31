using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern._Car
{
    class Bmw : ICar
    {
        public Bmw(double value):base(value)
        {
            
            Logo = "Bmw";
            CarName = "BMW";
        }
  
    }
}
