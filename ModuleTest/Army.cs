using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleTest
{
    public class Army
    {
        public List<IUnit> Units { get; private set; }

        public Army(List<IUnit> units)
        {
            Units = units;
        }
        public void AddUnit(IUnit unit)
        {
            Units.Add(unit);
        }
        public int CalculateTotalGirls()
        {
            return Units.Sum(u => u.GetCost().FirstOrDefault(s => s.costType == CostType.Girls).amount);
        }
        public int CalculateTotalGold()
        {
            return Units.Sum(u => u.GetCost().FirstOrDefault(s => s.costType == CostType.Gold).amount);
        }
        public int CalculateTotalFeed()
        {
            return Units.Sum(u => u.GetCost().FirstOrDefault(s => s.costType == CostType.Feed).amount);
        }

        public int CalculateTotalArrows()
        {
            return Units.Sum(u => u.GetCost().FirstOrDefault(s => s.costType == CostType.Arrows).amount);
        }
        public double CalculateAverageSpeed()
        {
            return Units.Average(u => u.GetSpeed());
        }
    }
}
