// Задача 5
// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.


        Console.Clear();
        Console.WriteLine("Введите число");
        int NumberA = Convert.ToInt32(Console.ReadLine());
        int i = 0;
        while (i<=NumberA)
         {
           Console.Write(i+" ");
           i+=2;  
         }
        if (NumberA % 2 == 0 )
           {
            Console.WriteLine("Чётное");
           }