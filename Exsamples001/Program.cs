﻿// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write ("введите первое число");
string userAnswer = Console.ReadLine();
int a = Convert.ToInt32(userAnswer);

Console.Write ("Введите второе число");
string userAnswer2 = Console.ReadLine();
int b = Convert.ToInt32(userAnswer2);

if (a>b)
{
    Console.WriteLine("Большее число" + " " + a);
    Console.WriteLine("Меньшее число" + " " + b);
}
else
{
    Console.WriteLine("Большее число" + " " + b);
    Console.WriteLine("Меньшее число" + " " + a);
} 