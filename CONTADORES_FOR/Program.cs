using System;
class Program
{
    static void Main()
    {
        int i,sum=0,num;

        Console.WriteLine("NUMERO 1-200 MULTIPLOS  DE 3 Y 7");
        for(i=3;i<=200;i=i+1)
        {
            if(i%3==0 && i%7==0) 
            {
                Console.WriteLine(i);
            }
                
        }
        Console.WriteLine("Escribe números ó 0 para finalizar");

        do
        {            
            num = Convert.ToInt32(Console.ReadLine());
            if (num != 0)
            {
                sum += num;
                Console.WriteLine("Llevas acumulado {0}",sum);
            }
                       
        }

        while (num != 0);
        {

        }



        int numero;

        Console.WriteLine("Escribe un número:");
        numero = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Mostrando los divisores de {0}:", numero);

        for (i = numero; i >= 1; i -= 1)
        {
            if (numero % i == 0)
            {
                Console.WriteLine(i);
            }
        }


        int numeroActual, contadorDivisores = 0;

        Console.WriteLine("Escribe un número:");
        numero = Convert.ToInt32(Console.ReadLine());

        // Primera alternativa

        for (i = 1; i <= numero; i++)
        {
            if (numero % i == 0)
            {
                contadorDivisores += 1;
            }
        }

        if (contadorDivisores > 2)
        {
            Console.WriteLine("El número NO es primo");
        }
        else
        {
            Console.WriteLine("El número SI es primo");
        }

        // Segunda alternativa

        numeroActual = 2;

        while (numero % numeroActual != 0)
        {
            numeroActual += 1;
        }

        if (numero == numeroActual)
        {
            Console.WriteLine("El número SI es primo");
        }
        else
        {
            Console.WriteLine("El número NO es primo");
        }

    }
}