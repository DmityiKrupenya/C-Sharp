// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или 
//сообщает, что третьей цифры нет.
// ​
// 645 -> 5
// ​
// 78 -> третьей цифры нет
// ​
// 32679 -> 6

Console.Write("Введи число: ");
int number = Convert.ToInt32(Console.ReadLine());
while (number > 999)
{
number = number / 10;
}
int num3 = number % 10;
if(num3 <= 0)
{
  Console.WriteLine(num3);
}
else{
  Console.WriteLine("Нет третьей цифры");
}
