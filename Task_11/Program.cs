﻿//Задача 14 Напишите программу,
// 1. Которая принимает на вход число
//2. и проверяет,кратно ли оно одновременно 7 и 23
// Пример:
// 14->нет
// 46->нет
//161-> да
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
bool result = Multiplicity(number);
Console.WriteLine(result ? "да" : "нет");
bool Multiplicity(int num)
{
   return num % 7 == 0 && num % 23 == 0;
}