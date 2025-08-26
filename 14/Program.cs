using System;

public class Program
{
    public static void Main(string[] args)
    {
        string name;
        int age;

        Hola();
        Console.WriteLine("Como te llamas?:");
        name = Console.ReadLine();
        Console.WriteLine("Cual es tu edad?:");
        age = Convert.ToInt32(Console.ReadLine());

        Bienvenida(name, age);
    }


    static void Hola()
    {
        Console.WriteLine("Hola!!");
    }

    static void Bienvenida(string nombre, int edad)
    {
        Console.WriteLine($"Hola {nombre}, veo que tienes {edad} años.");
    }
}

