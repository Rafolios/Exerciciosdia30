using System;

namespace exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Em que ano você nasceu?");
            int Anonasc = int.Parse(Console.ReadLine());
            Console.WriteLine("Em que ano estamos?");
            int Anoatual = int.Parse(Console.ReadLine());
            int Sub = Anoatual - Anonasc;
            Console.WriteLine("Você tem/fará " + Sub + " anos de vida");

            int semanas = Sub * 52;
            Console.WriteLine("Você tem aproximadamente " + semanas + " semanas de vida");
        }
    }
}
