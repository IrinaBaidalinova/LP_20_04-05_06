// Задача 26 Напишите программу, которая 
//1.на вход принимает число и
//2. выдает ко-во цифр в чисел

//456-> 3
//78 -> 2
//89126 -> 5*/

//Console.WriteLine("Введите целое положительное число: ");
//int number = Convert.ToInt32(Console.ReadLine());

//int sumNumbers = SumNumbers(number);
//Console.WriteLine($"Сумма чисел от 1 до {number} = {sumNumbers}");

//int SumNumbers(int num)
//{
//   int sum = 0;
//   for (int i = 1; i <= num; i++)
//   {
//      sum = sum + i;
//   }
//  return sum;
//}

Console.WriteLine("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int count = CountNumber(number);

Console.WriteLine($"ВКоличество цифр в числе: {number} = {count}");

int CountNumber(int num)
{
   int i = 0;
   while (num !=0)
   {
      num = num / 10;
      i++;
   }
   return i;
}
