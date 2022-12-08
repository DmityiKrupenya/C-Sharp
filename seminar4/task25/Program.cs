// **Задача 25:** Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

int Exponentiation(int nA, int nB)
{
    int result = 1;
    for (int i = 1; i <= nB; i++)
    {
        result = result * nA;
    }
    return result;
}

Console.Write("Введите число A: ");
int nA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int nB = Convert.ToInt32(Console.ReadLine());

int exponentiation = Exponentiation(nA, nB);
Console.WriteLine("Ответ: " + exponentiation);