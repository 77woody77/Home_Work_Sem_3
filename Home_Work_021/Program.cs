// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
Console.WriteLine("Введите значение координаты: X");
int X = int.Parse(Console.ReadLine());

Console.WriteLine("Введите значение координаты: Y");
int Y = int.Parse(Console.ReadLine());

Console.WriteLine("Введите значение координаты: Z");
int Z = int.Parse(Console.ReadLine());

Console.WriteLine("Введите значение координаты: X1");
int X1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите значение координаты: Y1");
int Y1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите значение координаты: Z1");
int Z1 = int.Parse(Console.ReadLine());

double d = Math.Sqrt((X - X1)*(X - X1) + (Y - Y1)*(Y-Y1) + (Z - Z1)*(Z - Z1));
Console.WriteLine($"d = {d:f2}");
