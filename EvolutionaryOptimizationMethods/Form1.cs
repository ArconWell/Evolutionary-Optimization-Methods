using EvolutionaryOptimizationMethods.BLL;
using EvolutionaryOptimizationMethods.BLL.Functions;
using EvolutionaryOptimizationMethods.BLL.Functions.Factories;
using System;
using System.Linq;

public class Program
{
    static void Main()
    {
        FunctionFactory factory = GetFactory("BEALES");
        Function function = factory.GetFunction();
        Point[] functionCoordinates = function.GetFunctionCoordinates().ToArray();
    }

    private static FunctionFactory GetFactory(string functionType)
    {
        switch (functionType.ToUpper())
        {
            case "BEALES": return new BealesFunctionFactory();
            default: throw new ArgumentException();
        }
    }
}