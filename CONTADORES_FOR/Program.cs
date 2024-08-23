using System;
class Program
{
    static void Main()
    {
        int i = 1;

        Console.WriteLine("CONTEO DEL 1 AL 20");
        while(i<=20)
        {
            Console.WriteLine(i);
            i++;

        }
        Console.WriteLine("CONTEO PARES DEL 2 AL 16");
        for (i=2;i<=16;i=i+2)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("CONTEO IMPARES DEL 15 AL 5");
        for (i = 15; i >= 5; i=i-2)
        {
            Console.WriteLine(i);
        }


    }
}