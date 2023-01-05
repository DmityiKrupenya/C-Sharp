Console.Clear();
Console.WriteLine("Введите размеры матрицы и диапазон");

int m1 = EnterNum("Введите число строк 1 матрицы:");
int n12 = EnterNum("Введите число столбцов 1 матрицы и строк 2 матрицы:");
int m2 = EnterNum("Введите число столбцов 2 матрицы ");
int ran = EnterNum("Введите диапазон случайных чисел от 1 до N");

int[,] matrix1 = new int[m1, n12]; // создание 1 матрицы
CreArr(matrix1);
Console.WriteLine("Первая матрица");
WriteArr(matrix1);

int[,] matrix2 = new int[n12, m2]; // создание 2 матрицы
CreArr(matrix2);
Console.WriteLine("Вторая матрица");
WriteArr(matrix2);

int[,] matrixResult = new int[m1, m2];

MultiplyMatrix(matrix1, matrix2, matrixResult);
Console.WriteLine("Произведение первой и второй матрицы:");
WriteArr(matrixResult);

void MultiplyMatrix(int[,] matrix1, int[,] matrix2, int[,] matrixResult)// Метод произведения 2 матриц
{
  for (int i = 0; i < matrixResult.GetLength(0); i++)// но что то в нем не работает, Скопировал его с github
  {
    for (int j = 0; j < matrixResult.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < matrix1.GetLength(1); k++)
      {
        sum += matrix1[i,k] * matrix2[k,j];
      }
      matrixResult[i,j] = sum;
    }
  }
}

void WriteArr(int[,] arr) // распечатка массива в консоль
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void CreArr(int[,] arr) // создание массива
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(ran);
        }
    }
}


int EnterNum(string input) // ввод чисел в консоль
{
    Console.WriteLine(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}