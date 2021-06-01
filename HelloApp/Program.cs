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

            // Однострочный коментарий
            Console.WriteLine("// Однострочный коментарий");
            /*
            Многострочный коментарий
            */
            Console.WriteLine("/*");
            Console.WriteLine("Многострочный коментарий");
            Console.WriteLine("*/");
            // Конец блока метода
            Console.WriteLine();

            // Регистрозависимые переменные
            // Объявлены 3 раные переменные
            string name = "Олег";
            string Name = "Саша";
            string NAME = "Маша";

            Console.WriteLine($"Переменная name = {name}");
            Console.WriteLine($"Переменная Name = {Name}");
            Console.WriteLine($"Переменная NAME = {NAME}");
            Console.WriteLine();

            //Изучаем переменные
            string personFIO = "Иванов Иван Иванович";
            Console.WriteLine($"Имя сотрудника - {personFIO}");
            byte personAge = 30;
            byte personAgeOnMomentSingContract = personAge;
            Console.WriteLine($"Возраст на момент подписания договора - {personAgeOnMomentSingContract}");
            //Прошел год
            personAge++;
            Console.WriteLine($"Возраст на данный момент - {personAge}");
            
        }

        // Конец блока класса

    }

    // Конец блока пространства имен
}