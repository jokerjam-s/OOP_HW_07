using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoStorage.Data
{
    internal class Oils : ACargo, ICost, IMetrics<double>
    {
        private DateTime start;
        private DateTime end;
        private double cost;
        private double metrics;
        
        public Oils() { }

        public DateTime Start { get { return start; } set { start = value; } }

        public DateTime End { get { return end; } set { end = value; } }

        public void CalcCost(DateTime start, DateTime end, double price)
        {
            throw new NotImplementedException();
        }

        public double GetCost()
        {
            return cost;
        }

        public double GetMetrics()
        {
            return metrics;
        }

        public void SetMetrics(double value)
        {
            metrics = value;
        }
    }
}
