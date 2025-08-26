using System;

public class Program
{
    public static void Main(string[] args)
    {
        int puntos = 100;
        Console.WriteLine(puntos);

        //Sumamos

        puntos++;
        Console.WriteLine(puntos);

        //Restamos

        puntos--;
        Console.WriteLine(puntos);

        Console.WriteLine("Puntos para despues: " + puntos++); //te da el valor de puntos, y en la siguiente, puntos tendrá +1
        Console.WriteLine("Puntos normales: " + puntos);
        Console.WriteLine("Puntos para antes: " + ++puntos); //te añade el +1 antes de imprimirlo

    }
}
