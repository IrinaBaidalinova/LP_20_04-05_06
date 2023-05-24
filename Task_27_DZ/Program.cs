// Задача 27:
//1 Напишите программу, 
//2 которая принимает на вход число 
//3 и выдаёт сумму цифр в числе.

//452 -> 11
//82 -> 10
//9012 -> 12


Console.WriteLine("Введите целое положительное число: ");

int x = int.Parse(Console.ReadLine());
int sum = 0;
for (int i = 2; i >= 0; i--)
{
   sum += x / (int)Math.Pow(10.0, i);
   x = x % (int)Math.Pow(10.0, i);
}
Console.WriteLine(sum);

