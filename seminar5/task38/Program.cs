//  **Задача 38:** Задайте массив натуральных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());// размер
int[] numbers = new int[size];// создание массива
FillArrayNaturalNumbers(numbers);
Console.WriteLine("Массив: ");
PrintArray(numbers);
MinMaxDifference(numbers);

void MinMaxDifference(int[] numbers) //метод вычисления разницы 
{
    Console.WriteLine("Max: " + numbers.Max()); 
    Console.WriteLine("Min: " + numbers.Min());
    int difference = numbers.Max() - numbers.Min();
    Console.WriteLine($"Difference: {difference}");
}

void FillArrayNaturalNumbers(int[] numbers) // метод заполнения массива 
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(1, 1000);
    }
}

void PrintArray(int[] numbers) // метод вывода массива в консоль
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.WriteLine();
}



