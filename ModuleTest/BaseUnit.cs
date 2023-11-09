using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleTest
{
    public abstract class BaseUnit : IUnit
    {
        public BaseUnit()
        {
            TotalPrice = new List<Currency>();
            SetData();
        }
        public List<Currency> TotalPrice { get; protected set; }
        public double Speed { get; protected set; }
        protected abstract void SetData();        
        public double GetSpeed()
        {
            return Speed;
        }

        List<Currency> IUnit.GetCost()
        {
            return TotalPrice;
        }
    }
}
