//Программа выводит числа от -n до n
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

int count = -number;

while (count <= number)
{
    Console.Write($"{count} ");
    count++;
}