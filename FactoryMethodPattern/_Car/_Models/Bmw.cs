using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern._Car
{
    class Bmw : ICar
    {
        public Bmw()
        {
            
            Logo = "Bmw";
            CarName = "BMW";
            Marketvalue = 15000;
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
