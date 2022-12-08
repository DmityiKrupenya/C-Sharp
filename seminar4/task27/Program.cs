// **Задача 27:** Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());

int suma = 0;
if (n > 0)
{
while(n > 0)
{
    int digit = n % 10;
    suma = suma + digit;
    n = n / 10;
}
Console.WriteLine($"Сумма: {suma}");
}
else 
{
    Console.WriteLine("Введите положительное число");
}
