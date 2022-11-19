using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro
{
    class People
    {
        public string Name { get; set; }
        public string Cpf { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }  

        public People(string name, string cpf, string phone, string email)
        {
            Name = name;
            Cpf = cpf;
            Phone = phone;
            Email = email;
        }

        public static void CadastrarPessoa()
        {
            People pessoa;

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

                pessoa = new People(nome, cpf, tel, email);

                Console.WriteLine("Deseja incluir um novo cadastro? (1 para sim)");
                op = int.Parse(Console.ReadLine());

            } while (op == 1);
        }

        public static string PesquisarPessoa(string nome)
        {
            People pessoa;

            Console.WriteLine(pessoa.Name);
        }

        public override string ToString()
        {
            return "Nome: " + Name + "\n\r" +
                "CPF: " + Cpf + "\n\r" +
                "Telefone: " + Phone + "\n\r" +
                "Email: " + Email;
        }
    }
}
