using System;

public class Program
{
    public static void Main(string[] args)
    {
        //BREAK - Solo hace print al 1, ya que se para el bucle si es 2.
        int x = 3;
        for (int i = 0; i <= x; i++)
        {
            if (i == 2)
            {
                break;
            }
            Console.WriteLine($"Numero: {i}");
        }
        Console.WriteLine("\nCONTINUE");

        //CONTINUE - Salta lo que queda y repite, se salta el 2
        for (int i = 0; i <= x; i++)
        {
            if (i == 2)
            {
                continue;
            }
            Console.WriteLine($"Numero: {i}");
        }
    }

}
