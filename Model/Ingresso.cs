using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Ingresso
    {
        public int Id { get; set; }
        public Evento Evento { get; set; }

        public override string ToString()
        {
            return "\nId: " + this.Id + "\nEvento: " + this.Evento;
        }
    }
}
