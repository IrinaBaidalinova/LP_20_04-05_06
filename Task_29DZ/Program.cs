// Задача 29:
//1. Напишите программу, которая задаёт
//2.массив из 8 элементов, заполненный псевдослучайными числами
//3. и выводит их на экран.
//Пример:
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]



//int[] a = Enumerable.Range(1, 8).Select(x => 17 % x).ToArray();
//foreach (int i in a)
//Console.WriteLine(i);


int[] randomArray = new int[8];

for (int i = 0; i < 8; i++)
{
randomArray[i] = new Random().Next(1,8);
Console.Write(randomArray[i] + " ");
}

