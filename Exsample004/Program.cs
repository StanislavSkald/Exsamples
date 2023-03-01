// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write ("введите число");
string userAnswer = Console.ReadLine();
int N = Convert.ToInt32(userAnswer);
int Current = 1;
while (Current <= N)
if (Current % 2 == 0)
{
    Console.Write (Current + " ");
    Current = Current + 1;
}
else
{
    Current = Current + 1;
}