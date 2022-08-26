// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3




int[] mass = new int[5];
int countPlus = 0;

for (int i = 0; i < mass.Length; i++)
{
    mass[i] = int.Parse(Console.ReadLine());

    // Console.Write(string.Join(",", mass));

    

    if (mass[i] > 0)
    {
        countPlus++;
    }
}


Console.Write($"Число положительных чисел в массиве = {countPlus}");
