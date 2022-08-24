using System;

namespace Aula02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um valor:");
            double valor1 = Convert.ToDouble(Console.ReadLine()); //conversão de real string pra real double
            
            Console.WriteLine("Informe outro valor:");
            double valor2 = Convert.ToDouble(Console.ReadLine());
            
            if (valor1 > valor2){
                Console.WriteLine("O menor valor é " + valor2);
            }else{
                Console.WriteLine("O menor valor é " + valor1);
            }

        }
        
    }
}