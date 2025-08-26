using System;

public class Program
{
    public static void Main(string[] args)
    {
        int valorMin;
        int valorMax;
        Console.WriteLine("Ingresa el valor que tienes");
        valorMin = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingresa el valor maximo");
        valorMax = Convert.ToInt32(Console.ReadLine());
        double resultado = Porcentaje(valorMin, valorMax);

        Console.WriteLine($"El porcentaje es del: {resultado}%");
    }


    //Definimos que Porcentaje retornará double, el void no devuelve
    //Double para que no se pierda al dividir
    static double Porcentaje(double min, double max)
    {
        double res = min / max * 100;
        return res;
    }
}

