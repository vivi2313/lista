class Program
{
    public static void Main()
    {
        // Solicita ao usuário um número inteiro
        Console.Write("Digite um número inteiro: ");
        int numero = int.Parse(Console.ReadLine());

        // Ver se o número é par ou ímpar
        if (numero % 2 == 0)
        {
            Console.WriteLine("O número é PAR.");
        }
        else
        {
            Console.WriteLine("O número é ÍMPAR.");
        }


    }
}