using System;

public class Program
{
    // El "public Nombre" (como sea), si es el mismo nombre que la clase, al crearlo se ejecuta
    class Aplicacion
    {
        private double seguidores = 1000;
        private double seguidos = 230;
        public string nombre;
        public Aplicacion(string nm)
        {
            nombre = nm;
            Console.WriteLine("Acabas de crear tu cuenta.");
        }
        public string ConseguirNombre()
        {
            return nombre;
        }
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Como te llamas?:");
        Aplicacion usuario = new Aplicacion(Console.ReadLine());
        Console.WriteLine("Bienvenid@, " + usuario.ConseguirNombre());
    }
}

