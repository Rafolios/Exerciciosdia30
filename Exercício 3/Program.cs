using System;

namespace exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o seu salário");
            float salário = float.Parse(Console.ReadLine());
            float ajuste = (salário/100) * 30;
            if (salário < 500 ) {
                salário= (salário+ajuste);
                Console.WriteLine("salário ajustado para R$ " + salário + " reais");
            }
            else{
                Console.WriteLine("Seu salário não receberá ajuste");
            }
        }
    }
}
