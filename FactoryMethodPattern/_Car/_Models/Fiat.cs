using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern._Car
{
    class Fiat : ICar
    {
        public Fiat()
        {
            Logo = "Fiat";
            CarName = "Fiat";
            Marketvalue = 5000;
        }

        public string CarName
        {
            get;

            set;
        }

        public string Logo
        {
            get;

            set;
        }

        public double Marketvalue
        {
            get;

            set;
        }
    }
}
