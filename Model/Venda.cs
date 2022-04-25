using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Venda
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public Cliente Cliente { get; set; }
        public Vendedor Vendedor { get; set; }
        public Ingresso Ingresso { get; set; }

        public override string ToString()
        {
            return "\nId: " + this.Id + "\nData: " + this.Data + "\nCliente:" + this.Cliente + "\nVendedor: " +
                this.Vendedor + "\nIngresso: " + this.Ingresso;
        }
    }
}

