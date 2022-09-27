// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
Console.WriteLine("Введите количество строк в массиве");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в массиве");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите строку необходимого элемента");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите столбец необходимого элемента");
int y = Convert.ToInt32(Console.ReadLine());
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
if ((x<=m) && (y<=n))
Console.Write("Запрашиваемый элемент - {0} ", massiv[x,y]);
else
Console.Write("Запрашиваемого элемента нет в данном массиве");