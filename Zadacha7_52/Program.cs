// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Console.WriteLine("Введите количество строк в массиве");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в массиве");
int n = Convert.ToInt32(Console.ReadLine());
float[] SrArifm = new float [n];
int[,] massiv = new int[m,n];

for (int i=0; i<n; i++)
    {
    SrArifm[i] = 0;
    }

for (int i=0; i<m; i++)
{
    for (int j=0; j<n; j++)
    {
    massiv[i,j] = Convert.ToInt32(Console.ReadLine());
    SrArifm[j] = SrArifm[j] + (float)massiv[i,j]/(float)m;
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
 for (int j=0; j<n; j++)
    {
    Console.Write("{0} ", Math.Round(SrArifm[j],1));
    }