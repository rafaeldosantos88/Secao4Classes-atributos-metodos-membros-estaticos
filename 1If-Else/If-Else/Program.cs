using System;

namespace If_Else
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite hora: ");
            int hora=int.Parse(Console.ReadLine());

            if(hora < 12)
            {
                Console.WriteLine("Bom dia");
            }
            else if(hora < 18) //O se não else garante a exclusão da primeira condição,a gente sabe quando ela não da certo
            {
                Console.WriteLine("Boa Tarde");
            }
            else
            {
                Console.WriteLine("Boa Noite");
            }
        }
    }
}
