// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53
Console.WriteLine("Найдем расстояние между точками в 3д системе координат");
Console.WriteLine("Введите координаты точки А в формате x,y,z после каждого числа нажимайте enter");
int XA=Convert.ToInt32(Console.ReadLine());
int YA=Convert.ToInt32(Console.ReadLine());
int ZA=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B в формате x,y,z после каждого числа нажимайте enter");
int XB=Convert.ToInt32(Console.ReadLine());
int YB=Convert.ToInt32(Console.ReadLine());
int ZB=Convert.ToInt32(Console.ReadLine());
var CORD=Math.Sqrt((Math.Pow(XA-XB, 2)+Math.Pow(YA-YB, 2)+Math.Pow(ZA-ZB, 2)));
Console.WriteLine(Math.Round(CORD,2));
