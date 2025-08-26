using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Ingresa tu seleccion (1-3): ");
        int seleccion = Convert.ToInt32(Console.ReadLine());
        switch (seleccion)
        {
            case 1:
                Console.WriteLine("Has seleccionado la opcion 1");
                break;
            case 2:
                Console.WriteLine("Has seleccionado la opcion 2");
                break;
            case 3:
                Console.WriteLine("Has seleccionado la opcion 3");
                break;
            default:
                Console.WriteLine("Que?? no estás en el rango de 1-3");
                break;
        }

        string fruta = "Platano";

        switch (fruta)
        {
            case "Platano":
                Console.WriteLine("Potassium");
                break;
            case "Mandarina":
                Console.WriteLine("Potassiumn't");
                break;
            default:
                Console.WriteLine("Potassium??");
                break;
        }
    }
}
