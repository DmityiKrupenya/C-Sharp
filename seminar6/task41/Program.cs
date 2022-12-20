// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь. 
// Ввод чисел останавливается при помощи ввода стоп-слова "stop"

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3
Counting();
void Counting()
{
    int count = 0;
    while (true)
    {
        Console.Write("Enter number or \"stop\": ");
        string word = Console.ReadLine()!.ToLower();
        if (word == "stop")
        {
            break;
        }
        else
        {
            int number = Convert.ToInt32(word);
            if (number > 0)
            {
                count++;
            }
        }
    }
    Console.WriteLine($"Положительных чисел {count}");
}