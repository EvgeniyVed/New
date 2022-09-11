// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве
float itog = 0;
float[] vek1 = {};
float[] vek2 = {}; 

float[] vvodvek ( int v, int razmer )
{
    float[] vek = {0,0,0};
    Console.WriteLine("Введите значение вектора {0}",v);
    for (int i=0;i<razmer;i++)
    {
        vek[i]= Convert.ToInt32(Console.ReadLine());
    }
    return vek;
}
vek1 = vvodvek (1,3);
vek2 = vvodvek (2,3);
for (int z=0;z<3;z++)
{
    itog = itog + (vek1[z]-vek2[z])*(vek1[z]-vek2[z]);
}
Console.WriteLine(itog);
Console.WriteLine(Math.Round(Math.Sqrt(itog),2));




