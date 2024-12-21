internal class Program
{
    private static void Main(string[] args)
    {
        //Nome
        //Identificado Númerico
        //Apelido
        //Custo Hora
        //Tipo
        //Velocidade

        Console.WriteLine("===================================================");
        Console.WriteLine("Cadastro de Máquina");
        Console.WriteLine("===================================================");
        Console.WriteLine();

        Console.Write("Digite o nome da máquina: ");
        string nomeMaquina = Console.ReadLine();

        Console.WriteLine("===================================================");


        Console.WriteLine($"Nome: {nomeMaquina}");
    }
}