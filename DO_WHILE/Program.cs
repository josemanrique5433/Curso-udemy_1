using System;
class Program
{
    static void Main()
    {
        int password;
        

        do
        {
            Console.WriteLine("Introduce la contraseña ");
            password = Convert.ToInt32(Console.ReadLine());
           
        }

        while (password != 1234);        {
            
            Console.WriteLine("Bienvenido");
            
        }

    }
}