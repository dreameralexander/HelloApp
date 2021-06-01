using System;   // Подключаемое пространство имен        

/// <summary>
/// Пространство имен проекта
/// </summary>
namespace HelloApp 
{
    // Начало блока пространства имен

    // Объявляем новый класс.
    class Program 
    {
        // Начало блока класса

        // Объявление нового метода
        static void Main(string[] arg)
        {
            // Начало блока метода

            // Регистрозависимые переменные
            // Объявлены 3 раные переменные
            string name = "Олег";
            string Name = "Саша";
            string NAME = "Маша";

            Console.WriteLine($"Переменная name = {name}");
            Console.WriteLine($"Переменная Name = {Name}");
            Console.WriteLine($"Переменная NAME = {NAME}");
            Console.ReadKey();

            // Конец блока метода

        }

        // Конец блока класса

    }

    // Конец блока пространства имен
}