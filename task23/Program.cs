﻿// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


Console.WriteLine("Введите число");

int N = int.Parse(Console.ReadLine());



for(int i = 1; i <= Math.Abs(N); i++)
{
    if ( i == Math.Abs(N) )
        {
            double cub = (Math.Pow(i,3));
            Console.Write( cub );
        }

    else
        {
            double cub = (Math.Pow(i,3));
            Console.Write(cub + "," );
        }
}

