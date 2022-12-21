// Задача 50. Напишите программу, которая на вход принимает позиции элемента в 
//двумерном массиве, и возвращает значение этого элемента или же указание,
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// ​
// 5 9 2 3
// ​
// 8 4 2 4 ​
// 1 7 -> такого числа в массиве нет

Console.WriteLine("Введите количество строк в массиве");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в массиве");
int y = Convert.ToInt32(Console.ReadLine());

int[,] arr = new int[x, y];// обьявим массив
Random ran = new Random();
void InitializingMas(int[,] arr)
{
    //инициализация данного массива
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            arr[i, j] = ran.Next(1, 35);
        }
    }
}
void PrintArray(int[,] arr) // метод распечатывания массива
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
InitializingMas(arr);
PrintArray(arr);

Console.WriteLine("Введите 1 координату в массиве");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите 2 координату в массиве");
int b = Convert.ToInt32(Console.ReadLine());
if (a > x && b > y)
{
    Console.WriteLine("такого числа нет");
}
else
{
    object? c = arr.GetValue(a, b);
    Console.WriteLine(c); 
}






