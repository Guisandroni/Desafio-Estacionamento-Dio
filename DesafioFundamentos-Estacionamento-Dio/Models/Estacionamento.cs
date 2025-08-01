namespace DesafioFundamentos_Estacionamento_Dio.Models;

public class Estacionamento
{
    private List<string> veiculos = new List<string>();

    private decimal PrecoInicial = 0;
    private decimal PrecoPorHora = 0;

    public Estacionamento(decimal PrecoInicial, decimal PrecoPorHora)
    {
        this.PrecoPorHora = PrecoPorHora;
        this.PrecoInicial = PrecoInicial;
    }

    public void AddVeiculo()
    {
        Console.WriteLine("Informe a placa do veiculo");
        
        string placa = Console.ReadLine();
        if (placa.Length > 7 && placa.Length < 1)
        {
            Console.WriteLine("Placa do veiculo invalida");
        }
        veiculos.Add(placa);

        

    }

    public void RemoverVeiculo()
    
    {
        Console.WriteLine("Informe a placa do veiculo!");
        string placa = Console.ReadLine();

        if (veiculos.Any(nomeVeiculo => nomeVeiculo.ToUpper() == placa.ToUpper()))
        {
            Console.WriteLine("Informe as horas que o veiculo permaneceu no estacionamento");
            decimal valorEstacionamento;
            decimal hora = decimal.Parse(Console.ReadLine());
        
            valorEstacionamento = PrecoPorHora * hora;
            veiculos.Remove(placa);
            Console.WriteLine($"Veiculo {placa} removido com sucesso valor a ser pago  R${valorEstacionamento}");
        }
        else
        {
            Console.WriteLine("Veiculo invalido , tente novamente");
        }
        
       
        
    }

    public void ListarVeiculos()
    {
        foreach (var i in veiculos)
        {
            Console.WriteLine("Listando Veiculos");
            Console.WriteLine(i);
        }
    }
}