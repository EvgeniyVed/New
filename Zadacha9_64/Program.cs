// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
void VivodNaturalOtNDo1 (int n)
{
    if (n>0)
    {
        Console.Write("{0} ",n);
        VivodNaturalOtNDo1(n-1);
        return;   
    }
    else 
    return;
}

Console.WriteLine("Ввведите N");
int N = Convert.ToInt32(Console.ReadLine());
if (N>0) 
VivodNaturalOtNDo1(N);
else
Console.WriteLine("Введено не корректное число");
