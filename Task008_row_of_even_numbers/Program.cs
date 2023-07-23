/*
Напишите программу, которая на вход принимает число (N),
а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/


Console.Write("Введите число N=");
int n = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Чётные числа от 1 до {n}: ");

int count = 2;
while (count <= n)
{
    int remainder = count % 2;
    if (remainder == 0) Console.Write($"{count}  ");
    count++;
}