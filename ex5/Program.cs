class Program
{
    public static void Main()
    {
        // Solicita ao usuário um número
        Console.Write("Digite um número: ");
        double numero = double.Parse(Console.ReadLine());

        // Verifica se o número é positivo, negativo ou zero
        if (numero > 0)
        {
            Console.WriteLine("O número é POSITIVO.");
        }
        else if (numero < 0)
        {
            Console.WriteLine("O número é NEGATIVO.");
        }
        else
        {
            Console.WriteLine("O número é ZERO.");
        }
    }
}