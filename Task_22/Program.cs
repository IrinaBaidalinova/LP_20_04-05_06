// Задача 22:
//1 Напишите программу,
//2 которая принимает на вход
//3 число (N) и выдаёт таблицу
//4 квадратов чисел от 1 до N.
// Например:
//5 -> 1, 4, 9, 16, 25.
//2 -> 1,4

Console.Write("Введите положительное целое число: ");
int numberN = Convert.ToInt32(Console.ReadLine());


Square(numberN);

void Square(int num)
{
int count = 1;
while(count <= num)
{
   Console.WriteLine($"{count,3} {count * count,5}");
   count ++;
}

}

