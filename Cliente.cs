using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula07
{
    public class Cliente
    {
        public string cpf { get; set; }
        public string nome { get; set; }

        public Cliente()
        {

        }

        public Cliente(string cpf, string nome)
        {
            this.cpf = cpf;
            this.nome = nome;
        }
    }
}
