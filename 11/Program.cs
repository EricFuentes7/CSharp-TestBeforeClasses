using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Ingresa tu edad: ");
        int edad = Convert.ToInt32(Console.ReadLine());
        string esAdultoString = edad >= 18 ? "Es mayor de edad" : "Es menor de edad";

        Console.WriteLine(esAdultoString);

        //se calcula tambien, el 15% (por ejemplo)
        float factura = 1500f;
        factura = factura >= 1500f ? factura * 0.85f : factura;
        Console.WriteLine(factura);

    }
}
