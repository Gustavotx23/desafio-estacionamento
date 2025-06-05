using System.Globalization;
using System.Security.Authentication.ExtendedProtection;
using System.Security.Cryptography;
using System;
using System.Reflection.Metadata;

namespace Projetos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<Veiculo> veiculos = new List<Veiculo>(); 

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }


        public void AdicionarVeiculo()
        {
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            // *IMPLEMENTE AQUI*

            Veiculo veiculo = new Veiculo(); 

            if (veiculos.Count >= 10) // Verifica se o estacionamento está cheio, maior ou igual a 10
            {
                Console.WriteLine($"Capacidade do estacionamento {veiculos.Count} excedida. Para adicionar um veículo, remova um.");
                Console.ReadKey();
                return; // Sai do método sem adicionar o veículo.
            }


            Console.WriteLine("Digite a placa do veículo para estacionar:"); // Agora pede a placa somente se houver espaço no estacionamento.
            string placa = Console.ReadLine();
            Console.Clear();


            Console.WriteLine("Preciso de mais informações... Qual seu tipo de veículo? Ex: carro, moto, bicicleta.");
            string tipoVeiculo = Console.ReadLine().ToLower(); // Lê o input do usuário e o armazena, flexivel quanto a entrada maiusc/minusc.
            switch(tipoVeiculo)
            {
                case "carro":
                    Console.WriteLine($"O veículo do tipo carro da placa {placa} foi adicioando ao estacionamento.");
                    veiculo.TipoVeiculo = "carro"; 
                    veiculo.Placa = placa;
                    veiculos.Add(veiculo); 
                    break;
                
                case "moto":
                    Console.WriteLine($"O veículo do tipo moto da placa {placa} foi adicioando ao estacionamento.");
                    veiculo.TipoVeiculo = "moto";
                    veiculo.Placa = placa;
                    veiculos.Add(veiculo);
                    break;

                case "bicicleta":
                    Console.WriteLine($"O veículo do tipo bicicleta da placa {placa} foi adicioando ao estacionamento.");
                    veiculo.TipoVeiculo = "bicicleta";
                    veiculo.Placa = placa;
                    veiculos.Add(veiculo);
                    break;

                default:
                    Console.WriteLine("Opção inválida. Tipo de veículo desconhecido.");
                    break;
            }
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            // Pedir para o usuário digitar a placa e armazenar na variável placa

            // *IMPLEMENTE AQUI*

            string placa = Console.ReadLine();

            // Procurar o veículo na lista
        
            Veiculo veiculoParaRemover = veiculos.FirstOrDefault(x => x.Placa.ToUpper() == placa.ToUpper()); 
            
            // Verifica se o veículo existe

            if (veiculoParaRemover != null)
            {
                Console.WriteLine($"Placa encontrada. Digite a quantidade de horas que o veículo de placa {placa} permaneceu estacionado:");
                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                // *IMPLEMENTE AQUI*
                int horas = 0;
                decimal valorTotal = 0; 

                horas = Convert.ToInt32(Console.ReadLine());
                valorTotal = precoInicial + precoPorHora * horas;
                

                // TODO: Remover a placa digitada da lista de veículos
                // *IMPLEMENTE AQUI*

                veiculos.Remove(veiculoParaRemover);
                Console.Clear();
                Console.WriteLine($"O veículo da placa {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Veículo não encontrado. Confira a placa digitada.");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Count>0)
            {
                Console.Clear();
                Console.WriteLine("Os veículos estacionados são: ");
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                

                // *IMPLEMENTE AQUI*
                int contadorForEach = 1;
                foreach (var veiculo in veiculos)
                {
                    Console.WriteLine($"{contadorForEach}° - Tipo: {veiculo.TipoVeiculo} \t Placa: {veiculo.Placa}");
                    contadorForEach++;
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
