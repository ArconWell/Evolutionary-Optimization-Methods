using EvolutionaryOptimizationMethods.BLL.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvolutionaryOptimizationMethods.BLL.OptimizationMethods
{
    public interface IOptimizationMethod
    {
        Point FindFunctionMinimum(Point[] functionCoordinates);
        Point FindFunctionMaximum(Point[] functionCoordinates);
    }
}
