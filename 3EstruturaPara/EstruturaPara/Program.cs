using System;

namespace EstruturaPara
{
    class Program
    {
        static void Main(string[] args)
        {//Usada quando você sabe quantidade de repetições,caso você não sabe você usa enquanto(while)
            /*Estrutura Para(for)
            For(inicio;condiçao;incremento){
            comando 1
            comando 2
            }*/

            Console.Write("Quantos números inteiros vai digitar: ");
            int n = int.Parse(Console.ReadLine());

            int soma = 0;
            for (int i = 1; i <= n; i++){
                Console.WriteLine("valor: #{0}: ", i);
                int valor = int.Parse(Console.ReadLine());
                soma = soma + valor;

            }

            Console.WriteLine("Soma dos números é: " + soma);

        }
    }
}
