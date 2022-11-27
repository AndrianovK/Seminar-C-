// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.WriteLine("Ввведите первое число 1: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввведите первое число 2: ");
int b = Convert.ToInt32(Console.ReadLine());

int Degree(int numb1, int numb2 )
{
    int result =1;
    for (int i = 0; i < numb2; i++)
    {
        result=numb1*result;
    }
    return result;
       
}
if (b > 0 ) 
{
int degree = Degree(a, b);
Console.WriteLine($"-> {degree}");
}
