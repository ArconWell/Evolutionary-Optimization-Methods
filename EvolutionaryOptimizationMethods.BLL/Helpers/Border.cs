using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvolutionaryOptimizationMethods.BLL
{
    public class Border
    {
        public double LeftBorder { get; }
        public double RightBorder { get; }

        public Border(double leftBorder, double rightBorder)
        {
            LeftBorder = leftBorder;
            RightBorder = rightBorder;
        }
    }
}
