//Задача №7
//1. Напишите программу, которая принимает на вход трёхзначное число 
//2. и на выходе показывает последнюю цифру этого числа.
//Пример:
//456 -> 6
//782 -> 2
//918 -> 8
Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number<0) number *= -1;
if (number >= 100 && number <= 999)
{
   int lastNumber = number % 10;
   Console.WriteLine($"Последняя цифра числа {number} => {lastNumber}");
}
else Console.WriteLine("Не корректный ввод");