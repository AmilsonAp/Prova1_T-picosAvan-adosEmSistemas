using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Evento
    {
        public Evento(int id, string nome, DateTime data, Endereco endereco, Tipo tipo, int capacidade, List<Apresentacao> apresentacao, int duracao)
        {
            Id = id;
            Nome = nome;
            Data = data;
            Endereco = endereco;
            Tipo = tipo;
            Capacidade = capacidade;
            Apresentacao = apresentacao;
            Duracao = duracao;

        }

        public Evento()
        {

        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime Data { get; set; }
        public Endereco Endereco { get; set; }
        public Tipo Tipo { get; set; }
        public int Capacidade { get; set; }
        public List<Apresentacao> Apresentacao { get; set; }
        public int Duracao { get; set; }

        public override string ToString()
        {
            return "\nId: " + this.Id + "\nNome: " + this.Nome + "\nData:" + this.Data + "\nEndereco: " + this.Endereco + "\nTipo: " + this.Tipo + "\nCapacidade: " + this.Capacidade + "\nApresentacão: " +
                this.Apresentacao + "\nDuracao: " + this.Duracao;
        }

    }
}
