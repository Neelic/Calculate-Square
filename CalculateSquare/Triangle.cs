namespace CalculateSquare;

public class Triangle : IFigure
{
    private readonly double _a;
    private readonly double _b;
    private readonly double _c;
    private readonly double _p;

    private readonly double _smallestSide1;
    private readonly double _smallestSide2;

    public bool IsRightTriangle { get; }

    public Triangle(double a, double b, double c)
    {
        if (a <= 0 || b <= 0 || c <= 0)
        {
            throw new ArgumentException("Треугольник с такими сторонами не существует");
        }

        // Проверка на существование треугольника, если сумма двух сторон равна третьей,
        // то это не треугольник, а линия
        if (a + b <= c || a + c <= b || b + c <= a)
        {
            throw new ArgumentException("Треугольник с такими сторонами не существует");
        }

        if (Math.Abs(Math.Pow(a, 2) + Math.Pow(b, 2) - Math.Pow(c, 2)) == 0 ||
            Math.Abs(Math.Pow(a, 2) + Math.Pow(c, 2) - Math.Pow(b, 2)) == 0 ||
            Math.Abs(Math.Pow(b, 2) + Math.Pow(c, 2) - Math.Pow(a, 2)) == 0)
        {
            IsRightTriangle = true;

            // Нахождение двух наименьших ребер треугольника
            if (a < b)
            {
                _smallestSide1 = a;
                _smallestSide2 = b;
            }
            else
            {
                _smallestSide1 = b;
                _smallestSide2 = a;
            }

            if (c < _smallestSide1)
            {
                _smallestSide2 = _smallestSide1;
                _smallestSide1 = c;
            }
            else if (c < _smallestSide2)
            {
                _smallestSide2 = c;
            }
        }
        else
        {
            _a = a;
            _b = b;
            _c = c;
            _p = (_a + _b + _c) / 2;
        }
    }

    public double CalculateSquare()
    {
        if (IsRightTriangle)
        {
            return _smallestSide1 * _smallestSide2 / 2;
        }

        return Math.Sqrt(_p * (_p - _a) * (_p - _b) * (_p - _c));
    }
}