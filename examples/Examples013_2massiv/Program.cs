﻿
// string[,] table = new string[2, 5];

// // String.Empty
// // table[0, 0] table[0, 1] table[0, 2] table[0, 3] table[0, 4]
// // table[1, 0] table[1, 1] table[0, 2] table[0, 3] table[0, 4]

// table[1, 2] = "слово";


// for (int rows = 0; rows < 2; rows++)
// {
//   for (int columns = 0; columns < 5; columns++)
//   {
//     Console.WriteLine($"-{table[rows, columns]}-");
//   }
// }


// void PrintArray(int[,] matr)
// {

//   for (int rows = 0; rows < matr.GetLength(0); rows++)
//   {
//     for (int columns = 0; columns < matr.GetLength(1); columns++)
//     {
//       Console.Write($"{matr[rows, columns]} ");
//     }
//     Console.WriteLine();
//   }
// }

// void FillArray(int[,] matr)
// {
//   for (int i = 0; i < matr.GetLength(0); i++)
//   {
//     for (int j = 0; j < matr.GetLength(1); j++)
//     {
//       matr[i,j] = new Random().Next(1,10);
//     }
//   }
// }

// int[,] matrix = new int[3, 4];
// PrintArray(matrix);
// FillArray(matrix);
// Console.WriteLine();
// PrintArray(matrix);

// int[,] pic = new int[,];


// void PrintImage(int[,] image)
// {
//   for (int rows = 0; rows < image.GetLength(0); rows++)
//   {
//     for (int columns = 0; columns < image.GetLength(1); columns++)
//     {
//       if (image[rows, columns] == 0) Console.Write($" ");
//       else Console.Write($"+");
//     }
//   }
// }

// void FillImage (int row, int col)
// {
//   if(pic[row,col] = 1);
//   {
//     pic[row, col] = 1;
//   FillImage(row-1, col);
//   FillImage(row, col-1);
//   FillImage(row+1, col);
//   FillImage(row, col+1);
//   }
// }

// double Factorial (int n)
// {
//   if(n == 1) return 1;
//   else return n * Factorial(n-1);
// }

// for (int i = 1; i < 40; i++)
// {
//   Console.WriteLine($"{i}! = {Factorial(i)}");
// }


// f(1) =1;
// f(2) = 1;
// f(n) = f(n-1) + f(n-2);

// double Fibonacci(int n)
// {
//   if(n == 1 || n == 2) return 1;
//   else return Fibonacci(n-1) + Fibonacci(n-2);
// }

// for (int i = 1; i < 60; i++)
// {
//   Console.WriteLine($"f{i} = {Fibonacci(i)}");
// }


// обход папки (все папки внутри)
