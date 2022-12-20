// // Задача 47. Задайте двумерный массив размером m×n, заполненный случайными 
// // вещественными числами.
// // ​
// // m = 3, n = 4.
// // ​
// // 0,5 7 -2 -0,2
// // ​
// // 1 -3,3 8 -9,9
// // ​
// // 8 7,8 -7,1 9
// // ​

Console.WriteLine("Введите число строк");
int numOfLine = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число столбцов");
int numOfCol = Convert.ToInt32(Console.ReadLine());

double[,] arr = new double[numOfLine, numOfCol];
FillArray(arr);
PrintArray(arr);

void FillArray(double[,] arr) //метод заполнения массива
{
    for (int i = 0; i < arr.GetLength(0); i++)// шаг в строках
    {
        for (int y = 0; y < arr.GetLength(1); y++)// шаг в столбцах
        {
            arr[i, y] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;// 
        }
    }
}

void PrintArray(double[,] arr) // метод распечатывания массива
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int y = 0; y < arr.GetLength(1); y++)
        {
            Console.Write(arr[i, y] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

