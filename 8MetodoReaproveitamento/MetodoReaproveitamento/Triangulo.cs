using System;
 

namespace MetodoReaproveitamento
{
    class Triangulo
    {
        public double A; //Atributos da classe
        public double B;
        public double C;

        public double Area() //metodo Area que vem acompanhado com lista de parametro de entrada.No caso não precisou de entrada de parametro porque já tem ABC DENTRO DA CLASSE
        {
            double p = (A + B + C) / 2.0;
             return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            
        }
    }
}
