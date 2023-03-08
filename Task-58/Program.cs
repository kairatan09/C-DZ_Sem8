// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


void FillArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
    for (int j = 0; j < array.GetLength(1); j++)
      array[i, j] = new Random().Next(1, 5);
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

int[,] ProductMatrix(int[,] mass1, int[,] mass2)
{
  int[,] result = new int[mass1.GetLength(0), mass2.GetLength(1)];
  for (int i = 0; i < result.GetLength(0); i++)
    for (int j = 0; j < result.GetLength(1); j++)
      for (int x = 0; x < mass1.GetLength(1); x++)
        result[i, j] += mass1[i, x] * mass2[x, j];
  return result;
}


try
{
  Console.Write("Введите количество строк матрицы #1:\t");
  int rows1 = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите количество столбцов матрицы #2:\t");
  int cols1 = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите количество строк матрицы #2:\t");
  int rows2 = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите количество столбцов матрицы #2:\t");
  int cols2 = Convert.ToInt32(Console.ReadLine());
  if (cols1 == rows2)
  {
    int[,] array1 = new int[rows1, cols1];
    int[,] array2 = new int[rows2, cols2];
    FillArray(array1);
    Console.WriteLine("\nМатрица #1:");
    PrintArray(array1);
    FillArray(array2);
    Console.WriteLine("\nМатрица #2:");
    PrintArray(array2);
    Console.WriteLine("\nПроизведение двух матриц:");
    PrintArray(ProductMatrix(array1, array2));
  }
  else
  {
    Console.WriteLine("\nБыли введены некорректные данные. Число столбцов первой матрицы должно быть равно числу строк второй матрицы.");
  }
}

catch
{
  Console.WriteLine("Были введены некорректные данные.");
}