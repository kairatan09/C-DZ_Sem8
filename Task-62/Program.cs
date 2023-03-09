// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


void FillArray(int[,] array)
{
  array[0, 0] = 1;
  for (int x = 0; x < array.GetLength(0) / 2 + 1; x++)
  {
    for (int j = x; j < array.GetLength(1) - x; j++)
    {
      if (j == 0)
        array[x, j + 1] = array[x, j] + 1;
      else
        array[x, j] = array[x, j - 1] + 1;
    }
    for (int i = x + 1; i < array.GetLength(0) - x; i++)
      array[i, array.GetLength(0) - 1 - x] = array[i - 1, array.GetLength(0) - 1 - x] + 1;
    for (int j = array.GetLength(1) - 2 - x; j >= 0 + x; j--)
      array[array.GetLength(1) - 1 - x, j] = array[array.GetLength(1) - 1 - x, j + 1] + 1;
    for (int i = array.GetLength(0) - 2 - x; i >= 1 + x; i--)
      array[i, x] = array[i + 1, x] + 1;
  }
}

void PrintArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
      Console.Write($"{array[i, j],4} \t");
    Console.WriteLine();
  }
}



try
{
  Console.Write("Введите число:\t");
  int n = Convert.ToInt32(Console.ReadLine());
  int[,] array = new int[n, n];
  FillArray(array);
  Console.WriteLine($"\nМассив {n} x {n} заполненный спирально с 1 до {n * n}:\t");
  PrintArray(array);
}

catch
{
  Console.WriteLine("Были введены некорректные данные.");
}
