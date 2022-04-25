using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Endereco
    {
        public int Id { get; set; }
        public string Cep { get; set; }
        public string Bairro { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }

        public override string ToString()
        {
            return "\nId: " + this.Id + "\nCEP: " + this.Cep + "\nBairro:" + this.Bairro + "\nLogradouro: " + 
                this.Logradouro + "\nNumero: " + this.Numero + "\nComplemento: " + this.Complemento;
        }
    }
}
