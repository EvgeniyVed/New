// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
Console.WriteLine("Введите количество элементов в массиве");
int N = Convert.ToInt32(Console.ReadLine());
int[] massiv = new int[N];
int chet = 0;
Random rnd = new Random();
for (int i=0; i<N; i++)
{
    massiv[i] = rnd.Next(-100,100);
    if (i%2 != 0)
    {
        chet=chet+massiv[i];
    }
}
for (int i=0; i<N; i++)
{
    Console.Write("{0} ", massiv[i]);
}
Console.WriteLine("");
Console.WriteLine(chet);
