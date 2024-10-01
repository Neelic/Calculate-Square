namespace CalculateSquare;

public class Circle : IFigure
{
    private readonly double _radius;

    public Circle(double radius)
    {
        // Проверка на то, что радиус больше нуля
        // Если радиус равен 0, то это точка
        if (radius <= 0)
        {
            throw new ArgumentException("Радиус должен быть больше нуля");
        }

        _radius = radius;
    }

    public double CalculateSquare()
    {
        return Math.PI * Math.Pow(_radius, 2);
    }
}