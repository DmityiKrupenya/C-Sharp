// - [ ]  **Задача 36:** Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size]; // создание массива
FillArrayRandomNumbers(numbers);
Console.WriteLine("Массив: ");
PrintArray(numbers);
int sum = 0;

for (int i = 0; i < numbers.Length; i = i + 2)
{
    sum = sum + numbers[i];
}
Console.WriteLine(sum);


void FillArrayRandomNumbers(int[] numbers) // метод заполнения массива 
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(-1000, 1000); 
    }
}

void PrintArray(int[] numbers) // метод вывода массива в консоль
{
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.WriteLine();
}
