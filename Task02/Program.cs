// Задача 3
//  Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Clear();
Console.WriteLine("Введите первое число: ");
int numberA =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberB =Convert.ToInt32(Console.ReadLine());

if (numberA < numberB)
{
Console.WriteLine(numberB);
}
else
{
if (numberA > numberB);
 Console.WriteLine(numberA);
}

