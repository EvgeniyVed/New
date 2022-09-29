// Сформируйте двухмерный массив из неповторяющихся случайных двузначных чисел (размер массива не более 50 элементов).
// Напишите программу, которая будет построчно выводить массив.
bool ZapisannieRaneeZnachenia(int[] massiv, int Znachenie)
{
    int i = 0;
    int lengthOfMassiv = massiv.Length;
    do
    {
        if (massiv[i] == Znachenie)
            return true;
        if (massiv[i] == 0)
        {
            massiv[i] = Znachenie;
            return false;
        }
        i++;
    } while (massiv[i] < lengthOfMassiv);
    return false;
}
void VivodMassivInt(int[,] massiv, int Strtoka, int Stolbec)
{
    Console.WriteLine("Массив:");
    for (int i = 0; i < Strtoka; i++)
    {
        for (int j = 0; j < Stolbec; j++)
        {
            Console.Write("{0} ", massiv[i, j]);
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Введите размерность массива");
Console.WriteLine("Введите количество строк");
int Strok = Convert.ToInt32(Console.ReadLine());
if (Strok < 50 && Strok > 1)
{
    Console.WriteLine("Введите количество столбцов");
    int Stolbcov = Convert.ToInt32(Console.ReadLine());
    if (Stolbcov < 50 && Stolbcov > 1)
    {
        int[,] Massiv = new int[Strok, Stolbcov];
        int[] MassivVvedennihElementov = new int[Strok * Stolbcov];
        Random rnd = new Random();
        int Proverka = 0;
        for (int i = 0; i < Strok; i++)
        {
            for (int j = 0; j < Strok; j++)
            {
                do
                {
                    Proverka = rnd.Next(10, 99);
                    //Proverka = Convert.ToInt32(Console.ReadLine()); - для проверки на дубли
                } while (ZapisannieRaneeZnachenia(MassivVvedennihElementov, Proverka));
                Massiv[i, j] = Proverka;
            }
        }
        VivodMassivInt(Massiv, Strok, Strok);
    } else
    Console.WriteLine("Введено недопустимое значение");
} else
Console.WriteLine("Введено недопустимое значение");
