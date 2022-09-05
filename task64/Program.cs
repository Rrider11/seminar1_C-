// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в 
// промежутке от N до 1 (используйте рекурсию).
// N = 5 -> 5, 4, 3, 2, 1


Console.WriteLine("Введите число от 1 до 7");
int N = Convert.ToInt32(Console.ReadLine());

string NumbersFor(int N)
{
    string result = String.Empty;
    for (int i = N; i >= 0; i--)
    {
        result += $"{i} ";
    }

    return result;
}

string NumbersRec( int N)
{
  if( N >= 0 ) return $"{N} " + NumbersRec(N - 1);
  else return String.Empty;
}

Console.WriteLine(NumbersFor(N));

Console.WriteLine(NumbersRec(N));