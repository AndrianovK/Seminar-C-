// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int Digits(int num)
{
int count = 0;
int dig = default;
while (num > 0)
{
dig = num / 10;
num = dig;
count++;
}
return count;
}

int result = Digits(number);
Console.WriteLine($"Количество цифр в числе {number} ---> {result}");