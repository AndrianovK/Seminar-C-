// Задача 5
// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.


        Console.Clear();
        Console.WriteLine("Введите число");
        int NumberA = Convert.ToInt32(Console.ReadLine());
        int NumberB = 2;
        int count = 0;
        if (NumberA % NumberB == 0)
        {
            while (count<NumberA);
            {
            Console.Write(count+"");
            count++;
            }
        }



    