using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Ingresa un numero: ");
        bool esMayor;
        int numero = Convert.ToInt32(Console.ReadLine());

        /*
        == - igual
        <= - menor o igual
        >= - mayor o igual
        != - no es igual
        < - menor que
        > - mayor que
        */

        if (numero > 10)
        {
            esMayor = true;
            Console.WriteLine("Es mayor");

        }
        else
        {
            esMayor = false;
            Console.WriteLine("Es menor");

        }
    }
}
