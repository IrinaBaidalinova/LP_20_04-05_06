// 12 Напишите программу, 
// 1.которая на вход будет принимать два числа
// 2.и выводить, явлется ли первое число кратно второму
// 3.если первое число не кратно второму, 
// 4.то программа выводит остаток от деления

// 36,5 -> не кратно, остаток 4
// 16, 4 -> кратно

//Решение без метода
//Console.WriteLine("Первое число = ");
//int number1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Второе число = ");
//int number2 = Convert.ToInt32(Console.ReadLine());

//int remainder = number1 % number2;
//if (remainder == 0)
//{
 //  Console.WriteLine("кратно");
//}
//else
//{
//   Console.WriteLine($"не кратно, остаток {remainder}");
//}



//Решение через метод
Console.WriteLine("Первое число = ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Второе число = ");
int number2 = Convert.ToInt32(Console.ReadLine());

int remainder = Remainder (number1, number2);

string result = remainder != 0 ? $"не кратно, остаток {remainder}":"кратно";
Console.WriteLine(result);

int Remainder (int num1, int num2)

{
   return num1 % num2;
}
  
