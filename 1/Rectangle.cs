// Объявление класса Rectangle, который реализует интерфейс IShape
public class Rectangle : IShape
{
    // Автоматическое свойство Width для хранения ширины прямоугольника
    public double Width { get; set; }

    // Автоматическое свойство Height для хранения высоты прямоугольника
    public double Height { get; set; }

    // Конструктор класса Rectangle, принимающий ширину и высоту прямоугольника и инициализирующий свойства Width и Height
    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    // Реализация метода CalculateArea() для расчета площади прямоугольника
    public double CalculateArea()
    {
        return Width * Height; // Площадь прямоугольника = ширина * высота
    }

    // Реализация метода CalculatePerimeter() для расчета периметра прямоугольника
    public double CalculatePerimeter()
    {
        return 2 * (Width + Height); // Периметр прямоугольника = 2 * (ширина + высота)
    }
}
