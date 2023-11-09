using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleTest
{
    public class Archer : BaseUnit
    {
        protected override void SetData()
        {
            TotalPrice = new List<Currency>
            { 
                new Currency{costType = CostType.Arrows, amount = 10},
                new Currency{costType = CostType.Gold, amount = 1},
            };

            Speed = 7;
        }
        public override string ToString()
        {
            return "Лучник";
        }
    }
}
