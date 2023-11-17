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
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            veiculos.Add(Console.ReadLine());
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {               
                //Se o veiculo realmente existe, nessa parte ele pede pra o usuario digitar 
                //a quantidade de horas que o veiculo permaneceu no estacionamento
                int horas = 0;
                bool testeHoras = false;
                //Este laço de repetição testa se o usuario digitou realmente um numero.
                do{
                    Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                     String resposta = Console.ReadLine();
                    if(int.TryParse(resposta,out horas)){
                        testeHoras = true;
                    }else{
                        Console.Clear();
                        Console.WriteLine("Voce não digitou numeros. Pressione qualquer tecla para tentar novamente!");
                        Console.ReadLine();
                    }
                }while(testeHoras == false);
               
                decimal valorTotal = 0; 
                veiculos.Remove(placa);
                valorTotal = precoInicial + (horas*precoPorHora);
                Console.WriteLine($"O veículo {placa.ToUpper()} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                int contador = 0;
                foreach(string veiculo in veiculos){
                    contador++;
                    Console.WriteLine($"{contador} - {veiculo.ToUpper()}");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
