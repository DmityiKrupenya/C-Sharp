// Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.Clear();
int m = EnterNum("Введите m: ");
int n = EnterNum("Введите n: ");
int ran = EnterNum("Введите диапазон: от 1 до ");

int[,] arr = new int[m, n];
CreArr(arr);
WriteArr(arr);

int minSumLine = 0;
int sumLine = SumLineElements(arr, 0);
for (int i = 1; i < arr.GetLength(0); i++)
{
  int tempSumLine = SumLineElements(arr, i);
  if (sumLine > tempSumLine)
  {
    sumLine = tempSumLine;
    minSumLine = i;
  }
}

Console.WriteLine($"\n{minSumLine+1} - строкa с меньшей суммой ({sumLine}) элементов ");


int SumLineElements(int[,] arr, int i)
{
  int sumLine = arr[i,0];
  for (int j = 1; j < arr.GetLength(1); j++)
  {
    sumLine += arr[i,j];
  }
  return sumLine;
}

int EnterNum(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void CreArr(int[,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++) // i - индекс строки 
  {
    for (int j = 0; j < arr.GetLength(1); j++) // j - индекс столбца
    {
      arr[i, j] = new Random().Next(ran);
    }
  }
}

void WriteArr (int[,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      Console.Write(arr[i,j] + " ");
    }
    Console.WriteLine();
  }
}