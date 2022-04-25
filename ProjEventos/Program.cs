using Model;

namespace ProjEventos
{
    public class Program
    {
        static List<Apresentacao> apresentacoes = new List<Apresentacao>();
        static List<Ingresso> ingressos = new List<Ingresso>();
        static List<Cliente> clientes = new List<Cliente>();
        static List<Vendedor> vendedores = new List<Vendedor>();
        static List<Evento> eventos = new List<Evento>();

        static void Main(string[] args)
        {

            bool sair = false;
            int opcao;

            do
            {
                Console.WriteLine("\nEscolha uma opçao:");
                Console.WriteLine("1 - Cadastrar Evento");
                Console.WriteLine("2 - Gerar lote de ingressos");
                Console.WriteLine("3 - Cadastrar vendedor");
                Console.WriteLine("4 - Cadastrar cliente");
                Console.WriteLine("5 - Vender Ingresso");
                Console.WriteLine("6 - Consultas");
                Console.WriteLine("0 - Sair");

                opcao = int.Parse(Console.ReadLine());

                #region SWITH CASE
                switch (opcao)
                {
                    case 1:
                        cadastrarEvento();
                        break;
                    case 2:
                        gerarLote();
                        break;
                    case 3:
                        cadastrarVendedor();
                        break;
                    case 4:
                        cadastrarCliente();
                        break;
                    case 5:
                        venderIngresso();

                        break;
                    case 6:
                        consultar();
                        break;
                    case 0:
                        Console.WriteLine("PROGRAMA ENCERRADO");
                        sair = true;
                        break;
                    default:
                        Console.WriteLine("OPÇAO INVÁLIDA");
                        break;
                }

            } while (sair != true);
            #endregion                                                 
        }

        #region CADASTRAR EVENTO
        public static void cadastrarEvento()
        {
            int duracaoTotal = 0;
            Evento evento = new Evento();
            evento.Endereco = new Endereco();
            evento.Tipo = new Tipo();
            bool continuar;

            Console.WriteLine("Id evento");
            evento.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Nome");
            evento.Nome = Console.ReadLine();
            Console.WriteLine("Data");
            evento.Data = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("ID endereco");
            evento.Endereco.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Cep ");
            evento.Endereco.Cep = Console.ReadLine();
            Console.WriteLine("Bairro");
            evento.Endereco.Bairro = Console.ReadLine();
            Console.WriteLine("Logradouro");
            evento.Endereco.Logradouro = Console.ReadLine();
            Console.WriteLine("Numero ");
            evento.Endereco.Numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Complemento");
            evento.Endereco.Complemento = Console.ReadLine();

            Console.WriteLine("Id tipo evento");
            evento.Tipo.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Descrição do tipo de evento");
            evento.Tipo.Descricao = Console.ReadLine();

            Console.WriteLine("Capacidade");
            evento.Capacidade = int.Parse(Console.ReadLine());


            do
            {
                Apresentacao apresentacao = new Apresentacao();

                Console.WriteLine("Informe o código da apresentação!");
                apresentacao.Id = int.Parse(Console.ReadLine());
                Console.WriteLine("Informe a descrição da apresentação!");
                apresentacao.Descricao = Console.ReadLine();
                Console.WriteLine("Informe a duração da apresentação(int)");
                apresentacao.Duracao = int.Parse(Console.ReadLine());
                Console.WriteLine("Informe o horário de inicio da apresentação");
                apresentacao.Hora = DateTime.Parse(Console.ReadLine());

                apresentacoes.Add(apresentacao);

                Console.WriteLine("Adicionar outra apresentação?");
                Console.WriteLine("1 - Sim");
                Console.WriteLine("2 - Não");
                continuar = Console.ReadLine() == "1" ? true : false;

                duracaoTotal = duracaoTotal + apresentacao.Duracao;
            } while (continuar);

            evento.Apresentacao = apresentacoes;
            eventos.Add(evento);

            evento.Duracao = duracaoTotal;
        }
        #endregion

        #region GERAR LOTE
        public static void gerarLote()
        {
            Ingresso ingresso = new Ingresso();

            Console.WriteLine("Id do evento para gerar lote");
            int idEvento = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantidade de ingressos");
            int qtdIngressos = int.Parse(Console.ReadLine());

            ingressos.Add(ingresso);

            for (int i = 1; i <= qtdIngressos; i++)
            {
                ingressos.Add(new Ingresso() { Id = i, Evento = new Evento() { Id = idEvento } });
            }
        }
        #endregion

        #region CADASTRAR VENDEDOR
        public static void cadastrarVendedor()
        {
            Vendedor vendedor = new Vendedor();

            Console.WriteLine("Informe o Id do Vendedor!");
            vendedor.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o nome do vendedor!");
            vendedor.Nome = Console.ReadLine();
            Console.WriteLine("Informe o telefone do vendedor!");
            vendedor.Telefone = Console.ReadLine();
           
            vendedores.Add(vendedor);
        }
        #endregion

        #region CADASTRAR CLIENTE
        public static void cadastrarCliente()
        {
            Cliente cliente = new Cliente();

            Console.WriteLine("Informe o Id do cliente!");
            cliente.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o nome do cliente!");
            cliente.Nome = Console.ReadLine();
            Console.WriteLine("Informe o telefone do cliente!");
            cliente.Telefone = Console.ReadLine();

            clientes.Add(cliente);
        }
        #endregion

        #region VENDER INGRESSO
        public static void venderIngresso()
        {
            Venda venda = new Venda();
            Console.WriteLine("Informe o ID para venda!");
            venda.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o nome do cliente que será vendido o ingresso!");
            venda.Cliente.Nome = Console.ReadLine();
            Console.WriteLine("Informe o vendedor que vendeu o ingresso!");
            venda.Vendedor.Nome = Console.ReadLine();
            Console.WriteLine("Inforo Id do ingresso vendido!");
            venda.Ingresso.Id = int.Parse(Console.ReadLine());

        }
        #endregion

        #region CONSULTAS
        public static void consultar()
        {
            int opcao1;

            Console.WriteLine("\n1 - Consultar Apresentações");
            Console.WriteLine("2 - Consultar Lote de Ingressos");
            Console.WriteLine("3 - Consultar Clientes");
            Console.WriteLine("4 - Consultar Vendedores");
            Console.WriteLine("5 - Consultar Eventos");
            opcao1 = int.Parse(Console.ReadLine());

            switch (opcao1)
            {
                case 1:
                    apresentacoes.ForEach(a => Console.WriteLine(a));
                    break;
                case 2:
                    ingressos.ForEach(a => Console.WriteLine(a));
                    break;
                case 3:
                    clientes.ForEach(a => Console.WriteLine(a));
                    break;
                case 4:
                    vendedores.ForEach(a => Console.WriteLine(a));
                    break;
                case 5:
                    eventos.ForEach(a => Console.WriteLine(a));
                    break;
                default:
                    Console.WriteLine("OPÇAO INVÁLIDA");
                    break;
            }
        }
        #endregion
    }
}