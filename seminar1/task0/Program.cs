// // Нап прог, которая на вход принимает 2 числа и проверяет является ли 1 число квадратом второго
// а = 25,b = 5 ->да
// a = 2, b = 10 ->нет 

Console.WriteLine("Введите 1 число:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 число:");
int b = Convert.ToInt32(Console.ReadLine());
if (Convert.ToInt32(Math.Sqrt(a))==b)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}