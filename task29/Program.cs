// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

int[] arr1 = new int[8];
int length = arr1.Length;

    for (int i = 0; i < length; i++)
    {
        arr1 [i] = new Random().Next (-100,100);
        Console.Write($"{arr1 [i]} ");
    }

