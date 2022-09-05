// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N (используйте рекурсию).

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.WriteLine("Введите число A от 1 до 10");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B от 1 до 10");
int B = Convert.ToInt32(Console.ReadLine());

int SumFor(int A, int B)
{
    int result = 0;
    for (int i = A; i <= B; i++) result += i ;
  
    return result;
}

int SumRec( int A, int B)
{
  if( A > B ) return 0;
  else return A + SumRec(A+1,B);
}

Console.WriteLine(SumFor(A,B));

Console.WriteLine(SumRec(A,B));