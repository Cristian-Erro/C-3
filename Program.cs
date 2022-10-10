using System;

namespace C_3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool logica=true;
            int dni=99999999;
            string nombre="Hola Mundo!";
            float saldo=12.12f;

            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("Esta es la variable logica {0}",logica);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Esta es la variable entera {0}",dni);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Esta es la variable cadena {0}",nombre);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Esta es la variable decimal {0}",saldo);
            Console.ResetColor();
        }
    }
}
