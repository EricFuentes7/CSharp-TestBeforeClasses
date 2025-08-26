using System;

public class Program
{
    public static void Main(string[] args)
    {
        //Para poner comillas se usa \anes de los "
        Console.WriteLine("Y el dijo \"un piquito?\"");

        //Para saltar de lineas se usa \n
        Console.WriteLine("Primera línea \nSegunda línea \nTercera línea");

        //Para hacer Tab se usa \t
        Console.WriteLine("Hola \tnena");

        //Para usar caracteres especiales, etc. se usa @ antes
        Console.WriteLine(@"Holaaa
Que tal     beibis");

        //Para poner variable dentro de string se usa $ y {}
        string ciudad = "londres";
        Console.WriteLine($"{ciudad} es una bonita ciudad");
    }
}
