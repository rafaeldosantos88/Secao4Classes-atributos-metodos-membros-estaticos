using System;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {

            Pessoa pessoa1 = new Pessoa();
            Pessoa pessoa2 = new Pessoa();
            Console.WriteLine("digite o nome da Primeira pessoa: ");
            pessoa1.nome = Console.ReadLine();
            Console.WriteLine("Digite idade:");
            pessoa1.idade=int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome da segunda pessoa: ");
            pessoa2.nome= Console.ReadLine();
            Console.WriteLine("Digite idade:");
            pessoa2.idade = int.Parse(Console.ReadLine());

            if(pessoa1.idade > pessoa2.idade)
            {
                Console.WriteLine("A pessoa mais velha é: " + pessoa1.nome +  " com idade de: " + pessoa1.idade);
            }
            else
            {
                Console.WriteLine("A pessoa mais velha é: " + pessoa2.nome +  " com idade de: " + pessoa2.idade);
            }








        }
    }
}
