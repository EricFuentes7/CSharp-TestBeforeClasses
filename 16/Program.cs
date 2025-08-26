using System;

public class Program
{
    class Personaje
    {
        public int edad;
        public string nombre;
        public void Saludo()
        {
            Console.WriteLine("Hola!");
        }
    }
    public static void Main(string[] args)
    {
        Personaje p1 = new Personaje();
        p1.nombre = "Eric";
        p1.edad = 17;
        p1.Saludo();
        Console.WriteLine(p1.nombre);
    }
}

