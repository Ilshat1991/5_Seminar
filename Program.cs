// Задача 1

// void FillArray2(int[,] Arr)
// {
//     for (int i = 0; i < Arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < Arr.GetLength(1); j++)
//         {
//             Arr[i, j] = new Random().Next(1, 100);

//         }

//     }
// }

// void PrintArray2(int[,] Arr)
// {
//     for (int i = 0; i < Arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < Arr.GetLength(1); j++)
//         {
//             Console.Write(Arr[i, j] + " ");
//         }

//         Console.WriteLine();
//     }
// }

// void FindNumInArr (int[ , ] Arr)
// {
//     Console.WriteLine("Введите номер строки");
//     int n = int.Parse(Console.ReadLine()!);
//     Console.WriteLine("Введите номер столбца");
//     int m = int.Parse(Console.ReadLine()!);
//     if (n-1 > Arr.GetLength(0) || m-1 > Arr.GetLength(1)) Console.WriteLine("Такого элемента нет");
//     else Console.WriteLine(Arr[n-1,m-1]);
// }


// int[,] array = new int[4, 5];
// FillArray2(array);
// PrintArray2(array);
// FindNumInArr(array);


// Задача 2

// void FillArray2(int[,] Arr)
// {
//     for (int i = 0; i < Arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < Arr.GetLength(1); j++)
//         {
//             Arr[i, j] = new Random().Next(1, 100);

//         }

//     }
// }

// void PrintArray2(int[,] Arr)
// {
//     for (int i = 0; i < Arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < Arr.GetLength(1); j++)
//         {
//             Console.Write(Arr[i, j] + " ");
//         }

//         Console.WriteLine();
//     }
// }

// void RevStrArr(int[,] Arr)
// {
//     for (int j = 0; j < Arr.GetLength(1); j++)
//     {
//         Arr[0, j] = Arr[0, j] + Arr[Arr.GetLength(0)-1, j];
//         Arr[Arr.GetLength(0)-1, j] = Arr[0, j] - Arr[Arr.GetLength(0)-1, j];
//         Arr[0, j] = Arr[0, j] - Arr[Arr.GetLength(0)-1, j];
//     }
// }

// int[,] array = new int[5, 5];
// FillArray2(array);
// PrintArray2(array);
// RevStrArr(array);
// Console.WriteLine();
// PrintArray2(array);


// Задача 3

// void FillArray2(int[,] Arr)
// {
//     for (int i = 0; i < Arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < Arr.GetLength(1); j++)
//         {
//             Arr[i, j] = new Random().Next(1, 100);

//         }

//     }
// }

// void PrintArray2(int[,] Arr)
// {
//     for (int i = 0; i < Arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < Arr.GetLength(1); j++)
//         {
//             Console.Write(Arr[i, j] + " ");
//         }

//         Console.WriteLine();
//     }
// }
// int[,] array = new int [5,5];

// int FindMinStr (int[,] Arr)
// {
//     int sum = 0;
//     for (int j = 0; j < Arr.GetLength(1); j++) sum +=Arr[0,j];
//     int min = sum;
//     int x = 0;
//     Console.WriteLine(sum);


//     for (int i = 1; i < Arr.GetLength(0); i++)
//     {
//         sum = 0;
//         for (int j = 0; j < Arr.GetLength(1); j++)
//         {
//             sum +=Arr[i,j];
//         }
//         Console.WriteLine(sum);
//         if (min > sum)
//         {
//             min = sum;
//             x = i;
//         }
//     }
//     return (x);
// }


// FillArray2(array);
// PrintArray2(array);
// int S = FindMinStr(array);
// Console.Write ("Минимальная сумма на строке № "+(S+1));

