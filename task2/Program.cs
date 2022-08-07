
Console.WriteLine("Введите целое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое число");
int b = Convert.ToInt32(Console.ReadLine());

int max = a;

if( a > b ) max = a;
if(b > a) max = b;


Console.WriteLine("Max =" + " " + max);

