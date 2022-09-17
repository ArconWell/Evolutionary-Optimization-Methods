using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvolutionaryOptimizationMethods.BLL.Functions
{
    public class BealesFunction : Function
    {
        public override Border BorderX { get; } = new Border(-4.5, 4.5);

        public override Border BorderY { get; } = new Border(-4.5, 4.5);

        protected override double CalculateFunction(double x, double y)
        {
            return Math.Pow((1.5 - x + x * y), 2) + Math.Pow((2.25 - x + x * y * y), 2) +
                Math.Pow((2.625 - x + x * y * y * y), 2);
        }
    }
}
