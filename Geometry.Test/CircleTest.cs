using System;
using Geometry;
namespace Geometry.Test;

public class CircleTest
{
    [Theory]
    [InlineData(3)]
    [InlineData(2)]
    [InlineData(10)]
    [InlineData(Double.MaxValue)]
    [InlineData(Double.MinValue)]
    public void Circle_GetArea_ReturnsCorrectValue_Positive(double value1)
    {
        var circle = FigureFactory.CreateCircle(value1);
        double expectedArea = Math.PI * value1 * value1;
        double actualArea = circle.GetArea();
        Assert.Equal(expectedArea, actualArea);
    }

    [Theory]
    [InlineData(3)]
    [InlineData(2)]
    [InlineData(10)]
    [InlineData(Double.MaxValue)]
    [InlineData(Double.MinValue)]
    public void Circle_GetArea_InsertUncorrectValue(double value1)
    {
        var circle = FigureFactory.CreateCircle(value1);
        double expectedArea = Math.PI * value1 * value1;
        double actualArea = circle.GetArea();
        Assert.Equal(expectedArea, actualArea);
        
    }
}
