﻿// 16. Напишите программу, которая принимает на вход два числа и 
// проверяет ,является ли одно число квадратом другого.
// 5,25 -> да
// -4,16 ->да
// 25,5 ->да
// 8,9 ->нет

Console.Clear();
Console.WriteLine("Введите первое число:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(square(num1,num2) ? "да" : "нет");

bool square (int numb1, int numb2)
{

     return (numb1 == numb2*numb2) || (numb2 == numb1*numb1);
}

  

