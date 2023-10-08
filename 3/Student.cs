using System.Collections.Generic;
using System;

// Класс, представляющий студента
public class Student : IStudent
{
    private string name;          // Имя студента
    private int course;           // Курс, на котором учится студент
    private List<double> grades = new List<double>(); // Список оценок студента

    // Конструктор класса Student, принимающий имя и курс студента
    public Student(string name, int course)
    {
        this.name = name;
        this.course = course;
    }

    // Метод для добавления оценки студенту
    public void AddGrade(double grade)
    {
        if (grade >= 0 && grade <= 10) // Проверка корректности оценки
        {
            grades.Add(grade); // Добавление оценки в список
        }
        else
        {
            Console.WriteLine("Некорректная оценка. Оценка должна быть в диапазоне от 0 до 10.");
        }
    }

    // Реализация метода GetAverageGrade() из интерфейса IStudent
    public double GetAverageGrade()
    {
        if (grades.Count == 0)
        {
            return 0.0; // Если нет оценок, средний балл равен 0
        }

        double sum = 0.0;
        foreach (var grade in grades)
        {
            sum += grade; // Суммирование оценок
        }

        return sum / grades.Count; // Расчет среднего балла
    }

    // Реализация метода GetCourseInfo() из интерфейса IStudent
    public string GetCourseInfo()
    {
        return $"Студент {name}, {course}-й курс";
    }

    // Переопределение метода ToString() для строкового представления объекта Student
    public override string ToString()
    {
        return $"{GetCourseInfo()}, Средний балл: {GetAverageGrade()}";
    }
}
