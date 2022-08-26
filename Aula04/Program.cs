using System;
using System.IO;

namespace Aula04
{
    class Program
    
    {
        static bool cadastrar (string username, string password);
        {
            string linha = username + "e" + password;

            File.AppendAllText("users.txt", linha);
            return true;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Bem Vindo!");
            Console.WriteLine("Digite 1 para logar");
            Console.WriteLine("Digite 2 para cadastrar");
            Console.WriteLine("Digite 3 para sair");

            bool sair = false;
            while (!sair)
            {
                int opcao = 0;

                try
                {
                    opcao = int.Parse(Console.ReadLine());
                }
                catch (Exception erro)
                {
                    //nada
                }

                switch (opcao)
                {
                    case 1:
                        //TO DO logar
                        break;
                    case 2:
                        //TO DO cadastrar
                        Console.WriteLine("Digite um nome de usuário");
                        string username = Console.ReadLine();
                        Console.WriteLine("Digite uma senha");
                        string password = Console.ReadLine();
                        Console.WriteLine("Confirme a senha");
                        string confirm = Console.ReadLine();
                        if (password != confirm)
                        {
                            Console.WriteLine("As senhas não coincidem, tente novamente.");
                        } else
                        {
                            if (cadastrar(username, password)){
                                Console.WriteLine("Cadastro Efetuado");
                            } else {
                                Console.WriteLine("Não foi possível cadastrar!");
                            }
                        }
                    case 3:
                        //TO DO sair
                        sair = true;
                        break;
                    default:
                        //TO DO opção inválida
                        Console.WriteLine("Opção inválida, tente novamente!");
                    break;
                }

            }
        }
    }
}
