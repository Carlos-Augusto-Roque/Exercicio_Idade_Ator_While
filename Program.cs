using System;

namespace Exercicio_Idade_Ator_While
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a idade do ator: ");
            int idade = int.Parse(Console.ReadLine());

            while(idade != 47)
            {
                Console.WriteLine("Errou !");
                Console.WriteLine("Tente novamente");
                idade = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Resposta Correta -- Parabéns !");
        }
    }
}
