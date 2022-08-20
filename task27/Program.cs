// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.WriteLine("Введите число a");

string str1 = Console.ReadLine();
int[] arr1 = new int[str1.Length];
int sum = 0;
for(int n = 0; n < str1.Length; ++n)
{
    arr1[n] = int.Parse(str1[n]+ "");  
    sum += arr1[n]; 
}


// Console.WriteLine(string.Join("," , arr1));
Console.WriteLine(sum);



