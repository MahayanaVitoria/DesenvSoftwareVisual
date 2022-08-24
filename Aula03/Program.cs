using System;

namespace Aula03
{
    class Program
    {
        // static void Main(string[] args){

        //     Console.WriteLine("Informe o 1° número:");
        //     double primeiro = Convert.ToDouble(Console.ReadLine());

        //     Console.WriteLine("Informa o 2° número:");
        //     double segundo = Convert.ToDouble(Console.ReadLine());

        //     double media = CalcularMedia (primeiro, segundo);

        //     Console.WriteLine("A média equivale a: "+ media);

        //     static double CalcularMedia(double primeiro, double segundo) //função para calcular area
        // {
        //     return (primeiro + segundo) / 2;

        // }


        static double calcularMedia(double[] numeros)
        {
            double soma = 0.0;

            for(int i = 0; i < numeros.Length; i++)
            {
                soma += numeros[i];
                //soma = soma + numeros[i];
            }
            double media = 0.0;

            media = soma / numeros.Length;

            return media;
        }

        static double calcularMediana(double[] numeros)
        {
            Array.Sort(numeros);
            int meio = numeros.Length / 2;
            if((numeros.Length % 2) == 0)
            {
                return(numeros[meio] + numeros[meio - 1]) / 2;
            }
            else
            {
                return numeros[meio];
            }
        }

        static double calcularModa(double[] numeros)
        {
            double[] repeticoes = new double[numeros.Length];
            for(int i = 0; i < numeros.Length; i++)
            {
                double atual = numeros[i];
                int cont = 0;

                for(int j = 0; j < numeros.Length; j++)
                {
                    if(numeros[j] == atual)
                    {
                        cont++;
                    }
                }
                repeticoes[i] = cont;
            }

            int maior = 0;
            for(int i = 1; i < repeticoes.Length; i++)
            {
                if(repeticoes[i] > repeticoes[i - 1])
                {
                    maior = 1;
                }
            }
            return numeros[maior];
        }

        static void Main(string[] args)
        {
            double[] numeros = {4, 2, 8, 6, 2};
            double media = calcularMedia(numeros);
            Console.WriteLine("A média é: " + media);
            double mediana = calcularMediana(numeros);
            Console.WriteLine("A mediana é: " + mediana);
            double moda = calcularModa(numeros);
            Console.WriteLine("A moda é: " + moda);

        }            

    }
}
