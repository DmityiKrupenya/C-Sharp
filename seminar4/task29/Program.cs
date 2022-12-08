// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 
// Данные вводятся с консоли пользователем

int size = 8;
int[] array = new int[8];
Random myRandom = new Random();

Console.WriteLine("Массив из 8 чисел");
for (int i = 0; i < array.Length; i++)
{
    array[i] = myRandom.Next(0, 8);
    Console.Write("{0} ", array[i]);
}