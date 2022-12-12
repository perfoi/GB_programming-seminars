// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

double x1 = C ("x", "A");
double y1 = C ("y", "A");
double z1 = C ("z", "A");
double x2 = C ("x", "B");
double y2 = C ("y", "B");
double z2 = C ("z", "B");
int C (string Name, string point)
{
Console.WriteLine($"Введите координату {Name} точки {point}: ");
return Convert.ToInt16(Console.ReadLine());
}
double Res(double x1, double x2, double y1, double y2, double z1, double z2)
{
return Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2) + Math.Pow((z2-z1), 2));
}
double segment =  Math.Round (Res(x1, x2, y1, y2, z1, z2), 2 );
Console.WriteLine($"Длина отрезка:  {segment}");