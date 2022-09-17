using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvolutionaryOptimizationMethods.BLL.Functions.Factories
{
    public abstract class FunctionFactory
    {
        public abstract Function GetFunction();
    }
}
