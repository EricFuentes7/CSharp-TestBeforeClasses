using System;

public class Program
{
    /*Hay diferentes encapsulamientos:
        public, private, protected, internal, protected internal
    */
    class Banco
    {
        private double dinero = 1000;

        public void Ingresar(double n)
        {
            dinero += n;

        }
        public void Retirar(double n)
        {
            dinero -= n;

        }
        public double Balance()
        {
            return dinero;
        }
    }
    public static void Main(string[] args)
    {
        Banco a = new Banco();
        a.Ingresar(150);
        a.Retirar(400);
        Console.WriteLine(a.Balance());
    }
}

