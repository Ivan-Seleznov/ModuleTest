using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleTest
{
    public enum CostType
    {
        Gold,
        Girls,
        Feed,
        Arrows
    }
    public struct Currency
    {
        public CostType costType;
        public int amount;
    }
}
