using Estacionamento1.Models;

Estacionamento es = new Estacionamento();

Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\n" +
                  $"Preço Inicial do estacionamento é de: {es.getPrecoInicial()} R$\n" +
                  $"Preço por hora do estacionamento é de: {es.getPrecoPorHora()} R$\n");

bool exibirMenu = true;

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
            Console.WriteLine("Opção inválida, tente novamente.");
            break;
    }

    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
}

Console.WriteLine("O programa se encerrou");