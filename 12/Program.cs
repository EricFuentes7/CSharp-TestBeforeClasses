using System;

public class Program
{
    public static void Main(string[] args)
    {
        //For (se repite las veces establecidas.)
        int x = 3;
        for (int i = 1; i <= x; i++)
        {
            Console.WriteLine($"Numero: {i}");
        }

        //While (se repite has ta que deje de ser true)
        int repeticiones = 0;
        bool activo = true;
        while (activo)
        {
            repeticiones++;
            Console.WriteLine($"Repeticiones: {repeticiones}");

            activo = repeticiones == 5 ? false : true;
        }

        //Do While (ejecuta el codigo siempre 1 vez primero, luego verifica si es true)
        int numero = 5;
        do
        {
            Console.WriteLine($"Numero: {numero}");
            numero++;
        } while (numero <= 10);
    }

}
