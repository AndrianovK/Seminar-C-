// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 14212 -> нет
// 12821 -> да
// 23432 -> да


Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int num1 = number / 10000 % 10;   
int num2 = number / 1000 % 10;
int numb3 = number / 10 % 10;
int numb4 = number % 10;
int nul = number / 10000;
        
if (nul < 1 || nul > 9)
{
Console.WriteLine(number + "-->Не пятизначное число");
}
else if  (num1 == numb4 && num2 == numb3)
{
Console.WriteLine(number + "--> да ");
}
else
{
Console.WriteLine(number + "--> нет ");
}

 