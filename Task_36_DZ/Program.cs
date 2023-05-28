//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19

//[-4, -6, 89, 6] -> 0

int[] a = new int[4];
for (int i = 0; i < a.Length; i++)
{
    Console.Write($"Введите a[{i}] = ");
    a[i] = int.Parse(Console.ReadLine());
}
int sum = 0;
for (int i = 0; i < a.Length; i++)
{
    if (a[i] % 2 == 1)
        sum += a[i];
}
Console.WriteLine($"Сумма нечетных чисел = {sum}");