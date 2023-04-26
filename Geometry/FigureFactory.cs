public class FigureFactory
{
    public static IFigure CreateCircle(double radius)
    {
        return new Circle(radius);
    }

    public static IFigure CreateTriangle(double a, double b, double c)
    {
        return new Triangle(a, b, c);
    }
}