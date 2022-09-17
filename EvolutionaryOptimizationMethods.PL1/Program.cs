using EvolutionaryOptimizationMethods.BLL;
using EvolutionaryOptimizationMethods.BLL.Functions;
using EvolutionaryOptimizationMethods.BLL.Functions.Factories;
using EvolutionaryOptimizationMethods.BLL.OptimizationMethods;
using EvolutionaryOptimizationMethods.BLL.OptimizationMethods.Factories;
using System;
using System.Linq;

public class Program
{
    static void Main()
    {
        FunctionFactory functionFactory = GetFunctionFactory("BEALES");
        Function function = functionFactory.GetFunction();
        Point[] functionCoordinates = function.GetFunctionCoordinates().ToArray();
        DrawFunction(functionCoordinates);

        OptimizationMethodFactory optimizationMethodFactory = GetOptimizationMethodFactory("GRADIENT_DESCENT");
        IOptimizationMethod optimizationMethod = optimizationMethodFactory.GetOptimizationMethod();
        function.OptimizationMethod = optimizationMethod;
        Point functionMinimum = function.FindFunctionMinimum();
    }

    private static OptimizationMethodFactory GetOptimizationMethodFactory(string optimizationMethodType)
    {
        return optimizationMethodType.ToUpper() switch
        {
            "GRADIENT_DESCENT" => new GradientDescentOptimizationMethodFactory(),
            _ => throw new ArgumentException()
        };
    }

    private static FunctionFactory GetFunctionFactory(string functionType)
    {
        return functionType.ToUpper() switch
        {
            "BEALES" => new BealesFunctionFactory(),
            "MATTHIAS" => new MatthiasFunctionFactory(),
            _ => throw new ArgumentException()
        };
    }

    private static void DrawFunction(Point[] coordinates)
    {
        throw new NotImplementedException();
    }
}
