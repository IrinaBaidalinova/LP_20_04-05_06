// Напишите программу, которая
//1. на вход принимает два числа и 
//2. проверяет, является ли первое число квадратом второго.
//a = 25, b = 5 -> да
//a = 2, b = 10 -> нет
//a = 9, b = -3 -> да
//a = -3 b = 9 -> нет


Console.WriteLine("Введите Значение А");
int numberA = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите Значение B");
int numberB = Convert.ToInt32(Console.ReadLine()); 
if (numberA == numberB * numberB)
{
   Console.WriteLine($"Да число {numberA} является квадратом числа {numberB}");  
}
else
{
   Console.WriteLine($"Нет число {numberA} не является квадратом числа {numberB}");  
}

