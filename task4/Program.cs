Console.WriteLine("Введите целое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое число");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое число");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if( a > max ) max = a;
if(b > max) max = b;
if(c > max) max = c;


Console.WriteLine("Max =" + " " + max);

