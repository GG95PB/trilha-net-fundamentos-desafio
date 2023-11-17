using DesafioFundamentos.Models;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0;
bool testeValor = false;

Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\n");
//Este laço de repetição testa se o usuario digitou realmente um numero.
                do{
                    Console.WriteLine("Digite o Valor inicial:");
                     String resposta = Console.ReadLine();
                    if(decimal.TryParse(resposta,out precoInicial)){
                        testeValor = true;
                    }else{
                        Console.Clear();
                        Console.WriteLine("Digite o valor inicial corretamente. somente numeros são aceitos.\n Pressione qualquer tecla para tentar novamente!");
                        Console.ReadLine();
                    }
                }while(testeValor == false);

        testeValor = false;
//Este laço ele refaz o teste para validar as horas.
                do{
                    Console.WriteLine("Agora digite o preço por hora:");
                     String resposta = Console.ReadLine();
                    if(decimal.TryParse(resposta,out precoPorHora)){
                        testeValor = true;
                    }else{
                        Console.Clear();
                        Console.WriteLine("Voce não digitou corretamente. Somente numeros são aceitos.\n Pressione qualquer tecla para tentar novamente!");
                        Console.ReadLine();
                    }
                }while(testeValor == false);

// Instancia a classe Estacionamento, já com os valores obtidos anteriormente
Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

string opcao = string.Empty;
bool exibirMenu = true;

// Realiza o loop do menu
while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");

    switch (Console.ReadLine())
    {
        case "1":
            es.AdicionarVeiculo();
            break;

        case "2":
            es.RemoverVeiculo();
            break;

        case "3":
            es.ListarVeiculos();
            break;

        case "4":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
}

Console.WriteLine("O programa se encerrou");
