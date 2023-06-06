//Задача 66:
//1. Задайте значения M и N.
//2. Напишите программу, которая найдёт сумму натуральных элементов
//3. в промежутке от M до N.

//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

int n, m, s = 0;
Console.Write("Введи значение M = ");
n = Convert.ToInt16(Console.ReadLine());
Console.Write("Введи значение N = ");
m = Convert.ToInt16(Console.ReadLine());
for (int i = n; i <= m; i++)
{
   if (i % 1 == 0)
      s = s + i ;   //целое число


}
Console.WriteLine(s);
