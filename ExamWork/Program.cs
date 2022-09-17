// Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
//  длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
//   либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
//    лучше обойтись исключительно массивами.


string[] source = new string[5] { "Moscow", "Party", "SanFrancisco", "Hello", "NewYork" };
var random = new Random(DateTime.Now.Millisecond);
source = source.OrderBy(x => random.Next()).ToArray(); // каждый раз перемешиваем массив чтобы получались разные значения

Random rnd = new Random();
int a = rnd.Next(4);
Console.WriteLine(a); // рандомим значение размера массива

string[] target = new string[a];
Array.Copy(source, target, a); // копируем один массив из другого

for (int i = 0; i < target.Length; i++)
{
    Console.Write($"{target[i]} ");
}
