//  Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
    

// Console.WriteLine("Enter string quantity");
// int linesVol = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter column quantity");
// int columnsVol = Convert.ToInt32(Console.ReadLine());
// double[,] numbers = new double[linesVol, columnsVol];
// FillArrayRandomNumbers(numbers);
// PrintArray(numbers);
// void FillArrayRandomNumbers(double[,] array)
// { for (int i = 0; i < array.GetLength(0); i++)
// { for (int j = 0; j < array.GetLength(1); j++)
// { array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;}
// }
// }
// void PrintArray(double[,] array)
// { for (int i = 0; i < array.GetLength(0); i++)
// { Console.Write("[ ");
// for (int j = 0; j < array.GetLength(1); j++)
// { Console.Write(array[i, j] + " "); }
// Console.Write("]");
// Console.WriteLine("");
// }
// }


// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет. 

// Console.WriteLine("Enter string number");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter column number");
// int m = Convert.ToInt32(Console.ReadLine());
// int [,] numbers = new int [5,5];
// FillArrayRandomNumbers(numbers);
// if (n > numbers.GetLength(0) || m > numbers.GetLength(1))
// { Console.WriteLine("such element doesn't exist"); }
// else
// { Console.WriteLine($"element value of {n} string and {m} column is equal: {numbers[n-1,m-1]}"); }
// PrintArray(numbers);
// void FillArrayRandomNumbers(int[,] array)
// { for (int i = 0; i < array.GetLength(0); i++) 
// { for (int j = 0; j < array.GetLength(1); j++)
// { array [i,j] = new Random().Next(-100, 100)/10;} 
// }
// }
// void PrintArray(int[,] array)
// {
// for (int i = 0; i < array.GetLength(0); i++)
// {
// Console.Write("[ ");
// for (int j = 0; j < array.GetLength(1); j++)
// {
// Console.Write(array[i,j] + " ");
// } 
// Console.Write("]");
// Console.WriteLine(""); 
// }
// }


// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце. 
// Console.WriteLine("Enter string quantity");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter column quantity");
// int m = Convert.ToInt32(Console.ReadLine());

// int[,] numbers = new int[n, m];
// FillArrayRandomNumbers(numbers);
// for (int j = 0; j < numbers.GetLength(1); j++)
// {
//     double avarage = 0;
//     for (int i = 0; i < numbers.GetLength(0); i++)
//     {
//         avarage = (avarage + numbers[i, j]);
//     }
//     avarage = avarage / n;
//     Console.Write(avarage + "; ");
// }
// Console.WriteLine();
// PrintArray(numbers);
// void FillArrayRandomNumbers(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(0, 10);
//         }
//     }
// }
// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Console.Write("[ ");
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.Write("]");
//         Console.WriteLine("");
//     }
// }
