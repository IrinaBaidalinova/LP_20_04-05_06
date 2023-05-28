// Задача 31
// 1. Задайте массив из 12 элементов. 
// 2.заполненный Случайными числами из промежутка [-9,9].
//3. Найди сумму отрецательных и положительных элнментов массива.

//4. например:
// в массиве [3,9,-8,1,0,-7,2,-1,8-3,-1,6] сумма положительных чисел ровна 29
// сумма отрецательных ровна -20.

//первый метод 
int[] CreateArrayRndInt(int size, int min, int max) //метод
{
   int[] arr = new int[size]; // создали массив
   Random rnd = new Random(); // Класс рандом работает со случайными числами.

   for (int i = 0; i < arr.Length; i++)  //цикл for
   {
      arr[i] = rnd.Next(min, max + 1); // заполняем массив числами
   }
   return arr; // возврат массива
}

// 2 метод выводит в консоль
void PrintArray(int[] arr, string sep) // передача массива в метод void
{
   for (int i = 0; i < arr.length; i++) //цикл для вывода в консоль
   {
      if (i < arr.Length - 1) Console.Write($"{arr[i]}{sep} ");   // через Условие if ,else вывода в консоль
   else Console.Write($"{arr[i]}");
   }
}

int[] GetSumPositiveSumNegativeElem(int[] arr)
{
   int sumPositive = 0;
   int sumNegative = 0;
   for (int i = 0; i < arr.length; i++)    //цикл выводящий 2 числа 1 позетивное другое неготивное
   {
      if (arr[i] > 0)
         sumPositive += arr[i];
      else
         sumNegative += arr[i];

   }
   return new int[] { sumPositive, sumNegative };
}

int[] array = CreateArrayRndInt(12, -9, 9); // Вывод в консоль запятых и скобок.
Console.Write("[");
PrintArray(array, ",");
Console.WriteLine("]");

int[] SumPositiveSumNegativeElem = GetSumPositiveSumNegativeElem(array);
Console.WriteLine($"Сумма положительных элементов ровна {SumPositiveSumNegativeElem[0]}");
Console.WriteLine($"Сумма Отрецательных элементов ровна {SumPositiveSumNegativeElem[1]}"); // вывод в консоль суму положительных и отрецательных элем

nt GetSumPositiveElem(int[] arr)
{
int sum = 0;

for (int i = 0; i < arr.Length; i++)
{
if(arr[i] > 0) sum += arr[i];
}
return sum;
}

int GetSumNegativeElem(int[] arr)
{
int sum = 0;

for (int i = 0; i < arr.Length; i++)
{
if(arr[i] < 0) sum += arr[i];
}
return sum;
}

int[] array = CreateArrayRndInt(12, -9, 9);
Console.Write("[");
PrintArray(array, ",");
Console.WriteLine("]");

int[] sumPositiveNegativeElem = GetSumPositiveNegativeElem(array);
Console.WriteLine($"Cумма положительных элементов равна {sumPositiveNegativeElem[0]}");
Console.WriteLine($"Cумма отрицательных элементов равна {sumPositiveNegativeElem[1]}");

int sumPositiveElem = GetSumPositiveElem(array);
int sumNegativeElem = GetSumNegativeElem(array);
Console.WriteLine($"Cумма положительных элементов равна {sumPositiveElem}");
Console.WriteLine($"Cумма отрицательных элементов равна {sumNegativeElem}");