// See https://aka.ms/new-console-template for more information

using DesafioFundamentos_Estacionamento_Dio.Models;

Estacionamento estacionamento = new Estacionamento(0,2);

while (true)
{
    
    
    Console.WriteLine("\nSeja bem vindo ao estacionamento");
    Console.WriteLine("1 - Adicionar veiculo");
    Console.WriteLine("2 - Remover veiculo");
    Console.WriteLine("3 - Listar veiculo");
    Console.WriteLine("4 - Sair \n");
    int option;

    option = int.Parse(Console.ReadLine());

    switch (option)
    {
        case 1:
            estacionamento.AddVeiculo();
            break;
    
        case 2 :
            estacionamento.RemoverVeiculo();
            break;
        case 3 :
            estacionamento.ListarVeiculos();
            break;
        default:
            Environment.Exit(4);
            break;
    }
    
    
}
