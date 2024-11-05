using System;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Timers;

class Program
{
    static void Main()
    {
        const int DIAS = 5;

        string[] dias = { "Lunes", "Martes", "Miércoles", "Jueves" };

       
        for (int i = DIAS-1; i>=0  ; i--)
        {

            Console.WriteLine(dias[i]);

        }
    }
}