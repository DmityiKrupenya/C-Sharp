//Задача 54: Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива.

Console.Clear();
Console.WriteLine($"\nВведите размер массива m x n и диапазон случайных значений:");
int m = EnterNum("Введите m: ");
int n = EnterNum("Введите n: ");
int ran = EnterNum("Введите числа: от 1 до ");

int[,] arr = new int[m, n];
CreArr(arr);
WriteArray(arr);

Console.WriteLine($"\nОтсортированный массив: ");
SortArrByLines(arr);
WriteArray(arr);

int EnterNum(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void CreArr(int[,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      arr[i, j] = new Random().Next(ran);
    }
  }
}

void WriteArray(int[,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      Console.Write(arr[i, j] + " ");
    }
    Console.WriteLine();
  }
}


void SortArrByLines(int[,] arr)//метод сортировки 
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int x = 0; x < arr.GetLength(1); x++)
    {
      for (int y = 0; y < arr.GetLength(1) - 1; y++)
      {
        if (arr[i, y] < arr[i, y + 1])
        {
          int temp = arr[i, y + 1];
          arr[i, y + 1] = arr[i, y];
          arr[i, y] = temp;
        }
      }
    }
  }
}