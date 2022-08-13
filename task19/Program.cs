// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("Введите пятизначное число");

int a = Convert.ToInt32(Console.ReadLine());

if ( 10000 <= a & a <= 99999 )
{   string b = a.ToString();
    int[] arrInt = new int[b.Length];
    for(int n = 0; n < b.Length; ++n)
    { 
    arrInt[n] = int.Parse(b[n]+ "");
    }

        if( b[0] == b[4] && b[1] == b[3])
        {
        Console.WriteLine("Число " + a + " является полиндромом");
            
        }
        else
        {
        Console.WriteLine("Число " + a + " не является полиндромом");
            
        }
}

else
{
    Console.WriteLine("Ошибка! ВВедите 5ти значное число, например: 12345");
}
