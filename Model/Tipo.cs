namespace Model
{
    public class Tipo
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

        public Tipo()
        {

        }
        public Tipo(int id, string descricao)
        {
            Id = id;
            Descricao = descricao;
        }

        public override string ToString()
        {
            return "\nId: " + this.Id + "\nDescrição: " + this.Descricao;
        }
    }
}