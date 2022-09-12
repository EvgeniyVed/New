// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
    int razmer = 8;
    int[] vek = new int[razmer];
    Console.WriteLine("Введите значение вектора");
    for (int i=0;i<razmer;i++)
    {
        vek[i]= Convert.ToInt32(Console.ReadLine());
    }
    Console.Write("[");
    for (int i=0;i<razmer;i++)
    {
        Console.Write("{0}, ",vek[i]);
    }
    Console.Write("]");
    
