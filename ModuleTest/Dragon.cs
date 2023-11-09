using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleTest
{
    public class Dragon : BaseUnit
    {
        protected override void SetData()
        {
            TotalPrice = new List<Currency>
            { 
                new Currency{costType = CostType.Feed, amount = 2},
                new Currency{costType = CostType.Girls, amount = 1},
            };

            Speed = 60;
        }
        public override string ToString()
        {
            return "Дракон";
        }
    }
}
