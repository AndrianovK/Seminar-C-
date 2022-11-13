// Задача 4
//  Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Clear();
Console.WriteLine("Введите число ");
int NumberA = Convert.ToInt32(Console.ReadLine());
int NumberB = 2;
 if (NumberA % NumberB == 0 )
 {
  Console.WriteLine("Чётное");
 }
else
{
Console.WriteLine("Нечетное");
}
