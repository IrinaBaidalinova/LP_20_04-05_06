
//Задача 64:
//1. Задайте значение N. 
//2. Напишите программу, которая выведет все натуральные числа в
//3. промежутке от N до 1. Выполнить с помощью рекурсии.

//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"



Console.Write("Введи N: ");
int N = Convert.ToInt16(Console.ReadLine());
Console.Write("Введи M: ");
int M = Convert.ToInt16(Console.ReadLine());
Console.WriteLine($"N={N}, M={M}");
if (M > N)
   for (int i = N; i <= M; i++)
      Console.Write($" {i}");
else
   for (int i = M; i <= N; i++)
      Console.Write($" {i}");