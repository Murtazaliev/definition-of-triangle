namespace DefinitionOfTriangle.App;

using DefinitionOfTriangle.App.Models;

public class DefinitionOfTriangleService : IDefinitionOfTriangleService
{
    public DefinitionOfTriangleResult DetermineTriangleType(DefinitionOfTriangleRequest request)
    {       

        double[] sides = { request.SideA, request.SideB, request.SideC };
        Array.Sort(sides);


        double a = sides[0];
        double b = sides[1];
        double c = sides[2];

        if (a + b <= c)
        {
            return new DefinitionOfTriangleResult { ResultType = ResultType.IncorrectValues, Description = "Стороны не могут образовать треугольник" };
        }
        else if (a * a + b * b == c * c)
        {
            return new DefinitionOfTriangleResult { ResultType = ResultType.Rectangular, Description = "Треугольник прямоугольный" };
        }
        else
        {
            return new DefinitionOfTriangleResult { ResultType = ResultType.NotRectangular, Description = "Треугольник не прямоугольный" };
        }
    }
}
