// Задайте две квадратные матрицы одного размера. Напишите программу, которая будет находить произведение двух матриц.
int[,] VvodMassivInt (int Strtoka, int Stolbec, bool PustoiMassiv)
{
    Console.WriteLine("Заполните массив");
    int[,] massiv = new int [Strtoka,Stolbec];
    for (int i=0; i<Strtoka; i++)
    {
        for (int j=0; j<Stolbec; j++)
        {
        if (PustoiMassiv)  
        massiv[i,j] = 0;
        else
        {
        massiv[i,j] = Convert.ToInt32(Console.ReadLine());
        }
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
Console.WriteLine("Введите размерность массивов ");
int RazmernostMassiva = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите массив 1");
int[,] Massiv1 = new int [RazmernostMassiva,RazmernostMassiva];
Massiv1 = VvodMassivInt(RazmernostMassiva,RazmernostMassiva,false);
Console.WriteLine("Введите массив 2");
int[,] Massiv2 = new int [RazmernostMassiva,RazmernostMassiva];
Massiv2 = VvodMassivInt(RazmernostMassiva,RazmernostMassiva,false);
int[,] MassivItog = new int [RazmernostMassiva,RazmernostMassiva];
MassivItog = VvodMassivInt(RazmernostMassiva,RazmernostMassiva,true);
for (int i=0; i<RazmernostMassiva; i++)
    {
        for (int j=0; j<RazmernostMassiva; j++)
        {
            for (int z = 0; z<RazmernostMassiva;z++)
            {
                MassivItog[i,j] = MassivItog[i,j] + Massiv1[i,z]*Massiv2[z,j];
            }
        }
    }
Console.WriteLine("Итоговый массив:");
VivodMassivInt(MassivItog,RazmernostMassiva,RazmernostMassiva);

