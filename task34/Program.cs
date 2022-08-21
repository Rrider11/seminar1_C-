// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


int[] arr1 = new int[7];
int length = arr1.Length;
int index = 0;
int count = 0;

while(index < length)
{
    arr1 [index] = new Random().Next (100,1000);
    index++;    
}


for (int i = 0; i < length;  i++)
    {
        arr1 [i] = new Random().Next (100,999);
        // Console.Write($"{arr1 [i]} ");

        if(arr1[i] % 2 == 0)
        {
            
            count++;
        }
       
        Console.Write( arr1[i] + " ");
        
    }


Console.Write(" \n ");
Console.Write($"Число четных чисел в массиве = {count}");


