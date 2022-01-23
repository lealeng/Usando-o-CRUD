using System;

namespace CRUD
{
    class Program
    {
        static JogadoresRepositorio repositorio = new JogadoresRepositorio();
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                    InserirJogadores();
                    break;
                    case "2":
                    ListarJogadores();
                    break;
                    case "3":
                    AtualizarJogadores();
                    break;
                    case "4":
                    ExcluirJogadores();
                    break;
                    case "5":
                    VisualizarJogadores();
                    break;
                    case "C":
                    Console.Clear();
                    break;


                    default:
                        throw new ArgumentOutOfRangeException();
                  //  Console.WriteLine("Por favor insira uma opção válida da lista acima!");
                }

                opcaoUsuario = ObterOpcaoUsuario();          
            }

            Console.WriteLine("Obrigado por utilizar nossos serviços.");
            Console.ReadLine();
        }

        private static void InserirJogadores()
        {
            Console.WriteLine("Inserir novo Jogador");

            foreach (int i in Enum.GetValues(typeof(Posicoes)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Posicoes), i));
            }
            Console.Write("Digite a posição entre as opções acima: ");
            int entradaPosicoes = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome do Jogador: ");
            string entradaNomeJogador = Console.ReadLine();

            Console.Write("Digite a Idade do Jogador: ");
            int entradaIdadeJogador = int.Parse(Console.ReadLine());

            Console.Write("Digite o CPF do Jogador: ");
            string entradaCpfJogador = Console.ReadLine();

            Console.Write("Digite o nome do Time: ");
            string entradaNomeTime = Console.ReadLine();

            Console.Write("Digite o número da camisa: ");
            int entradaNumeroCamisa = int.Parse(Console.ReadLine());

            Jogadores novoJogador = new Jogadores(id: repositorio.ProximoId(),
                                                  nome: entradaNomeJogador,
                                                  cpf: entradaCpfJogador,
                                                  idade: entradaIdadeJogador,
                                                  posicoes: (Posicoes)entradaPosicoes,
                                                  time: entradaNomeTime,
                                                  numero: entradaNumeroCamisa);

            repositorio.Inserir(novoJogador);
        }

        private static void ListarJogadores()
        {
            Console.WriteLine("Listar Jogadores");

            var lista = repositorio.Lista();

            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhum jogador cadastrado.");
                return;
            }

            foreach (var jogadores in lista)
            {
                var excluido = jogadores.retornaExcluido();

                Console.WriteLine("#ID {0}: - {1} {2}", jogadores.retornaId(), jogadores.retornaNomeJogador(), (excluido ? "*Excluído*" : ""));
            }

        }

            private static void AtualizarJogadores()
            {
                Console.Write("Digite o ID do Jogador: ");
                int indiceJogador = int.Parse(Console.ReadLine());

                foreach (int i in Enum.GetValues(typeof(Posicoes)))
                {
                    Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Posicoes), i));
                }
                Console.Write("Digite a posição entre as opções acima: ");
                int entradaPosicoes = int.Parse(Console.ReadLine());

                Console.Write("Digite o nome do Jogador: ");
                string entradaNomeJogador = Console.ReadLine();

                Console.Write("Digite a Idade do Jogador: ");
                int entradaIdadeJogador = int.Parse(Console.ReadLine());

                Console.Write("Digite o CPF do Jogador: ");
                string entradaCpfJogador = Console.ReadLine();

                Console.Write("Digite o nome do Time: ");
                string entradaNomeTime = Console.ReadLine();

                Console.Write("Digite o número da camisa: ");
                int entradaNumeroCamisa = int.Parse(Console.ReadLine());

                Jogadores atualizarJogador = new Jogadores(id: indiceJogador,
                                                  nome: entradaNomeJogador,
                                                  cpf: entradaCpfJogador,
                                                  idade: entradaIdadeJogador,
                                                  posicoes: (Posicoes)entradaPosicoes,
                                                  time: entradaNomeTime,
                                                  numero: entradaNumeroCamisa);

            repositorio.Atualizar(indiceJogador, atualizarJogador);

            }
            private static void ExcluirJogadores()
            {
                Console.Write("Digite o ID do Jogador: ");
                int indiceJogador = int.Parse(Console.ReadLine());

                repositorio.Excluir(indiceJogador);
            }
            private static void VisualizarJogadores()
            {
                Console.Write("Digite o ID do Jogador: ");
                int indiceJogador = int.Parse(Console.ReadLine());

                var jogadores = repositorio.RetornarPorId(indiceJogador);

                Console.WriteLine(jogadores);
            }
            private static string ObterOpcaoUsuario()
            {
                Console.WriteLine();
                Console.WriteLine("Seja bem vindo ao cadastro de jogadores para jogar Futsal!!!");
                Console.WriteLine("Informe a opção desejada");

                Console.WriteLine("1- Inserir Novo Jogador");
                Console.WriteLine("2- Listar Jogadores");
                Console.WriteLine("3- Atualizar Jogador");
                Console.WriteLine("4- Excluir Jogador");
                Console.WriteLine("5- Visualizar jogador");
                Console.WriteLine("C- Limpar Tela");
                Console.WriteLine("X- Sair");
                Console.WriteLine();

                string opcaoUsuario = Console.ReadLine().ToUpper();
                Console.WriteLine();
                return opcaoUsuario;
            }
        }
        
    
}
