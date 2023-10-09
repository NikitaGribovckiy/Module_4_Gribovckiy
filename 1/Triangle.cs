using System;

// Объявление класса Triangle, который реализует интерфейс IShape
public class Triangle : IShape
{
    // Автоматические свойства SideA, SideB и SideC для хранения длин сторон треугольника
    public double SideA { get; set; }
    public double SideB { get; set; }
    public double SideC { get; set; }

    // Конструктор класса Triangle, принимающий длины трех сторон треугольника и инициализирующий свойства SideA, SideB и SideC
    public Triangle(double sideA, double sideB, double sideC)
    {
        if (!IsValidTriangle(sideA, sideB, sideC))
        {
            Console.WriteLine("Невозможно создать треугольник с данными сторонами.");
        }

        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }

    // Метод для проверки, являются ли заданные стороны допустимыми для создания треугольника
    private bool IsValidTriangle(double a, double b, double c)
    {
        return a + b > c && a + c > b && b + c > a;
    }

    // Реализация метода CalculateArea() для расчета площади треугольника
    public double CalculateArea()
    {
        // Используется формула Герона для расчета площади треугольника
        double s = (SideA + SideB + SideC) / 2;
        return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
    }

    // Реализация метода CalculatePerimeter() для расчета периметра треугольника
    public double CalculatePerimeter()
    {
        return SideA + SideB + SideC;
    }
}
