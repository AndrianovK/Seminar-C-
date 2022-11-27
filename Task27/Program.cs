// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.WriteLine("Ввведите число : ");
int a = Convert.ToInt32(Console.ReadLine());

int Summa(int a)
{
    int summa = 0;
    while (a> 0)
    {
        summa = summa + a % 10;
        a = a / 10;
    }
    return summa;
}
if (a < 0) a = - a;
int summa = Summa(a);
Console.WriteLine($" ---> {summa}");