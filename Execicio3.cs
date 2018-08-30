using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios
{
    public class Execicio3
    {
        int[] numeros { get; set; }


        public Execicio3(int numero)
        {
            numeros= new int[numero];

        }

        public void  preencherVetor()
        {
            Random aleatorio = new Random(); 
            for(int i=0;i < numeros.Length;i++)
            {

                numeros[i]=aleatorio.Next(i, 100);
 
             }
       
        }

        public void buscaBinariaNormal(int numeroPesquisado)
        {
            //inicio,e comeco e final do vetor
            int comeco = 0;
            int final = numeros.Length -1;
            int meio =0;
            bool achaResultado = false;


            while ((comeco <= final)) 
            {
                meio = (comeco + final) / 2;

                if(numeroPesquisado == numeros[meio])
                {

                    
                    achaResultado=true;
                    break;
                }
                else
                {
                    if (numeroPesquisado < numeros[meio])
                    {
                        final = meio - 1;

                    }
                    else
                    {
                        comeco = meio + 1;
                    }

                }

            }


            if (achaResultado)
            {
                Console.WriteLine($"Foi localizado o registro {numeroPesquisado} na posição " + meio);
            }
            else
            {
                Console.WriteLine("Registro não foi encontrado");
            }

        }

        public int buscaBinariaRecursiva(int menor,int maior,int chave)
        {
            int media = (maior + menor) / 2;
            int meio = numeros[media];

            if (menor > maior)
                return -1;
            else if (meio == chave)
                return media;
            else if (meio < chave)
                return buscaBinariaRecursiva(media + 1, maior, chave);
            else
                return buscaBinariaRecursiva(menor, media-1, chave);
        }

        public void ordernarVetor()
        {

            int auxiliar;
            for (int i=0; i<numeros.Length;i++)
            {
                for(int j = 0; j < numeros.Length; j++)
                {
                    if(numeros[i] < numeros[j])
                    {
                        auxiliar = numeros[i];
                        numeros[i] = numeros[j];
                        numeros[j] = auxiliar;

                    }

                }
            }
        }


        public void mostrarVetor()
        {
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine(numeros[i]);
            }

        }

    }
}
