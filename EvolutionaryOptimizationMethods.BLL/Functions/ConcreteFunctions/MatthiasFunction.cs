using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvolutionaryOptimizationMethods.BLL.Functions.ConcreteFunctions
{
    public class MatthiasFunction : Function
    {
        public override Border BorderX => new Border(-10, 10);

        public override Border BorderY => new Border(-10, 10);

        protected override double CalculateFunction(double x, double y)
        {
            return 0.26 * (x * x + y * y) - 0.48 * x * y;
        }
    }
}
