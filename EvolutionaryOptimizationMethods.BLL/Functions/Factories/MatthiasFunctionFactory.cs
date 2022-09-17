using EvolutionaryOptimizationMethods.BLL.Functions.ConcreteFunctions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvolutionaryOptimizationMethods.BLL.Functions.Factories
{
    public class MatthiasFunctionFactory : FunctionFactory
    {
        public override Function GetFunction()
        {
            return new MatthiasFunction();
        }
    }
}
