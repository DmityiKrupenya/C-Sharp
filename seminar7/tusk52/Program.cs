// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.



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

void srAr(int[,] arr)
{
    for (int i = 0; i < y; i++)
    {
        int srAr = 0;
        for (int j = 0; j < x; j++)
        {   
            srAr += arr[j, i];
        }
        Console.WriteLine($"Среднее арифмитическое столбцов = {(float)srAr / y}");
    }
}
srAr(arr);
