// Задача 47. Задайте двумерный массив 
// размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Write(" введите m: ");
int m = Convert.ToInt32(System.Console.ReadLine());
Console.Write(" введите n: ");
int n = Convert.ToInt32(System.Console.ReadLine());

int[,] array = new int[m, n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i,j] = new Random().Next(-10, 10);
    }
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        System.Console.WriteLine(array[i,j]);
    }
    System.Console.WriteLine("");
}