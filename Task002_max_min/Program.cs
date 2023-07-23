/*
Напишите программу, которая на входе принимает два числа и выдает,
какое число больше, а какое меньше.
a = 5; b = 7 -> max = 7
a = 2; b = 10 -> max = 10
a = -9; b = -3 -> max = -3
*/

Console.Write("Введите число: a=");
int a = int.Parse(Console.ReadLine()!);

Console.Write("Введите число: b=");
int b = int.Parse(Console.ReadLine()!);

if (a > b) Console.WriteLine($"Число a={a} больше числа b={b}");
if (b > a) Console.WriteLine($"Число b={b} больше числа a={a}");
if (a == b) Console.WriteLine($"Число a={a} равно числу b={b}");