// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


int[] arr1 = new int[6];
int length = arr1.Length;
int index = 0;
int sum = 0;

while(index < length)
{
    arr1 [index] = new Random().Next (1,100);
    index++;  
     
}

for (int i = 1; i < length;  i+=2)
    {
        
        sum += arr1[i];
       
    }

Console.Write(string.Join( ",", arr1 ));
Console.Write(" \n ");
Console.Write($"Сумма чисел на нечётных позициях = {sum}");