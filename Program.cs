// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

 
        Console.WriteLine("Введите два числа : ");
 
        int number_1 = Convert.ToInt32(Console.ReadLine());
 
        int number_2 = Convert.ToInt32(Console.ReadLine());

 
        if (number_1 > number_2)
 
        {
 
            Console.WriteLine("{0} наибольшее число", number_1 );
 
        }
 
        else
 
        {
 
            Console.WriteLine("{0} наибольшее число ", number_2);
 
        }
 
        Console.ReadLine();
    