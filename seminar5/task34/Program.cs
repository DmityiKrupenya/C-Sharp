// - [ ]  Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine()); 
int[] numbers = new int[size];  //создание массива
FillArrayRandomNumbers(numbers); 
Console.WriteLine("Массив: ");
PrintArray(numbers);
int count = 0;

for (int z = 0; z < numbers.Length; z++) // нахождение четных чисел
if (numbers[z] % 2 == 0) // четность числа
count++;

Console.WriteLine($"всего {numbers.Length} чисел, чётные: {count} ");

void FillArrayRandomNumbers(int[] numbers) // метод заполнения массива 
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,1000); 
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