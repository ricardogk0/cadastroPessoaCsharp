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

        public override string ToString()
        {
            return "Nome: " + Name + "\n\r" +
                "CPF: " + Cpf + "\n\r" +
                "Telefone: " + Phone + "\n\r" +
                "Email: " + Email;
        }
    }
}
