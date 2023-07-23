/*
Напишите программу, которая принимает два числа на входе и проверяет
является ли первое число квадратом второго.
a = 25; b = 5 -> yes
a = 2; b = 10 -> no
a = 9; b = -3 -> no
a = -3; b = 9 -> no
*/

Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine()!);

int sqr2 = Convert.ToInt32(Math.Pow(number2, 2));

if (number1 == sqr2) Console.WriteLine($"Число {number1} является квадратом числа {number2}");
else Console.WriteLine($"Число {number1} не является квадратом числа {number2}");