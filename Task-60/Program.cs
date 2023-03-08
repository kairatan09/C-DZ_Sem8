// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


void FillArray(int[,,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
    for (int j = 0; j < array.GetLength(1); j++)
      for (int k = 0; k < array.GetLength(2); k++)
        array[i, j, k] = new Random().Next(1, 20);
}

void PrintArray(int[,,] array)
{
  for (int k = 0; k < array.GetLength(2); k++)
    for (int i = 0; i < array.GetLength(0); i++)
    {
      for (int j = 0; j < array.GetLength(1); j++)
        Console.Write($"{array[i, j, k],3}({i}, {j}, {k}) \t");
      Console.WriteLine();
    }
}



try
{
  Console.Write("Введите количество строк:\t");
  int rows = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите количество столбцов:\t");
  int cols = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите количество глубины:\t");
  int depth = Convert.ToInt32(Console.ReadLine());
  int[,,] array = new int[rows, cols, depth];
  FillArray(array);
  Console.WriteLine($"\nМассив размером {rows} x {cols} x {depth}");
  PrintArray(array);
}

catch
{
  Console.WriteLine("Были введены некорректные данные.");
}