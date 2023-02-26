// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.  
// A (3,6); B (2,1) -> 5,09  A (7,-5); B (1,-1) -> 7,21

Console.Clear();

Console.WriteLine("Введите координаты точки A: ");
Console.Write("X ");
int aX = int.Parse(Console.ReadLine());
Console.Write("Y ");
int aY = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты точки B: ");
Console.Write("X ");
int bX = int.Parse(Console.ReadLine());
Console.Write("Y ");
int bY = int.Parse(Console.ReadLine());


double d = Math.Sqrt(Math.Pow((bX - aX), 2) + Math.Pow((bY - aY), 2));

Console.WriteLine($"Расстояние между точками А и В равно {d}");
