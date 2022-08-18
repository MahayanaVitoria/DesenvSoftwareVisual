using System;

namespace Aula02
{
    class Program
    {
        static void Main(string[] args)
        {

            try //tente executar isso
            {
                Console.WriteLine("Informe o valor R$:");
                double real = Convert.ToDouble(Console.ReadLine()); //conversão de real string pra real double

                double dolar = 5.17;
                double euro = 6.14;
                double peso = 0.05;
                double dolarConversao = CalcularDolar(real, dolar);
                double euroConversao = CalcularDolar(real, euro);
                double pesoConversao = CalcularDolar(real, peso);

                Console.WriteLine("R$" + real + " convertido em dólar é $" + dolarConversao);
                Console.WriteLine("R$" + real + " convertido em euro é $" + euroConversao);
                Console.WriteLine("R$" + real + " convertido em peso é $" + pesoConversao);

            }
            catch(Exception erro) //se não der, tente isso
            {
                Console.WriteLine(erro.Message);
            }
        }
        
        static double CalcularDolar(double real, double dolar) //função para calcular conversão de dólar
        {
            return real * dolar;

        }
        static double CalcularEuro(double real, double euro) //função para calcular conversão de dólar
        {
            return real * euro;

        }
        static double CalcularPeso(double real, double peso) //função para calcular conversão de dólar
        {
            return real * peso;

        }
    }
}