using System;

namespace exercícios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a sua idade?");
            int idade= int.Parse(Console.ReadLine());

            int meses= idade * 12;
            int dias = idade * 365;
            int horas = dias * 24;
            int minutos = horas * 60;

            Console.WriteLine("você tem " + meses + " meses de vida");
            Console.WriteLine("você tem " + dias + " dias de vida");
            Console.WriteLine("você tem " + horas + " horas de vida");
            Console.WriteLine("você tem " + minutos + " minutos de vida");

        }
    }
}
