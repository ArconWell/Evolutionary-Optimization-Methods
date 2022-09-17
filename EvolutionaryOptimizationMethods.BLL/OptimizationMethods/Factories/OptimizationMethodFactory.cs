using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvolutionaryOptimizationMethods.BLL.OptimizationMethods.Factories
{
    public abstract class OptimizationMethodFactory
    {
        public abstract IOptimizationMethod GetOptimizationMethod();
    }
}
