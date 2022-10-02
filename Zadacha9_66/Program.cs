// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
int SummaOtMdoN(int m, int n)
{
    if (m<n)
    return m + SummaOtMdoN (m+1,n);
    else
    return m;
}
Console.WriteLine("Введите M");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите N");
int N = Convert.ToInt32(Console.ReadLine());
if (M<N) 
{
    N = SummaOtMdoN (M,N);
    Console.WriteLine("Сумма натуральных элементов в промежутке от M до N - {0}",N);
}
else
Console.WriteLine("Введены не корректные данные");

