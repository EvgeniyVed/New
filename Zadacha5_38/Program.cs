// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
Console.WriteLine("Введите количество элементов в массиве");
int N = Convert.ToInt32(Console.ReadLine());
int[] massiv = new int[N];
int max = -10000000;
int min = 10000000;
Random rnd = new Random();
for (int i=0; i<N; i++)
{
    massiv[i] = rnd.Next(-100,100);
    if (massiv[i]>max)
    {
        max=massiv[i];
    }
    if (massiv[i]<min)
    {
        min=massiv[i];
    }
}
for (int i=0; i<N; i++)
{
    Console.Write("{0} ", massiv[i]);
}
Console.WriteLine("");
Console.WriteLine(max);
Console.WriteLine(min);
Console.WriteLine(max-min);
