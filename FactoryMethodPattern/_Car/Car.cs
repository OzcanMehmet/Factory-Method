using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    abstract class ICar
    {
        public  ICar(double value)
        {
            Marketvalue = value;
        }
        public             double   Marketvalue { get; protected set; }
        public             string   CarName     { get; protected set; }
        public             string   Logo        { get; protected set; }
        

    }
}
