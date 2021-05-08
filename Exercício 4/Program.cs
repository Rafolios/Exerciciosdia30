using System;

namespace exercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá novo nadador!!");
            Console.WriteLine("Para fazer seu cadastro, nescessitamos da sua idade...");
            Console.WriteLine("Quantos anos você tem??");
            int idade = int.Parse(Console.ReadLine());
            if ((idade >= 5) && (idade < 8))
            {
                Console.WriteLine("Você está inscrito na categoria: Infantil-A");
            }
            if ((idade >= 8) && (idade < 11))
            {
                Console.WriteLine("Você está inscrito na categoria: Infantil-B");
            }
            if ((idade >= 11) && (idade < 14))
            {
                Console.WriteLine("Você está inscrito na categoria: Juvenil-A");
            }
            if ((idade >= 14) && (idade < 18))
            {
                Console.WriteLine("Você está inscrito na categoria: Juvenil-B");
            }
            if (idade >= 18)
            {
                Console.WriteLine("Você está inscrito na categoria: Sênior");
            }
        }
    }
}
