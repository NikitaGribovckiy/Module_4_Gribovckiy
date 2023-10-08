using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<IStudent> students = new List<IStudent>(); // Создание списка студентов

        while (true)
        {
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1. Добавить студента");
            Console.WriteLine("2. Добавить оценку студенту");
            Console.WriteLine("3. Просмотреть список студентов и их средних оценок");
            Console.WriteLine("4. Выход");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                switch (choice)
                {
                    case 1:
                        Console.Write("Введите имя студента: ");
                        string name = Console.ReadLine();
                        Console.Write("Введите номер курса: ");
                        if (int.TryParse(Console.ReadLine(), out int course))
                        {
                            IStudent newStudent = new Student(name, course); // Создание нового студента
                            students.Add(newStudent); // Добавление студента в список
                            Console.WriteLine("Студент добавлен.");
                        }
                        else
                        {
                            Console.WriteLine("Некорректный ввод номера курса. Попробуйте снова.");
                        }
                        break;
                    case 2:
                        Console.Write("Введите имя студента: ");
                        string studentName = Console.ReadLine();
                        Student student = students.Find(s => s.GetCourseInfo().Contains(studentName)) as Student; // Поиск студента по имени
                        if (student != null)
                        {
                            Console.Write("Введите оценку: ");
                            if (double.TryParse(Console.ReadLine(), out double grade))
                            {
                                student.AddGrade(grade); // Добавление оценки студенту
                                Console.WriteLine("Оценка добавлена.");
                            }
                            else
                            {
                                Console.WriteLine("Некорректный ввод оценки. Попробуйте снова.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Студент не найден.");
                        }
                        break;
                    case 3:
                        foreach (var st in students)
                        {
                            Console.WriteLine(st.ToString()); // Вывод информации о студентах и их средних оценках
                        }
                        break;
                    case 4:
                        Environment.Exit(0); // Выход из программы
                        break;
                    default:
                        Console.WriteLine("Неверный выбор. Попробуйте снова.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Неверный выбор. Попробуйте снова.");
            }
        }
    }
}
