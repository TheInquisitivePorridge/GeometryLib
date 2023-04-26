public class Triangle : IFigure
{
    private readonly double a;
    private readonly double b;
    private readonly double c;

    public Triangle(double a, double b, double c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    public double GetArea()
    {
        // Формула Герона для вычисления площади треугольника
        double p = (a + b + c) / 2;
        return Math.Sqrt(p*(p - a)*(p - b)*(p - c));
    }

    public bool IsRightTriangle()
    {
        // Проверяем теорему Пифагора
        return a*a + b*b == c*c || a*a + c*c == b*b || b*b + c*c == a*a;
    }
}