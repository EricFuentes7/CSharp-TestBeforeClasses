using System;

public class Program
{
    public static void Main(string[] args)
    {
        int x = 1, y = 2, z = 3;

        Console.WriteLine(x + ", " + y + ", " + z);

        int puntos = 100;
        Console.WriteLine(puntos);
        puntos += 10; //suma 10
        Console.WriteLine(puntos);

        /*
        Tambien funciona:
        x+=5
        x-=5
        x*=5
        x/*5
        x%=5
        */

        float precio = 100f;
        float descuento = 1.2f;
        precio /= descuento;
        Console.WriteLine(precio);
    }
}
