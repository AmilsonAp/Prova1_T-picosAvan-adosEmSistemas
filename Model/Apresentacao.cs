using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Apresentacao
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int Duracao { get; set; }
        public DateTime Hora { get; set; }

        public  Apresentacao()
        {
          
        }

        public Apresentacao(int id, string descricao, int duracao, DateTime hora)
        {
            Id = id;
            Descricao = descricao;
            Duracao = duracao;
            Hora = hora;

        }
     
        public void Add(Apresentacao apresentacao)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return "\nId: " + this.Id + "\nDescricao: " + this.Descricao + "\nDuracao: " + this.Duracao + "\nHora: " + this.Hora;
        }
    }     
}
