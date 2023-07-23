/*
Напишите программу, которая на вход принимает число и выдаёт,
является ли число чётным (делится ли оно на два без остатка).
4 -> yes
-3 -> no
7 -> no
*/

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

int remainder = number % 2;

if (remainder == 0) Console.WriteLine("Введённое число является чётным.");
else Console.WriteLine("Введённое число является не чётным.");