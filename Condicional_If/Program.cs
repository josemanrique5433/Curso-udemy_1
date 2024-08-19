using System;
class Program
{
    static void Main()
    {
        int a, b, c;

        Console.Write("Digita el primer número: ");
        a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digita el segundo número: ");
        b = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digita el tercer número: ");
        c = Convert.ToInt32(Console.ReadLine());

        if ((a >= b) && (a >= c))
        {
            Console.WriteLine("El numero mayor es:  " + a);

        }
        else if ((b>=a) && (b>=c))
        {
            Console.WriteLine("El numero mayor es: "+ b);
                    }
        else
        {
            Console.WriteLine("el número mayor es "+ c);

        }
       

    }
}