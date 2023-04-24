// Задача 2:
//1. Напишите программу, которая на входпринимает два числа 
//2. и выдаёт, какое число большее, а какое меньшее.
//Пример:
//a = 5; b = 7 -> max = 7
//a = 2; b = 10 -> max = 10
//a = -9; b = -3 -> max = -3
Console.WriteLine("Введите первое число:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2)
{
   Console.WriteLine("Превое число больше второго");
}
else if (number1 < number2)
{
   Console.WriteLine("Превое число меньше второго");
}
else
{
   Console.WriteLine("Оба числа ровны");
}


