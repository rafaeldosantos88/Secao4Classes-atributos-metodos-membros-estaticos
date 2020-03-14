using System;
using System.Globalization;

namespace EstruturaEnquanto
{
    class Program
    {
        static void Main(string[] args)
        {
            /*while (condição){
        comando 1                          Regra:
        comando 2                               V:Executa e volta
                }                               f:Pula Fora      */


            Console.Write("Digita um número: ");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (x >= 0.0)
            {
                double raiz = Math.Sqrt(x);  //Vai calcular a raiz quadrada enquanto for positivo
                Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture)); ;
                x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            Console.WriteLine("Número Negativo");


            }
        }
}
