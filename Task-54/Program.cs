// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

void FillArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
    for (int j = 0; j < array.GetLength(1); j++)
      array[i, j] = new Random().Next(-20, 20);
}

void PrintArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
      Console.Write($"{array[i, j],3} \t");
    Console.WriteLine();
  }
}

int[,] SortArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
    for (int j = 0; j < array.GetLength(1); j++)
    {
      int MaxIndexi = i;
      int MaxIndexj = j;
      for (int CurrentIndexj = j; CurrentIndexj < array.GetLength(1); CurrentIndexj++)
        if (array[i, CurrentIndexj] > array[MaxIndexi, MaxIndexj])
          MaxIndexj = CurrentIndexj;
      (array[i, j], array[MaxIndexi, MaxIndexj]) = (array[MaxIndexi, MaxIndexj], array[i, j]);
    }
  return array;
}


try
{
  Console.WriteLine("Введите количество строк");
  int rows = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine("Введите количество столбцов");
  int cols = Convert.ToInt32(Console.ReadLine());
  int[,] array = new int[rows, cols];
  FillArray(array);
  PrintArray(array);
  Console.WriteLine();
  PrintArray(SortArray(array));
}

catch
{
  Console.WriteLine("Были введены некорректные данные.");
}