// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
int itog = 1;
Console.WriteLine("Введите число А");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число В");
int b = Convert.ToInt32(Console.ReadLine());
for (int i =0;i<b;i++)
{
    itog = itog * a;
}
Console.WriteLine(itog);