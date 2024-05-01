using System;
using System.Threading;

namespace console_desafio21dias_api
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite numero inicial:");
            var numeroIncial = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o numero dois:");
            int numeroFinal = Convert.ToInt32(Console.ReadLine());
            int indice = numeroIncial;
            int[] colecaoPar = new int[numeroFinal - numeroIncial];
            int[] colecaoImpar = new int[numeroFinal - numeroIncial];
            int indicePar = 0;
            int indiceImpar = 0;

            while (indice < numeroFinal){

                if(indice % 2 == 0){
                    colecaoPar[indicePar] = indice;
                    indicePar++;
                    //Console.WriteLine($"O numero {indice} é par");
                }
                else{
                    colecaoImpar[indiceImpar] = indice;
                    indiceImpar++;
                    //Console.WriteLine($"O numero {indice} é impar");
                }
                indice++;                
                
            }

            Console.WriteLine("Os números pares são: ");
            for(int count=0 ; count < indicePar; count++){

                Console.WriteLine(colecaoPar[count]);
            }
            Console.WriteLine("Os números impares são: ");
            for (int count = 0; count < indicePar; count++)
            {
                Console.WriteLine(colecaoImpar[count] );
            }

        }
    }
}
