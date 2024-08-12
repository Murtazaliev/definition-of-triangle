using DefinitionOfTriangle.App;
using DefinitionOfTriangle.App.Models;

namespace DefinitionOfTriangle.Test;

public class DefinitionOfTriangleTest
{
    private readonly DefinitionOfTriangleService _definitionOfTriangleService;
    public DefinitionOfTriangleTest()
    {
        _definitionOfTriangleService = new DefinitionOfTriangleService();
    }
    [Fact]
    public void DetermineTriangleType_Equilateral_ReturnsRectangular()
    {
        // Arrange
        var triangle = new DefinitionOfTriangleRequest
        {
            SideA = 3,
            SideB = 4,
            SideC = 5
        };

        // Act
        var result = _definitionOfTriangleService.DetermineTriangleType(sut);

        // Assert
        Assert.Equal(ResultType.Rectangular, result.ResultType);
    }

    [Fact]
    public void DetermineTriangleType_Equilateral_ReturnsNotRectangular()
    {
        // Arrange
        var triangle = new DefinitionOfTriangleRequest
        {
            SideA = 10,
            SideB = 10,
            SideC = 10
        };

        // Act
        var result = _definitionOfTriangleService.DetermineTriangleType(sut);

        // Assert
        Assert.Equal(ResultType.NotRectangular, result.ResultType);
    }

    [Fact]
    public void DetermineTriangleType_Equilateral_ReturnsIncorrectValues()
    {
        // Arrange
        var triangle = new DefinitionOfTriangleRequest
        {
            SideA = 10,
            SideB = 10,
            SideC = 30
        };

        // Act
        var result = _definitionOfTriangleService.DetermineTriangleType(sut);

        // Assert
        Assert.Equal(ResultType.IncorrectValues, result.ResultType);
    }
}
