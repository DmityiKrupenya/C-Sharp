

float k1, b1;
float k2, b2;
float x, y;
Console.WriteLine("Введите k1:");
k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b1:");
b1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите k2:");
k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b2:");
b2 = Convert.ToInt32(Console.ReadLine());

if ((k1 == k2) && (b1 == b2))
{
    Console.WriteLine("Прямые совпадают");
}
else if (k1 == k2)
{
    Console.WriteLine("Прямые совпадают");
}
else
{
    x = (b2 - b1) / (k1 - k2);
    y = (k1 * (b2 - b1)) / (k1 - k2) + b1;
    Console.WriteLine($"x={x} y={y}");

}
return 0;
