using System;

public class Program
{
    //Lo mismo que el ej 19 peo con auto-implementación

    /*
    Lo que hace es que en vez de tener una privada y una publica
    crea una privada en base a lo que le llega de la publica
    */
    class Aplicacion
    {
        public string Nombre{ get; set; }
        public static void Main(string[] args)
        {
            Aplicacion a = new Aplicacion();
            a.Nombre = "Eric";
            Console.WriteLine(a.Nombre);
        }
    }
}

