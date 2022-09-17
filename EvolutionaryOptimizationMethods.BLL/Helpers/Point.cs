using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvolutionaryOptimizationMethods.BLL
{
    public class Point
    {
        public double X { get; }
        public double Y { get; }
        public double? Z { get; set; }

        public Point(double x, double y, double? z = null)
        {
            X = x;
            Y = y;
            Z = z;
        }
    }
}
