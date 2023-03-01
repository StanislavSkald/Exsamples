// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write ("введите число");
string userAnswer = Console.ReadLine();
int N = Convert.ToInt32(userAnswer);
int N2 = N % 2;
if (N2 == 0)
{
    Console.WriteLine ("Чётное");
}
else
{
    Console.WriteLine ("Нечётное");
}
