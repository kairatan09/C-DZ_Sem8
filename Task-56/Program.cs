// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


void FillArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
    for (int j = 0; j < array.GetLength(1); j++)
      array[i, j] = new Random().Next(1, 100);
}

void PrintArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++) Console.Write($"{array[i, j],4} \t");
    Console.WriteLine();
  }
}

void MinSumRowElement(int[,] array)
{
  int[] array1 = new int[array.GetLength(0)];
  for (int i = 0; i < array.GetLength(0); i++)
    for (int j = 0; j < array.GetLength(1); j++)
      array1[i] += array[i, j];
  int Min = array1[0];
  int MinIndex = 0;
  for (int m = 0; m < array1.Length; m++) if (array1[m] < Min) { Min = array1[m]; MinIndex = m; }
  Console.WriteLine($"\nСтрока массива с минимальной суммой элементов - {MinIndex + 1} строка.");
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
  MinSumRowElement(array);
}

catch
{
  Console.WriteLine("Были введены некорректные данные.");
}

