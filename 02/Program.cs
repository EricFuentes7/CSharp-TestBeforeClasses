using System;

public class Program
{
    //Igual que siempre un Main dentro
    public static void Main(string[] args)
    {

        char caracter = 'E';
        int numero = 8;

        // Float: - preciso - memoria
        float floats = 93.923f;

        // Double: + preciso que float, + memoria
        double dobles = 8.19;

        // Decimal: + preciso que double, + memoria
        decimal decimales = 923.34242m;

        /*SE USA SIEMPRE EL POSTFIJO
        f - en float
        m - en decimal
        */

        bool abierto = false;

        Console.WriteLine(caracter);
        Console.WriteLine(numero);
        if (abierto) {
            Console.WriteLine("Está ABIERTO!");
        } else { Console.WriteLine("Está CERRADO..."); }
    }
}
