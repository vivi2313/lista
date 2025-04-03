class Program
{
    public static void Main()
    {
        // Solicita ao usuário que insira dois números
        Console.Write("Digite o primeiro número: ");
        double numero1 = double.Parse(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        double numero2 = double.Parse(Console.ReadLine());

        // Exibe o menu de opções
        Console.WriteLine("\nEscolha uma operação:");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Multiplicação");
        Console.WriteLine("4 - Divisão");
        Console.Write("Digite o número da operação desejada: ");
        int escolha = int.Parse(Console.ReadLine());

        // Realiza a operação correspondente com base na escolha do usuário
        double resultado = 0;
        bool operacaoValida = true;

        switch (escolha)
        {
            case 1:
                resultado = numero1 + numero2;
                Console.WriteLine($"Resultado: {numero1} + {numero2} = {resultado}");
                break;

            case 2:
                resultado = numero1 - numero2;
                Console.WriteLine($"Resultado: {numero1} - {numero2} = {resultado}");
                break;

            case 3:
                resultado = numero1 * numero2;
                Console.WriteLine($"Resultado: {numero1} * {numero2} = {resultado}");
                break;

            case 4:
                if (numero2 != 0)
                {
                    resultado = numero1 / numero2;
                    Console.WriteLine($"Resultado: {numero1} / {numero2} = {resultado}");
                }
                else
                {
                    Console.WriteLine("Erro: Não é possível dividir por zero.");
                    operacaoValida = false;
                }
                break;

            default:
                Console.WriteLine("Opção inválida! Por favor, escolha uma operação entre 1 e 4.");
                operacaoValida = false;
                break;
        }

        // Se a operação não for válida, exibe uma mensagem de erro
        if (!operacaoValida)
        {
            Console.WriteLine("Ocorreu um erro na execução da operação.");
        }
    }
}