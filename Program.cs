using System;

namespace Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            
            /*Exercicio 3*/
            Console.WriteLine("Digite um numero");
            string numeroString = Console.ReadLine();
            int tamanhoDoVetor = Convert.ToInt16(numeroString);
            Console.WriteLine("\n");


           Execicio3 exercicio3 = new Execicio3(tamanhoDoVetor);

            exercicio3.preencherVetor();

            exercicio3.ordernarVetor();

            exercicio3.mostrarVetor();

            Console.WriteLine("\n");
            Console.WriteLine("Digite um numero para fazer uma pesquisa binaria normal.");
            numeroString = Console.ReadLine();
            int pesquisarNumero = Convert.ToInt16(numeroString);

            exercicio3.buscaBinariaNormal(pesquisarNumero);


            Console.WriteLine("\n");
            Console.WriteLine("Digite um numero para fazer uma pesquisa binaria recursiva");
            numeroString = Console.ReadLine();
            int pesquisaBinarnariaRecursiva = Convert.ToInt16(numeroString);

            int resultadoPesquisado = exercicio3.buscaBinariaRecursiva(0, tamanhoDoVetor - 1, pesquisaBinarnariaRecursiva);

            if (resultadoPesquisado > 0)
            {
                Console.WriteLine($"Foi localizado o registro {pesquisaBinarnariaRecursiva} na posição " + resultadoPesquisado);
            }
            else
            {
                Console.WriteLine($"Não foi localizado o registro {resultadoPesquisado}");
            }
           
            /*.......................................*/

            /*Exercicio 4*/
            exercicio4(5);

            Console.ReadLine();
        }


        static void exercicio4(int numero)
        {
            if(numero < 0)
            {
                return;
            }

 
            int valor = 1;
            for (int i = 1; i <= numero; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(valor);
                    valor += 1;  
                }
                Console.WriteLine("");
                    
            }
                    }
    }
}
