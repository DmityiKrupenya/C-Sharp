// Задача 24: Напишите программу,
// которая принимает на вход число (А) 
// и выдаёт сумму чисел от 1 до А.7 -> 28
//4 -> 10
//8 -> 36

// Console.WriteLine("Введите число");
// int nA = Convert.ToInt32(Console.ReadLine());

bool Validate(int number)
{
    if (number > 2)
    {
        return true;
    }
    else
    {
        return false;
    }
}

int Sum1ToA(int A)
{
    int sum = 0;
    for (int i = 1; i <= A; i++)
    {

        sum += 1;  //sum = sum + 1;
    }
    return sum;
}

int GetNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int number = GetNumber("Введите число");
bool isCorrect = Validate(number);
if (isCorrect == true)
{
    int sum = Sum1ToA(number);
    Console.WriteLine($"Сумма чисел от 1 до {number} = {sum}");
}
else
{
    Console.WriteLine($"Невозможно получить сумму от 1 до {number}");
}
