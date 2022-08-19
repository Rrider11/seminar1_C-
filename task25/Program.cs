// Напишите цикл, который принимает на вход два числа (A и B) и возводит
//  число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.WriteLine("Введите число a");

double a = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите натуральное число b");

double b = Convert.ToDouble(Console.ReadLine());


while(b > 0)
{
    double ab = (Math.Pow(a,b));
    Console.Write( ab );
    break;

}

    Console.Write( "число B должно быть > 0" );






