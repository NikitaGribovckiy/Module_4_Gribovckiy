using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Создаем список книг, представленных интерфейсом IBook.
        List<IBook> library = new List<IBook>();

        while (true)
        {
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1. Проверить доступность книги");
            Console.WriteLine("2. Выдать книгу");
            Console.WriteLine("3. Вернуть книгу");
            Console.WriteLine("4. Добавить книгу");
            Console.WriteLine("5. Выйти");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                if (choice == 5)
                {
                    // Выход из программы при выборе "5".
                    Environment.Exit(0);
                }
                else if (choice >= 1 && choice <= 4)
                {
                    if (choice == 4)
                    {
                        Console.Write("Введите название книги: ");
                        string bookTitle = Console.ReadLine();

                        // Добавление новой книги в библиотеку.
                        library.Add(new Book(bookTitle));
                        Console.WriteLine($"Книга \"{bookTitle}\" успешно добавлена в библиотеку.");
                    }
                    else
                    {
                        Console.Write("Введите название книги: ");
                        string bookTitle = Console.ReadLine();

                        // Поиск книги по названию в библиотеке.
                        IBook book = library.Find(b => b.Title == bookTitle);

                        if (book != null)
                        {
                            if (choice == 1)
                            {
                                // Проверка доступности книги и вывод результата.
                                bool available = book.IsAvailable;
                                Console.WriteLine($"Книга \"{bookTitle}\" доступна: {available}");
                            }
                            else if (choice == 2)
                            {
                                // Выдача книги читателю.
                                book.CheckOut();
                            }
                            else if (choice == 3)
                            {
                                // Возврат книги в библиотеку.
                                book.Return();
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Книга \"{bookTitle}\" не найдена в библиотеке.");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Неверный выбор. Попробуйте снова.");
                }
            }
            else
            {
                Console.WriteLine("Неверный выбор. Попробуйте снова.");
            }
        }
    }
}
