using System;  //Faz depedências de comportamento da classe
using System.Globalization;

namespace MetodoReaproveitamento
{
    class Program
    {
        static void Main(string[] args)
        {

            Triangulo x, y; // Pegamos a classe Triangulo e criamo oBJETOS x y qual foi instanciada da classe
            x = new Triangulo();
            y = new Triangulo();
            Console.WriteLine("Entre com as medidas do Triangulo X:");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do Triangulo Y:");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); //ADAPTAMOS COM UM PONTEIRO
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            double areaX = x.Area();


            double areaY = y.Area();

            Console.WriteLine("Área de x = " + areaX);
            Console.WriteLine("Área de y = " + areaY);

            if (areaX > areaY)
            {
                Console.WriteLine("Maior área X :  "  + areaX);

            }
            else
            {
                Console.WriteLine("Maior área: Y : " +  areaY);
            }




        }
    }
}
