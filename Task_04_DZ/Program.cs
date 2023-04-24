// Задача 4:
//1. Напишите программу, которая принимает на вход три числа
//2. и выдаёт максимальное из этих чисел.
Console.Write("Введите первое число:");
int fistNamber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число:");
int secondNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число:");
int thirdNumber = Convert.ToInt32(Console.ReadLine());
int max = fistNamber;
if (fistNamber > max)
{
   max = fistNamber;
}
if (secondNumber > max)
{
   max = secondNumber;
}
if (thirdNumber > max)
{
   max = thirdNumber;
}
Console.WriteLine("max=" + max);