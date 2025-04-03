class Program
{
    public static void Main()
    {
        // Solicita a nota do aluno
        Console.Write("Digite a nota do aluno: ");
        double nota = double.Parse(Console.ReadLine());

        // Verifica o conceito do aluno baseado na nota
        if (nota >= 9)
        {
            Console.WriteLine("Conceito: A");
        }
        else if (nota >= 7)
        {
            Console.WriteLine("Conceito: B");
        }
        else if (nota >= 5)
        {
            Console.WriteLine("Conceito: C");
        }
        else
        {
            Console.WriteLine("Conceito: D");
        }
    }
}