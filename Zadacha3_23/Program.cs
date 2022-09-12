// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
int n = Convert.ToInt32(Console.ReadLine());
if (n>0)
{
    for (int i = 1;i<=n;i++)
    Console.Write("{0}, ",i*i*i);
} else
{
    Console.WriteLine("Введено не корректное число");
}
