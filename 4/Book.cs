using System;

// Класс, представляющий книгу
public class Book : IBook
{
    // Свойство для получения названия книги (заголовка).
    public string Title { get; }

    // Приватное поле, указывающее доступность книги (по умолчанию доступна).
    private bool isAvailable = true;

    // Конструктор класса, принимающий название книги при создании.
    public Book(string title)
    {
        Title = title;
    }

    // Реализация свойства для проверки доступности книги.
    public bool IsAvailable
    {
        get { return isAvailable; }
    }

    // Метод для выдачи книги читателю.
    public void CheckOut()
    {
        if (isAvailable)
        {
            isAvailable = false;
            Console.WriteLine($"Книга \"{Title}\" успешно выдана.");
        }
        else
        {
            Console.WriteLine($"Книга \"{Title}\" уже выдана.");
        }
    }

    // Метод для возврата книги в библиотеку после использования.
    public void Return()
    {
        if (!isAvailable)
        {
            isAvailable = true;
            Console.WriteLine($"Книга \"{Title}\" успешно возвращена.");
        }
        else
        {
            Console.WriteLine($"Книга \"{Title}\" уже находится в библиотеке.");
        }
    }
}
