//Задача 9. Напишите программу, которая выводит случайное число из отрезка [10, 99] 
//и показывает наибольшую цифру числа.
//78 -> 8
//12-> 2
//85 -> 8

int a = new Random().Next(10, 100);
Console.WriteLine(a);
int number1 = a % 10;
int number2 = a / 10;
if (number1 > number2)
{
    Console.WriteLine(number1);
}
else 
{
    Console.WriteLine(number2);
}
Console.WriteLine($"Первая цифра = {number1}, вторая цифра = {number2}");