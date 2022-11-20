// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.WriteLine("Введите число:");
int numb =Convert.ToInt32(Console.ReadLine());
int number1 = (6);
int number2 = (7);

if (numb < number1 )
{
Console.WriteLine("нет");
}
else if  (numb<= number1 )
{
Console.WriteLine("да");
}
else if (numb>=number2)
{
Console.WriteLine("да");
}





