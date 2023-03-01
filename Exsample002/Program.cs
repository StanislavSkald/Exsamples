// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write ("введите первое число");
string userAnswer = Console.ReadLine();
int N1 = Convert.ToInt32(userAnswer);
Console.Write ("Введите второе число");
string userAnswer2 = Console.ReadLine();
int N2 = Convert.ToInt32(userAnswer2);
Console.Write ("Введите третье число");
string userAnswer3 = Console.ReadLine();
int N3 = Convert.ToInt32(userAnswer3);
int max = N1;
if(max < N2)
{
    max = N2;
}
if(max < N3)
{ 
    max = N3;
}
Console.WriteLine(max);