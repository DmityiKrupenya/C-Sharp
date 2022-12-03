// Задача 11: Напишите программу, которая выводит случайное трёхзначное число и 
//удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int a = new Random().Next(100, 1000);
Console.WriteLine(a);
int num3 = a % 10;
int num1 = a / 100;

Console.WriteLine(num1);
Console.WriteLine(num3);

Console.WriteLine($"Искомое число = {num1 * 10 + num3}");   