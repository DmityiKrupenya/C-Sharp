// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: 
// каждая сторона треугольника меньше суммы двух других сторон.

/*
1.Ввод  а б с 
сумма1 = а + б
сумма2 = б + с 
сумма3 = а + с
2.если (сумма1 > c)

*/
Console.WriteLine("Enter a");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter b");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter c");
int c = Convert.ToInt32(Console.ReadLine());

int sum1 = a + b;
int sum2 = b + c;
int sum3 = a + c;
if (sum1 > c)
{
    if (sum2 > a)
    {
        if (sum3 > b)
        {
            Console.WriteLine("Существует");
        }
        else
        {
            Console.WriteLine("Не существует");
        }
    }
    else
    {
        Console.WriteLine("Не существует");
    }
}
else
{
    Console.WriteLine("Не существует");
}

