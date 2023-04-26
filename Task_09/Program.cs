// Напишите программу 
//1.которая выводит случайное число 
//2.из отрезка  [10,99]и
//3. показывает наибольшие цифры числа.
//пример:
//78 -> 8
//12 -> 2
//85 -> 8

//int number = new Random().Next(10, 100); //(10,99+1)
//Console.WriteLine($"Случайное число из отрезка 10 - 99 -> {number}");

//int firstDigit = number / 10;
//int secondDigit = number % 10;

//if (firstDigit > secondDigit) 
//{
//Console.WriteLine($"Наибольшая цифра числа -> {firstDigit}");
//}
//else
//{
//  Console.WriteLine($"Наибольшая цифра числа -> {secondDigit}");
//}
// Тернарный оператор
//int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
//Console.WriteLine($"Наибольшая цифра числа -> {maxDigit}");
//методы
//int maxDigit = MaxDigit(number);
//Console.WriteLine($"Наибольшая цифра числа -> {maxDigit}");

int number = new Random().Next(100, 1000); //(10,99+1)
Console.WriteLine($"Случайное число из отрезка 100 - 999 -> {number}");

int DeletSecondDigit(int num)
{
   int firstDigit = num / 100;
   int thirDigit = num % 10;
   int needDigit = firstDigit * 10 + thirDigit;
   return needDigit;
   // int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
   // return firstDigit > secondDigit ? firstDigit : secondDigit;
}
int result = DeletSecondDigit (number);
Console.WriteLine($"{number} -> {result}");
