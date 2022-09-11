// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = 0;
int pozicia (int number, int a)
{
    int b = 10;
    int i = 1;
    while (i<a)
    {
        b=b*10;
        i++;
    }

    b = number % (b) /(b/10);
    return b;
}
if (number1>9999 && number1<1000000)
{
    number2 = pozicia(number1,1)*10000+pozicia(number1,2)*1000+pozicia(number1,3)*100+pozicia(number1,4)*10+pozicia(number1,1);
    if (number2==number1)
    Console.WriteLine("Полиндром");
    else
    Console.WriteLine("Не полиндром");
} else
Console.WriteLine("Введено не корректное число");
