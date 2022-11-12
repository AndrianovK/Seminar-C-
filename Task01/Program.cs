// Задача 1
// Напишите программу,которая на входе принимает 2 числа и проверяет является ли первое число больше второго.

Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

if(a == b * b)

{
Console.WriteLine("Результат: ");
Console.WriteLine("Да");
}
else
{
Console.WriteLine("Нет");
}

