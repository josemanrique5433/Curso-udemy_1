using System;
class Program
{
    static void Main()
    {
        int a, b;
        
        Console.Write("Digita el primer número: ");
        a=Convert.ToInt32(Console.ReadLine());

        Console.Write("Digita el segundo número");
        b =Convert.ToInt32(Console.ReadLine());

        if (a > b) 
        {
            Console.WriteLine("El numero mayor es {0} ", a);
            
        }
        else
        {
            Console.WriteLine("el número mayor es {0}", b);

        }
       

    }
}