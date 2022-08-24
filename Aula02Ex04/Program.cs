using System;

namespace Aula02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a idade:");
            double idade = Convert.ToDouble(Console.ReadLine()); //conversão de real string pra real double
            
            if (idade <= 13){
                Console.WriteLine("Criança");
            }else if (idade > 13 && idade <= 18){
                Console.WriteLine("Adolescente");
            }else if (idade > 18 && idade <=60){
                Console.WriteLine("Adulto");
            }else {
                Console.WriteLine("Idoso");
            }

        }
        
    }
}