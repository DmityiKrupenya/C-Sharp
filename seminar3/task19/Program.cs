// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("Введите число для проверки на полиндром");
string num = Console.ReadLine();

void CheckNum(string num)
{
  if (num[0]==num[4] || num[1]==num[3]){
    Console.WriteLine($"Ваше число: {num} - палиндром.");
  }
  else Console.WriteLine($"Ваше число: {num} - НЕ палиндром.");
}

if (num.Length == 5){
  CheckNum(num);
}
else Console.WriteLine($"Введите правильное число");