using System;

namespace Aula02
{
    class Program
    {
        static void Main(string[] args)
        {

            try //tente executar isso
            {
                Console.WriteLine("Informe uma largura:");
                double largura = Convert.ToDouble(Console.ReadLine()); //conversão da largura string pra largura double
                Console.WriteLine("Informe uma altura");
                double altura = Convert.ToDouble(Console.ReadLine()); //conversão da largura string pra largura double
                double area = CalcularArea(largura, altura);

                Console.WriteLine("A área equivale a: "+ area);

            }
            catch(Exception erro) //se não der, tente isso
            {
                Console.WriteLine(erro.Message);
            }
        }
        
        static double CalcularArea(double largura, double altura) //função para calcular area
        {
            return altura * largura;

        }
    }
}
