using System;

public class Program
{
    // El "public Nombre" (como sea), si es el mismo nombre que la clase, al crearlo se ejecuta
    class Aplicacion
    {
        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
    }
    public static void Main(string[] args)
    {
        Aplicacion a = new Aplicacion();
        a.Nombre = "Eric";
        Console.WriteLine(a.Nombre);
    }
}

