// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int itog = 0;
for (int i = 10;i/10<number;i=i*10)
{
    itog = itog + (number%i/(i/10));
}
Console.WriteLine(itog);