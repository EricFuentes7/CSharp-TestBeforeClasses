using System;

public class Program
{
    public static void Main(string[] args)
    {
        bool allKeys = true;
        int money = 500;
        Console.WriteLine("Ejemplo 1, AND\n");
        if (allKeys && money >= 500)
        {
            money -= 500;
            Console.WriteLine("Has ganado!");
            Console.WriteLine($"Saldo actual: {money}");
        }
        else
        {
            Console.WriteLine("Perdiste");
            Console.WriteLine($"Saldo actual: {money}");

        }
        Console.WriteLine("\nEjemplo 2, OR\n");
        int hora = 22;
        string dia = "Domingo";

        if (dia == "Sabado" || dia == "Domingo")
        {
            Console.WriteLine("Cerrado!");
        }
        else
        {
            Console.WriteLine("Abierto!");
        }


        Console.WriteLine("\nEjemplo 3, NOT\n");
        if (!(dia == "Domingo"))
        {
            Console.WriteLine("Abierto!");
        }
        else
        {
            Console.WriteLine("Cerrado!");
        }
    }
}
