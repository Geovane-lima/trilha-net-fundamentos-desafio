namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            bool continuar = true;
            while (continuar)
            {
                Console.Clear();
                Console.Write("Digite a placa do veículo para estacionar: ");
                string placa = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(placa))
                {
                    veiculos.Add(placa);
                    Console.WriteLine($"Veículo com placa {placa} adicionado.");
                }
                else
                {
                    Console.WriteLine("Placa inválida. Tente novamente.");
                }

                Console.WriteLine("Deseja adicionar outro veículo? (S/N)");
                string resposta = Console.ReadLine();
                continuar = resposta.Equals("S", StringComparison.OrdinalIgnoreCase);
            }
        }

        public void RemoverVeiculo()
        {
            bool continuar = true;
            while (continuar)
            {
                Console.Clear();
                Console.Write("Digite a placa do veículo para remover: ");
                string placa = Console.ReadLine();

                if (veiculos.Any(x => x.Equals(placa, StringComparison.OrdinalIgnoreCase)))
                {
                    Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado: ");
                    if (int.TryParse(Console.ReadLine(), out int horas))
                    {
                        decimal valorTotal = precoInicial + precoPorHora * horas;
                        veiculos.Remove(placa);
                        Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
                    }
                    else
                    {
                        Console.WriteLine("Quantidade de horas inválida. Tente novamente.");
                    }
                }
                else
                {
                    Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente.");
                }

                Console.WriteLine("Deseja remover outro veículo? (S/N)");
                string resposta = Console.ReadLine();
                continuar = resposta.Equals("S", StringComparison.OrdinalIgnoreCase);
            }
        }

        public void ListarVeiculos()
        {
            Console.Clear();
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são: ");
                foreach (string veiculo in veiculos)
                {
                    Console.WriteLine(veiculo);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}