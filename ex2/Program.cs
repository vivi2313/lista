class Program
{
    public static void Main()
    {
        // Solicitar a idade da pessoa
        Console.WriteLine("Qual sua idade: ");
        int idade = Convert.ToInt32(Console.ReadLine());

        if (idade < 18)

        {
            Console.WriteLine("Menor de idade");

        }

        else if (idade >= 18)

        {
            Console.WriteLine("Maior de Idade");
        }

    }
}