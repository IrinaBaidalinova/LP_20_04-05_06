// Задача 18: 
//1 Напишите программу, которая по
// 2  заданному номеру четверти, показывает диапазон
// 3  возможных координат точек в этой четверти (x и y).

Console.Write("Введите номер четверти:");
int input = Convert.ToInt32(Console.ReadLine());
string range = Range(input);
Console.WriteLine(range == null ? "Некорректный ввод " : range);

string Range (int numb)
{
   if (numb == 1) return "x > 0, y > 0";
   if (numb == 2) return "x < 0, y > 0";
   if (numb == 3) return "x < 0, y < 0";
   if (numb == 4) return "x > 0, y < 0";
   return null;
}
