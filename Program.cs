using System;

namespace Exercicio_Idade_Ator_While
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a idade do ator: ");//exibição da mensagem
            int idade = int.Parse(Console.ReadLine());//entrada e armazenamento da idade

            while(idade != 47)//se a idade digitada for diferente de 47,então :
            {
                Console.WriteLine("Errou !");//exibir mensagem que errou
                Console.WriteLine("Tente novamente");//exibir a mensagem para tentar novamente
                idade = int.Parse(Console.ReadLine());//entrada e armazenamento da idade 
            }
            Console.WriteLine("Resposta Correta -- Parabéns !");//se  a idade digitada for 47,então exibir a mensagem que está correta

            
            //mesmo exemplo,agora usando o (do while)
            // int idade;

            // do{
            //     Console.WriteLine("digite a idade do ator");
            //     idade = int.Parse(Console.ReadLine());
            // }while(idade != 47);
            // Console.WriteLine("Acertou");
        }
    }
}
