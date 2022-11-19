using System;
using System.Collections.Generic;

namespace Cadastro
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("-----------------------------Menu----------------------------------\n\n\n 1 - Cadastrar -------------- 2 - Pesquisar -------------- 3 - Sair");

            int op = int.Parse(Console.ReadLine());
            do
            {
                switch (op)
                {
                    case 1:
                        People.CadastrarPessoa();
                        break;

                    case 2:
                        Console.Write("Digite o nome ou cpf que deseja pesquisar");
                        string pesquisar = Console.ReadLine();
                        People.PesquisarPessoa(pesquisar);
                        break;

                    case 3:
                        op = 3;
                        break;

                    default:
                        Console.Write("Opção invalida");
                        op = 4;
                        break;
                }

                op = 4;

            } while (op == 4);

        }

        static void CadastrarPessoa1()
        {
            List<People> list = new List<People>();

            int op = 0;

            do
            {
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("CPF: ");
                string cpf = Console.ReadLine();
                Console.Write("Telefone: ");
                string tel = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();

                list.Add(new People(nome, cpf, tel, email));

                Console.WriteLine("Deseja incluir um novo cadastro? (1 para sim)");
                op = int.Parse(Console.ReadLine());

            } while (op == 1);
        }

        static void PesquisarPessoa1()
        {
            People pessoa;

            /* Console.Write("Digite o nome ou cpf da pessoa que deseja pesquisar");
             string pesquisar = Console.ReadLine();*/


            

        }

    }
}