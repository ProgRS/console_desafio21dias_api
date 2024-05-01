using System;

namespace console_desafio21dias_api
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro numero:");
            var numeroUm = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo  numero:");
            int numeroDois = Convert.ToInt32(Console.ReadLine());
            var soma = numeroUm * numeroDois;

            Console.WriteLine($"Digite o numero premiado?");
            int resultado = Convert.ToInt32(Console.ReadLine());
            if (resultado == soma || resultado == 1 || resultado == 10 || (resultado >= 100 && resultado <= 200))
                Console.WriteLine($"Parabéns você acertou o resultado: {soma}");
            else
                Console.WriteLine($"O resultado é {soma}, você errou, tente novamente na proxima");


            //Console.WriteLine($"A soma das variaveis é : {soma}");

        }
    }
}
