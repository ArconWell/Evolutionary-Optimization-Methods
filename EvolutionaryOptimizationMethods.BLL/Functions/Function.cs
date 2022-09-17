using EvolutionaryOptimizationMethods.BLL.OptimizationMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EvolutionaryOptimizationMethods.BLL.Functions
{
    public abstract class Function
    {
        private const double FunctionStep = 0.1;
        public abstract Border BorderX { get; }
        public abstract Border BorderY { get; }

        public IOptimizationMethod OptimizationMethod { get; set; }

        public Point FindFunctionMinimum(IOptimizationMethod optimizationMethod = null)
        {
            OptimizationMethod = optimizationMethod;

            if(OptimizationMethod is null)
            {
                throw new Exception("Need to set optimization method previously");
            }

            return OptimizationMethod.FindFunctionMinimum(GetFunctionCoordinates().ToArray());
        }

        public Point FindFunctionMaximum(IOptimizationMethod optimizationMethod = null)
        {
            OptimizationMethod = optimizationMethod;

            if (OptimizationMethod is null)
            {
                throw new Exception("Need to set optimization method previously");
            }

            return OptimizationMethod.FindFunctionMaximum(GetFunctionCoordinates().ToArray());
        }

        protected abstract double CalculateFunction(double x, double y);

        public IEnumerable<Point> GetFunctionCoordinates()
        {
            for (double i = BorderX.LeftBorder; i <= BorderX.RightBorder; i += FunctionStep)
            {
                for (double j = BorderY.LeftBorder; j<=BorderY.RightBorder; j += FunctionStep)
                {
                    Point point = new Point(i, j);
                    point.Z = CalculateFunction(i, j);
                    yield return point;
                }
            }
        }
    }
}
