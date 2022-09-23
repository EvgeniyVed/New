// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
Console.WriteLine("Введите значения b1, k1, b2 и k2");
int b1 = Convert.ToInt32(Console.ReadLine());
int k1 = Convert.ToInt32(Console.ReadLine());
int b2 = Convert.ToInt32(Console.ReadLine());
int k2 = Convert.ToInt32(Console.ReadLine());
double xChisl = (b1-b2);
double xZnamen = (k2-k1);
double x = xChisl/xZnamen;
double y = x*k1+b1;
Console.WriteLine("Точка пересечения двух прямых ({0};{1})",x,y);