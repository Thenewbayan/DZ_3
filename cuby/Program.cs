// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
Console.WriteLine("Найдем таблицу кубов для любых чисел (от 1 до вашего числа), введите число");
int Number=Convert.ToInt32(Console.ReadLine());
int count=1;
double cube;
while (count<=Number)
{
    cube=Math.Pow(count,3);
    Console.Write(cube+" "+"\n");
    count=count+1;
}
Console.WriteLine($"Мы вывели значения всех кубов чисел от 1 до числа {Number}");