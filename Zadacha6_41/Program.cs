// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.WriteLine("Введите количество чисел");
int M = Convert.ToInt32(Console.ReadLine());
if (M>0)
{
    int pozitiv = 0;
    int[] numbers = new int[M];
    Console.WriteLine("Вводите числа");
    for (int i=0;i<M;i++)
    {
        numbers[i] = Convert.ToInt32(Console.ReadLine());
        if (numbers[i]>0)
        pozitiv++; 
    } 
    Console.WriteLine("Количество положительных чисел:");
    Console.WriteLine(pozitiv);    
} else
{
    Console.WriteLine("Введено не корректное количество");
}