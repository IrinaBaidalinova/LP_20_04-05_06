﻿//Задача 39: Напишите программу, которая перевернёт
//одномерный массив (последний элемент будет на первом
//месте, а первый - на последнем и т.д.)
//[1 2 3 4 5] -> [5 4 3 2 1]
//[6 7 3 6] -> [6 3 7 6]


void CreateArrayRndInty(int[] arr, string sep = ",")
{
   for (int i = 0; i < arr.Length; i++)
   {
      if (i < arr.Length - 1) Console.Write($"{arr[i]}{sep} ");
      else Console.Write($"{arr[i]}");
   }
}

void PrintArray(int[] arr, string sep = ",")
{
   for (int i = 0; i < arr.Length; i++)
   {
      if (i < arr.Length - 1) Console.Write($"{arr[i]}{sep} ");
      else Console.Write($"{arr[i]}");
   }
}


//0 1 2 3 4
//[1 2 3 4 5] -> [5 4 3 2 1]

void ReverseArray(int[] arr)
{
   for (int i = 0; i < arr.Length / 2; i++)
   {
      int temp = arr[i]; // 2
      arr[i] = arr[arr.Length - 1 - i];
      arr[arr.Length - 1 - i] = temp;
   }
}

int[] array = CreateArrayRndInt(5, 1, 9);
Console.Write("[");
PrintArray(array);
Console.WriteLine("]");

ReverseArray(array);

Console.Write("[");
PrintArray(array);
Console.WriteLine("]");

Aarray.ReverseArray(array);