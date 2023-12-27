// Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number % 7 == 0 && number % 23 == 0)
// {
//     Console.WriteLine($"Число {number} кратно числу `7` и `23`");
// }
// else
// {
//     Console.WriteLine($"Число {number} НЕ кратно числу `7` и `23`");
// }

// Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

// Console.Write("Введите координаты точки Х: ");
// int numberX = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координаты точки У: ");
// int numberY = Convert.ToInt32(Console.ReadLine());
// if (numberX == 0 | numberY == 0)
// {
//     Console.WriteLine("Точка лежит на координатной линии");
// }
// else
// {
//     if (numberX > 0 && numberY > 0)
//         {
//             Console.WriteLine($"Координата ({numberX},{numberY}) лежит в 1-й четверти координатной плоскости");
//         }
//     if (numberX < 0 && numberY > 0)
//         {
//             Console.WriteLine($"Координата ({numberX},{numberY}) лежит в 2-й четверти координатной плоскости");
//         }
//     if (numberX < 0 && numberY < 0)
//         {
//             Console.WriteLine($"Координата ({numberX},{numberY}) лежит в 3-й четверти координатной плоскости");
//         }
//     if (numberX > 0 && numberY < 0)
//         {
//             Console.WriteLine($"Координата ({numberX},{numberY}) лежит в 4-й четверти координатной плоскости");
//         }
// }

// Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number >= 10 && number <= 99)
// {
//     int number1 = number / 10;
//     int number2 = number % 10;
//     if (number1 >= number2)
//     {
//         Console.WriteLine($"Наибольшая цифра числа `{number}` равна `{number1}`");
//     }
//     else
//     {
//         Console.WriteLine($"Наибольшая цифра числа `{number}` равна `{number2}`");
//     }
// }
// else
// {
//     Console.WriteLine($"Число {number} лежит вне отрезка `10` и `99`");
// }

// Задача 4: Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int numberResult = number;
int numberRevert = 0;

while (number > 9)
{
    numberRevert = number % 10 + 10 * numberRevert;
    number = number / 10;
}
numberRevert = number + numberRevert * 10;

while (numberRevert > 9)
{
    Console.Write($" {numberRevert % 10},");
    numberRevert = numberRevert / 10;
}
Console.WriteLine($" {numberRevert}");