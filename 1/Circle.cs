using System;

// Объявление класса Circle, который реализует интерфейс IShape
public class Circle : IShape
{
    // Автоматическое свойство Radius для хранения радиуса круга
    public double Radius { get; set; }

    // Конструктор класса Circle, принимающий радиус круга и инициализирующий свойство Radius
    public Circle(double radius)
    {
        Radius = radius;
    }

    // Реализация метода CalculateArea() для расчета площади круга
    public double CalculateArea()
    {
        return Math.PI * Radius * Radius; // Формула для площади круга: π * r^2
    }

    // Реализация метода CalculatePerimeter() для расчета периметра (длины окружности) круга
    public double CalculatePerimeter()
    {
        return 2 * Math.PI * Radius; // Формула для периметра окружности: 2 * π * r
    }
}
