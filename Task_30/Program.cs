// Задача 30:
//1. Напишите программу, которая
//2.выводит массив из 8 элементов, 
//3.заполненный нулями и единицами в случайном порядке.
//[1,0,1,1,0,1,0,0]

// Массив
//int[] array = new int[8];
//int[] array0 = new int[] { 3, 6, 8, 8, 7 };
//int[] array01 = new int[11] { 3, 6, 8, 8, 7, 9, 6, 3, 5, 9, 1 };
//int[] array1 = { 1, 4, 7, 8 };

//var array2 = new int[8];//0,1,2,3,4,5,6,7
//array2[5] = 45;
//array2[0] = 4;

//for (int i = 0; i < array2.Length; i++)
//{
//  array2[i] = i * 2;
//  Console.Write(array2[i] + " ");
//}


//void FillArray
//void PrintArray
//int[] CreateArray

int[] arr = new int[8];
FillArray(arr);
Console.Write($"[");
PrintArray(arr);
Console.Write($"]");

void PrintArray(int[] array)
{
   int count = array.Length;

   for (int i = 0; i < count; i++)
   {
      Console.Write($"{array[i]} ");
   }

}
void FillArray(int[] array)
{
   for (int i = 0; i < array.Length; i++)
   {
      array[i] = new Random().Next(0, 2);
   }
}