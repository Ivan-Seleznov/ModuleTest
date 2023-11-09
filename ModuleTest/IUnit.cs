using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleTest
{ 
    public interface IUnit
    {
        List<Currency> GetCost();
        double GetSpeed();
    }
}
