using System;
using System.Collections.Generic;

namespace Cadastro
{
    class Program
    {
        static void Main(string[] args)
        {
            List<People> peoples = new List<People>();

            int op = 0;
            do
            {
                Console.WriteLine("-----------------------------Menu----------------------------------\n\n\n 1 - Cadastrar -------------- 2 - Pesquisar -------------- 3 - Sair");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        int i = 0;

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

                            People people = new People(nome, cpf, tel, email);

                            peoples.Add(people);

                            Console.WriteLine("Deseja incluir um novo cadastro? (1 para sim)");
                            i = int.Parse(Console.ReadLine());

                        } while (i == 1);
                        break;

                    case 2:
                        Console.WriteLine("Digite o nome ou cpf que deseja pesquisar: ");
                        string pesquisar = Console.ReadLine();
                        foreach (People people in peoples)
                        {
                            if(people.Name == pesquisar || people.Cpf == pesquisar)
                            {
                                Console.WriteLine();
                                Console.WriteLine(people);
                                Console.WriteLine();
                            }
                        }

                            break;

                    case 3:
                        op = 3;
                        break;

                    default:
                        Console.Write("Opção invalida");
                        break;
                }


            } while (op != 3);

        }

    }
}