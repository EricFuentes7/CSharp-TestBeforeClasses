using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Como te llamas?");
        string nombre = Console.ReadLine();
        Console.WriteLine("Hola, " + nombre);

        //Input de numeros (string a int)

        Console.WriteLine("Di un numero");
        int numero = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Tu numero: " + numero);

        //Convertir a String
        int numeroAString = 8;
        string numeroStringfeado = Convert.ToString(numeroAString);
        Console.WriteLine(numeroStringfeado);
    }
}
