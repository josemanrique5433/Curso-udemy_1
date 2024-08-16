internal class Program
{
    private static void Main(string[] args)
    {
        int a, b;

        Console.Write("Digita el primer número: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digita el segundo número: ");
        b = Convert.ToInt32(Console.ReadLine());

        Console.Write("Su división entera es: ");
        Console.WriteLine(a / b);

        Console.Write("Su residuo es: ");
        Console.WriteLine(a % b);
    }
}