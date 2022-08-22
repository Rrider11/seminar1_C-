// Задача 38: Задайте массив вещественных чисел. Найдите разницу между 

// максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


double[] arr1 = new double[5];

int length = arr1.Length;

 double max = 0;
 double min = 0;
 
    
for (int i = 0; i < length; i++)
    {
       arr1[i] = new Random().Next (-100,100);

    if(arr1[i] < min)
    {
        min = arr1[i];
    }       
    if(arr1[i] > max)
    {
        max = arr1[i];
    }
    }
double diff = max - min;
Console.Write(string.Join( ",", arr1 ));
Console.WriteLine();
Console.WriteLine($"Максимальное число в массиве = {max}");
Console.WriteLine($"Минимальное число в массиве = {min}");
Console.WriteLine($"Разница между макс и мин = {diff} единиц");







