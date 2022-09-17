using EvolutionaryOptimizationMethods.BLL.OptimizationMethods.ConcreteOptimizationMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvolutionaryOptimizationMethods.BLL.OptimizationMethods.Factories
{
    public class GradientDescentOptimizationMethodFactory : OptimizationMethodFactory
    {
        public override IOptimizationMethod GetOptimizationMethod()
        {
            return new GradientDescentOptimizationMethod();
        }
    }
}
