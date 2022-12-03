// Задача 21

// Напишите программу, которая принимает на вход координаты 
//двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("enter xA");
double xA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter yA");
double yA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter zA");
double zA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter xB");
double xB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter yB");
double yB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter zB");
double zB = Convert.ToInt32(Console.ReadLine());

double resX = Math.Pow(xB - xA, 2);
double resY = Math.Pow(yB - yA, 2);
double resZ = Math.Pow(zB - zA, 2);
double result = Math.Sqrt(resX+resY+resZ);
Console.WriteLine($"{result:f4}");

