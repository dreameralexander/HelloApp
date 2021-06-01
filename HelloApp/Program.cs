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
            Console.WriteLine();

            //Литералы, константы 
            bool isCreate = false;
            Console.Write($"Логический литерал isCreate может имет значение - {isCreate.ToString()} в двоичной системе ({Convert.ToString(Convert.ToByte(isCreate), 2).PadLeft(8, '0') })");
            isCreate = !isCreate;
            Console.Write($" или {isCreate.ToString()} в двоичной системе ({Convert.ToString(Convert.ToByte(isCreate), 2).PadLeft(8, '0') }).");
            Console.WriteLine("\nНасчет представления в двоичной системе, все несколько иначе, 00000000 это false, а вот любой другой вариант это true.");

            //Целочисленные литералы
            byte temperature = 20;
            Console.Write($"Температура летом около {temperature}, это {Convert.ToString(temperature, 2).PadLeft(8, '0')} в двоичной системе.");

            short meltingTemperature = 1500;
            Console.Write($"\nТемпература плавления стали около {meltingTemperature}, это {Convert.ToString(meltingTemperature, 2).PadLeft(16, '0')} в двоичной системе.");

            temperature = 0b00001111; // задаем значение переменной в 2-ой системе.
            Console.Write($"\nТемпература сейчас за окном {temperature}, это {Convert.ToString(temperature, 2).PadLeft(8, '0')} в двоичной системе.");

            meltingTemperature = 0x0D48; // задаем значение переменной в 16-ой системе.
            Console.Write($"\nТемпература плавления вольфрама около {meltingTemperature}, это {Convert.ToString(meltingTemperature, 2).PadLeft(16, '0')} в двоичной системе.");

            Console.ReadKey();
        }

        // Конец блока класса

    }

    // Конец блока пространства имен
}