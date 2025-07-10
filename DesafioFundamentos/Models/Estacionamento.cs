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
            Console.Write("Digite a placa de seu veículo: ");
                string placa = Console.ReadLine();
                veiculos.Add(placa);
                Console.WriteLine("Veículo cadastrado com sucesso");
                //Assim registramos a placa do novo veículo e salvamos a informacão nossa lista
        }

        public void RemoverVeiculo()
        {
            Console.Write("Digite a placa do veículo que quer remover: ");
                string placa = Console.ReadLine();
                //Assim conseguimos as informacões para remover o veículo

                if (veiculos.Contains(placa)) //Com isto prevenimos que a placa não esteja realmente registrada
                {
                    //no caso que a placa esteja a certa, a gente passa a cobrar o valor adequado
                    Console.Write("Digite a quantidade de horas que seu veículo ficou no estacionamento: ");
                    decimal horas = Convert.ToDecimal(Console.ReadLine());

                    decimal precoTotal = horas * precoPorHora + precoInicial;

                    Console.WriteLine($"O veículo {placa} foi removido. Total a pagar: R$ {precoTotal: F2}");
                }
                //Caso que o numero da placa não esteja certo, vamos informar o usuario
                else
                {
                    Console.WriteLine("Veículo não encontrado verifique o numero da placa");
                }
        }

        public void ListarVeiculos()
        {
            if (veiculos.Count == 0)
                {
                    Console.WriteLine("Não há veículos estacionados neste momento");
                }
                else
                {
                    Console.WriteLine("Veículos atualmente estacionados: ");

                    foreach (string placa in veiculos)
                    {
                        Console.WriteLine($"-{placa}");
                    }
                }
        }
    }
}
