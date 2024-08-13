using DesafioFundamentos.Models;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0;

Console.WriteLine("       Seja bem-vindo ao sistema de estacionamento!      ");
Console.Write("Digite o preço inicial: R$ ");
precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.Write("Agora digite o preço por hora: R$ ");
precoPorHora = Convert.ToDecimal(Console.ReadLine());

// Instancia a classe Estacionamento, já com os valores obtidos anteriormente
Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

string opcao = string.Empty;
bool exibirMenu = true;

// Realiza o loop do menu
while (exibirMenu)
{
    Console.Clear();
    
    // Exibe o menu em formato de tabela
    Console.WriteLine("+-----------------------------------+");
    Console.WriteLine("|   Agora digite a opção desejada:  |");
    Console.WriteLine("+-----------------------------------+");
    Console.WriteLine("| 1 - Cadastrar veículo             |");
    Console.WriteLine("| 2 - Remover veículo               |");
    Console.WriteLine("| 3 - Listar veículos               |");
    Console.WriteLine("| 4 - Encerrar                      |");
    Console.WriteLine("+-----------------------------------+");

    switch (Console.ReadLine())
    {
        case "1":
            es.AdicionarVeiculo();
            Console.WriteLine("Pressione uma tecla para voltar ao menu...");
            break;

        case "2":
            es.RemoverVeiculo();
            Console.WriteLine("Pressione uma tecla para voltar ao menu...");
            break;

        case "3":
            es.ListarVeiculos();
            Console.WriteLine("Pressione uma tecla para voltar ao menu...");
            break;

        case "4":
            exibirMenu = false;
            continue;  // Sai do loop sem limpar a tela

        default:
            Console.WriteLine("Opção inválida, por favor, tente novamente.");
            break;
    }

    Console.ReadLine();  // Espera a tecla ser pressionada
}

Console.Clear();  // Limpa a tela antes de encerrar o programa
Console.WriteLine("O programa se encerrou.");