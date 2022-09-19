// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
Console.WriteLine("Введите количество элементов в массиве");
int N = Convert.ToInt32(Console.ReadLine());
int[] massiv = new int[N];
int chet = 0;
Random rnd = new Random();
for (int i=0; i<N; i++)
{
    massiv[i] = rnd.Next(100, 999);
    if (massiv[i]%2==0)
    {
        chet=chet+1;
    }
}
for (int i=0; i<N; i++)
{
    Console.Write("{0} ", massiv[i]);
}
Console.WriteLine("");
Console.WriteLine(chet);