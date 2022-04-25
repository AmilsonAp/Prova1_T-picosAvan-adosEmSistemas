using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }

        public override string ToString()
        {
            return "\nId: " + this.Id + "\nNome: " + this.Nome + "\nTelefone: " + this.Telefone;
        }
    }
}
