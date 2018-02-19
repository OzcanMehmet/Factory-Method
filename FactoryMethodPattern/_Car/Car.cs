using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    interface ICar
    {
        double   Marketvalue { get; set; }
        string   CarName     { get; set; }
        string   Logo        { get; set; }
        

    }
}
