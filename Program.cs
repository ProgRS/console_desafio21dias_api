using System;

namespace console_desafio21dias_api
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro numero:");
            var numeroUm = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o primeiro numero:");
            int numeroDois =  Convert.ToInt32(Console.ReadLine());
            var soma = numeroUm + numeroDois;

            Console.WriteLine($"Digite o resultado da soma do {numeroUm} + {numeroDois}");
            int resultado = Convert.ToInt32(Console.ReadLine());
                if(resultado == soma)
                    Console.WriteLine("Parabéns você acertou");
                else
                    Console.WriteLine("Desculpe você errou");
                

            //Console.WriteLine($"A soma das variaveis é : {soma}");

        }
    }
}
