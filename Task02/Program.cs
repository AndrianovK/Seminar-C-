// Задача 3
//  Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Введите первое число: ");
        int numberA = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе число: ");
        int numberB = Convert.ToInt32(Console.ReadLine());

        if (numberA < numberB)
        {
            Console.Write("max = ");
            Console.WriteLine(numberB);
            Console.Write("min = ");
            Console.WriteLine(numberA);
        }
        else
        {
            if (numberA > numberB) ;
            Console.Write("max = ");
            Console.WriteLine(numberA);
            Console.Write("min = ");
            Console.WriteLine(numberB);
        }
    }
}