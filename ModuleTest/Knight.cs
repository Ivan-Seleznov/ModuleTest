using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleTest
{
    public class Knight : BaseUnit
    {
        protected override void SetData()
        {
            TotalPrice = new List<Currency>();
            TotalPrice.Add(new Currency { costType = CostType.Gold, amount = 2 });
            Speed = 5;
        }
        public override string ToString()
        {
            return "Рейтар у важкій броні";
        }
    }
}
