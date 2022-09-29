// Задайте двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
int[,] VvodMassivInt (int Strtoka, int Stolbec)
{
    Console.WriteLine("Заполните массив");
    int[,] massiv = new int [Strtoka,Stolbec];
    for (int i=0; i<Strtoka; i++)
    {
        for (int j=0; j<Stolbec; j++)
        {
        massiv[i,j] = Convert.ToInt32(Console.ReadLine());
        }
    }
return massiv;
}
void VivodMassivInt (int[,] massiv, int Strtoka, int Stolbec)
{
    Console.WriteLine("Массив:");
    for (int i=0; i<Strtoka; i++)
    {
        for (int j=0; j<Stolbec; j++)
        {
        Console.Write("{0} ", massiv[i,j]);
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Введите размерность массива");
Console.WriteLine("Введите количество строк");
int Strok = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int Stolbcov = Convert.ToInt32(Console.ReadLine());
int[,] Massiv = new int [Strok,Stolbcov];
int[] MassivSummiStrok = new int [Strok];
int Min = 100000;
int MinIndex = 0;
Massiv = VvodMassivInt(Strok,Stolbcov);
for (int i=0; i<Strok; i++)
    {
        for (int j=0; j<Stolbcov; j++)
            {
            MassivSummiStrok[i]= MassivSummiStrok[i] + Massiv[i,j]; 
            }
        if (MassivSummiStrok[i]<Min) 
        {
            Min = MassivSummiStrok[i];
            MinIndex = i;
        }
    }
VivodMassivInt (Massiv,Strok,Stolbcov);
Console.Write("Строка с наименьшей суммой - {0} ", MinIndex+1);
