// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
Console.WriteLine("Введите координаты X, Y, Z точки A :");
Console.Write("X= ");
double XA=Convert.ToInt32(Console.ReadLine());
Console.Write("Y= ");
double YA=Convert.ToInt32(Console.ReadLine());
Console.Write("Z= ");
double ZA=Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Введите координаты X, Y, Z точки B :");
Console.Write("X= ");
double XB=Convert.ToInt32(Console.ReadLine());
Console.Write("Y= ");
double YB=Convert.ToInt32(Console.ReadLine());
Console.Write("Z= ");
double ZB=Convert.ToInt32(Console.ReadLine());

double dist = Math.Sqrt(Math.Pow(XB-XA,2)+Math.Pow(YB-YA,2)+Math.Pow(ZB-ZA,2));
Console.WriteLine(dist);