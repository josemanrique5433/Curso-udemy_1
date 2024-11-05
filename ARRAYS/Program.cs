internal class Program
{
  static void Main(string[] args)
    {

        double[] arrayMedia = new double[10];
        rellenaArray(arrayMedia);
        Console.WriteLine("La media de las notas es: {0} ", CalcularMedia(arrayMedia));
        
    }
    static void rellenaArray(double[] array)
    {
        int i = 0;
        do
        {

            Console.WriteLine("Introduce la Nota {0} ", i+1);
            double numeroMedia =double.Parse(Console.ReadLine());

            array[i] = numeroMedia;
            i++;

        } while (i < array.Length);

    }
    static double CalcularMedia(double[] array)
    {
        double MediaTotal = 0;
        for (int i = 0; i < array.Length; i++)
        {

            MediaTotal += array[i];


        }
        return MediaTotal / array.Length;                  
            
            
    }
}








