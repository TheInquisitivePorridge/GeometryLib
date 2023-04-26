using System;
using Geometry;
namespace Geometry.Test;

public class TriangleTest
{
    [Theory]
    [InlineData(3,4,5,6)]
    [InlineData(4,7,8,13.997767679169419)]
    public void Triangle_GetArea_ReturnsCorrectValue_Positive(double value1, double value2, double value3, double result)
    {
        var triangle = FigureFactory.CreateTriangle(value1,value2,value3);
        double actualArea = triangle.GetArea();
        Assert.Equal(result, actualArea);
    }
    [Theory]
    [InlineData(9,16,25,0)]
    public void Triangle_GetArea_InsertUncorrectValue_Negative(double value1, double value2, double value3, double result)
    {
        var triangle = FigureFactory.CreateTriangle(value1,value2,value3);
        double actualArea = triangle.GetArea();
        Assert.Equal(result, actualArea);
    }

    [Theory]
    [InlineData(3,4,5)]
    [InlineData(55,48,73)]
    [InlineData(11,60,61)]
    public void Triangle_IsRightAngle_ReturnsTrue(double value1, double value2, double value3)
    {
        dynamic triangle = FigureFactory.CreateTriangle(value1,value2,value3);
        Assert.True(triangle.IsRightTriangle());
    }

    [Theory]
    [InlineData(3,4,6)]
    [InlineData(55,48,71)]
    [InlineData(11,60,68)]
    public void Triangle_IsRightAngle_ReturnsFalse_Negative(double value1, double value2, double value3)
    {
        dynamic triangle = FigureFactory.CreateTriangle(value1,value2,value3);
        Assert.False(triangle.IsRightTriangle());
    }

}
