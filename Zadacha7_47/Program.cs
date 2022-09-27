// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
Console.WriteLine("Введите количество строк в массиве");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в массиве");
int n = Convert.ToInt32(Console.ReadLine());
int[,] massiv = new int[m,n];
Random rnd = new Random();
for (int i=0; i<m; i++)
{
    for (int j=0; j<n; j++)
    {
    massiv[i,j] = rnd.Next(-100,100);
    }
}
for (int i=0; i<m; i++)
{
    for (int j=0; j<n; j++)
    {
    Console.Write("{0} ", massiv[i,j]);
    }
    Console.WriteLine();
}