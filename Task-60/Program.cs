// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


void FillArray(int[,,] array)
{
  int[] array1 = new int[array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];
  int temp;
  for (int i = 0; i < array1.GetLength(0); i++)
  {
    array1[i] = new Random().Next(10, 100);
    temp = array1[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (array1[i] == array1[j])
        {
          array1[i] = new Random().Next(10, 100);
          j = 0;
          temp = array1[i];
        }
        temp = array1[i];
      }
    }
  }
  int count = 0;
  for (int x = 0; x < array.GetLength(0); x++)
  {
    for (int y = 0; y < array.GetLength(1); y++)
    {
      for (int z = 0; z < array.GetLength(2); z++)
      {
        array[x, y, z] = array1[count];
        count++;
      }
    }
  }
}

void PrintArray(int[,,] array)
{
  for (int k = 0; k < array.GetLength(2); k++)
    for (int i = 0; i < array.GetLength(0); i++)
    {
      for (int j = 0; j < array.GetLength(1); j++)
        Console.Write($"{array[i, j, k],2}({i}, {j}, {k}) \t");
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
  Console.WriteLine("Были введены некорректные данные");
}