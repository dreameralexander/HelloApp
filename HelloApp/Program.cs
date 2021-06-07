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
            sbyte temperature = 20;
            Console.Write($"Температура летом около {temperature}, это {Convert.ToString(temperature, 2).PadLeft(8, '0')} в двоичной системе.");

            short meltingTemperature = 1500;
            Console.Write($"\nТемпература плавления стали около {meltingTemperature}, это {Convert.ToString(meltingTemperature, 2).PadLeft(16, '0')} в двоичной системе.");

            temperature = 0b00001111; // задаем значение переменной в 2-ой системе.
            Console.Write($"\nТемпература сейчас за окном {temperature}, это {Convert.ToString(temperature, 2).PadLeft(8, '0')} в двоичной системе.");

            meltingTemperature = 0x0D48; // задаем значение переменной в 16-ой системе.
            Console.Write($"\nТемпература плавления вольфрама около {meltingTemperature}, это {Convert.ToString(meltingTemperature, 2).PadLeft(16, '0')} в двоичной системе.");

            byte countStudentsInClass = 25;
            Console.Write($"\nВ 8А учиться {countStudentsInClass} учеников");

            ushort numberIslandsInIndonesia = 17804;
            Console.Write($"\nВ Кол-во островов в Индонезии {numberIslandsInIndonesia}");

            uint populationOfAmericans = 327167000U;
            Console.Write($"\nВ Численость населения в США {populationOfAmericans}");

            int populationGrowthInUkraineIn2020 = -159661;
            Console.Write($"\nВ Прирост числености населения в Украине {populationGrowthInUkraineIn2020}");

            ulong populationOfWorld = 7866000000UL;
            Console.Write($"\nВ Численость населения в мире {populationOfWorld}");

            long populationGrowthInWorldIn2020 = 81000000L;
            Console.Write($"\nВ Прирост числености населения в мире {populationGrowthInWorldIn2020}");

            //Вещественные литералы
            float valuePi = 3.14F;
            valuePi = 314E-2F;
            Console.Write($"\nЗначение ПИ равно - {valuePi}");

            double gdpRussia2020InTrillionRub = 106.6066;
            gdpRussia2020InTrillionRub = 1.066066E2;
            Console.Write($"\nВВП России за 2020 в триллионах рос. р. - {gdpRussia2020InTrillionRub}");

            decimal curentDollarToEuroExchangeRate = 1.2212M;
            curentDollarToEuroExchangeRate = 12212E-4M;
            Console.Write($"\nТекущий курс USD к EURO - {curentDollarToEuroExchangeRate}");

            //Символьные литералы
            char letter = 'A';
            Console.Write($"\nПервая буква анг. алфавита {letter}, ");
            letter = 'Я';
            Console.Write($"а последняя рус. алфавита {letter}. ");
            letter = '1';
            Console.Write(letter);
            letter = '.';
            Console.Write(letter);
            letter = '\x41';
            Console.Write($"{letter}, 2.");
            letter = '\x42';
            Console.Write(letter);
            Console.Write($"\nСимвол \\u0420 из таблици Unicode равен - ");
            letter = '\u0420';
            Console.Write(letter);

            //Управляющие символьные литералы
            char newRowCharacters = '\n';
            char tabCharacters = '\t';
            Console.Write($"{newRowCharacters}{newRowCharacters}{tabCharacters}{tabCharacters}Мой первый друг, мой друг бесценный!");

            //Строковые литералы
            string message = "\n\nСимвол \\u0420 из таблици Unicode равен - \u0420. " +
                "\nСимвол \\x50 из таблицы ASCII равен - \x50." +
                "\nКомпания \"IBM\"";
            Console.Write(message);

            //Литерал null
            string personFio = null;
            Console.Write($"{personFio}Значение переменой person равно \"{personFio}\"");

            //Литерал object
            object commonObject = gdpRussia2020InTrillionRub;
            Console.Write($"{newRowCharacters}Значение переменной commonObject \"{commonObject}\"");
            //Любопытно, а что будет если мы изменим переменную которую присвоили commonObject
            gdpRussia2020InTrillionRub = 107;
            Console.Write($"{newRowCharacters}Значение переменной commonObject \"{commonObject}\"");

            //Не явная типизация
            var text = "Привет";
            Console.Write($"{newRowCharacters}Тип переменной a = \"{text.GetType()}\", а ее значение {text}");

            //Это работать не будет, так как a = null, что вызовет ошибку.
            //a = null;
            //Console.Write($"{newRowCharacters}Тип переменной a = \"{a.GetType()}\", а ее значение {a}");

            //Это работать не будет
            //var b;
            //var b = null;     

            //Арифметические операции
            //Бинарные операции
            int a = 5;
            int b = 10;
            int c = a + b;

            Console.Write($"{newRowCharacters}а({a}) + b({b}) = c({c}).");
            c = a - b;
            Console.Write($"{newRowCharacters}а({a}) - b({b}) = c({c}).");
            c = a * b;
            Console.Write($"{newRowCharacters}а({a}) * b({b}) = c({c}).");
            c = b / a;
            Console.Write($"{newRowCharacters}b({b}) / c({a}) = c({c}).");
            c = a / b;
            Console.Write($"{newRowCharacters}а({b}) / b({a}) = c({c}). Так как int может хранить только целые значения, значения после запятой мы потеряли.");

            //Инициализируем несколько переменных одного типа
            float x = 5, y = 10, z;
            z = x / y;
            Console.Write($"{newRowCharacters}x({x}) / y({y}) = z({z}).");

            //Остаток от деления
            z = x % y;
            Console.Write($"{newRowCharacters}x({x}) % y({y}) = z({z}). Остаток от деления.");

            //Унарные опереации
            c = ++a + ++b; //префиксный инкремент
            Console.Write($"{newRowCharacters}++а({a}) + ++b({b}) = c({c}). Сначала происходит прибавление, после чего происходит операция суммирования.");

            c = a++ + b++; //постфиксный инкремент
            Console.Write($"{newRowCharacters}а++({a}) + b++({b}) = c({c}). Сначала происходит операция суммирования, после чего происходит прибавление.{newRowCharacters}При последующем вызове переменных a, b мы видим измененое значение.");

            a = 5;
            b = 10;
            c = --b - a--; //префиксный декремент
            Console.Write($"{newRowCharacters}--b({b}) - a--({a}) = c({c}). А так еще интереснее, не забываем, что постфиксный выполняется после возврата значения в инструкцию. {newRowCharacters}При последующем вызове переменных a, b мы видим измененое значение.");

            c = b-- - --a; //постфиксный декремент
            Console.Write($"{newRowCharacters}b--({b}) - --a({a}) = c({c}). Не забываем, что постфиксный выполняется после возврата значения в инструкцию. {newRowCharacters}При последующем вызове переменных a, b мы видим измененое значение.");

            //Приоритет операций
            z = 10 / 5 * 2;
            Console.Write($"{newRowCharacters} 10 / 5 * 2 = z({z})). Порядок выполнения:{newRowCharacters}1. Инкремент, декремент.{newRowCharacters}2. Умножение, деление, получение остатка{newRowCharacters}3. Сложение и вычитание{newRowCharacters}" +
                $"Если операции имеют один и тот же приоритет, они выполняются в зависимости от ассоциативности. Все арифметические операции являются левоассоциативными и выполняются слева на право");
            c = ++a + b * a + 10 / a - b;
            Console.Write($"{newRowCharacters} ++a({a}) + b({b}) * a({a}) + 10 / a({a}) - b({b}) = с({c})). Порядок выполнения:{newRowCharacters}1. Инкремент, декремент.{newRowCharacters}2. Умножение, деление, получение остатка{newRowCharacters}3. Сложение и вычитание");

            //Поразрядные операции
            byte bA = 5, bB = 14, bC;

            //Логическое умножение, хотя по логике больше похоже на И
            bC = (byte)(bA & bB);
            Console.Write($"{newRowCharacters}Логическое умножение, хотя по логике больше похоже на И.{newRowCharacters}A({bA}) & B({bB}) равно C({bC}), а теперь в двоичной системе {newRowCharacters}{tabCharacters}" +
                $"{Convert.ToString(bA, 2).PadLeft(8, '0')}{newRowCharacters}{tabCharacters}&{newRowCharacters}{tabCharacters}" +
                $"{Convert.ToString(bB, 2).PadLeft(8, '0')}{newRowCharacters}{tabCharacters}" +
                $"{Convert.ToString(bC, 2).PadLeft(8, '0')}");

            //Логическое сложение, хотя по логике больше похоже на ИЛИ
            bC = (byte)(bA | bB);
            Console.Write($"{newRowCharacters}Логическое сложение, хотя по логике больше похоже на ИЛИ.{newRowCharacters}A({bA}) | B({bB}) равно C({bC}), а теперь в двоичной системе {newRowCharacters}{tabCharacters}" +
                $"{Convert.ToString(bA, 2).PadLeft(8, '0')}{newRowCharacters}{tabCharacters}&{newRowCharacters}{tabCharacters}" +
                $"{Convert.ToString(bB, 2).PadLeft(8, '0')}{newRowCharacters}{tabCharacters}" +
                $"{Convert.ToString(bC, 2).PadLeft(8, '0')}");

            //Логическое исключаеще ИЛИ (XOR)
            bC = (byte)(bA ^ bB);
            Console.Write($"{newRowCharacters}Логическое исключаеще ИЛИ (XOR).{newRowCharacters}A({bA}) ^ B({bB}) равно C({bC}), а теперь в двоичной системе {newRowCharacters}{tabCharacters}" +
                $"{Convert.ToString(bA, 2).PadLeft(8, '0')}{newRowCharacters}{tabCharacters}&{newRowCharacters}{tabCharacters}" +
                $"{Convert.ToString(bB, 2).PadLeft(8, '0')}{newRowCharacters}{tabCharacters}" +
                $"{Convert.ToString(bC, 2).PadLeft(8, '0')}");

            //Логическое отрицание или инверсия
            bC = (byte)~bB;
            Console.Write($"{newRowCharacters}Логическое отрицание или инверсия.{newRowCharacters}~B({bB}) равно C({bC}), а теперь в двоичной системе {newRowCharacters}{tabCharacters}" +
                $"{Convert.ToString(bB, 2).PadLeft(8, '0')}{newRowCharacters}{tabCharacters}" +
                $"~{newRowCharacters}{tabCharacters}" +
                $"{Convert.ToString(bC, 2).PadLeft(8, '0')}");

            //Операции сдвига
            bC = (byte)(bB<<2);
            Console.Write($"{newRowCharacters}Операция сдвига.{newRowCharacters}B({bB}) << 2 равно C({bC}), а теперь в двоичной системе {newRowCharacters}{tabCharacters}" +
               $"{Convert.ToString(bB, 2).PadLeft(8, '0')}{newRowCharacters}{tabCharacters}" +
               $"<<2{newRowCharacters}{tabCharacters}" +
               $"{Convert.ToString(bC, 2).PadLeft(8, '0')}");

            bC = (byte)(bB >> 2);
            Console.Write($"{newRowCharacters}Операция сдвига.{newRowCharacters}B({bB}) >> 2 равно C({bC}), а теперь в двоичной системе {newRowCharacters}{tabCharacters}" +
               $"{Convert.ToString(bB, 2).PadLeft(8, '0')}{newRowCharacters}{tabCharacters}" +
               $">>2{newRowCharacters}{tabCharacters}" +
               $"{Convert.ToString(bC, 2).PadLeft(8, '0')}");

            //Операции присваивания
            int q = 10, w, e =17, r =57;
            q = w = e = r = 135;
            Console.Write($"{newRowCharacters}Операция присваивания.{newRowCharacters}q = w = e = r = 135({q}){newRowCharacters}Операции присваивания имеет низкий приоритет, поэтому тут оно выполняется последней.");

            q = 10;
            w = e = 17;
            r = 57;
            int t = q += w *= e -= r -= 5;
            Console.Write($"{newRowCharacters}Операция присваивания.{newRowCharacters}t({t}) = q({q}) += w({w}) *= e({e}) -= r({r}) -= 5{newRowCharacters}Операции присваивания являются правоассоциативные, то есть выполняются с право на лево.");

            //Представление отрицательных чисел
            //Старший разряд является знаковым, если он равен 1, то значение отрицательное
            sbyte v = 100;
            Console.Write($"{newRowCharacters}v({v}), это {Convert.ToString(v, 2).PadLeft(8, '0')} в двоичной системе.");
            v = (sbyte)(~v + 1);
            Console.Write($"{newRowCharacters}v({v}), после ~v + 1, это {Convert.ToString(v, 2).PadLeft(8, '0')} в двоичной системе.");
            v = (sbyte)(~v + 1);
            Console.Write($"{newRowCharacters}v({v}), после ~v + 1, это {Convert.ToString(v, 2).PadLeft(8, '0')} в двоичной системе.");


            // Ждем ввода пользователя
            Console.ReadKey();

            // Конец блока метода
        }

        // Конец блока класса

    }

    // Конец блока пространства имен
}