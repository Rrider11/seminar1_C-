// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

Console.WriteLine("Введите число, которое вы ищете");
double a = Convert.ToUInt32(Console.ReadLine());

double[,] matrix = new double[4, 3];

void PrintArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($" {matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            
            matr[i, j] = new Random().Next(10);
        }
    }
}


Console.WriteLine();
FillArray(matrix);

PrintArray(matrix);

int yes = 0;

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (a == matrix[i, j])
            yes++;
    }
}

if (yes > 0)

    Console.WriteLine($" Число {a} в массиве есть");
else

    Console.WriteLine($" Числа {a} в массиве нет");
