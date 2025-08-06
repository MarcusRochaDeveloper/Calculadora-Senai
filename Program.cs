using System;

namespace CalculadoraWeb
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora Colaborativa Web");
            // Integrante 1: Implementar menu e chamar as funções 
        }

        // Integrante 1 (João Victor)
        public static double Adicao(double a, double b)
        {
            return a + b;
        }

        // Integrante 2 (Matheus)
        public static double Subtracao(double a, double b)
         {
            return a - b;
         }

        // Integrante 3 (Sophia)
        public static double Multiplicacao(double a, double b)
        {
        return a * b;
        }

        // Integrante 4 (Adam)
        public static double Divisao(double a, double b)
        {
            return a / b;
        }
        
        // Integrante 5 (Marcus Rocha)
        public static double Potenciacao(double NumeroBase, double Expoente)
        {
            return Math.Pow(NumeroBase, Expoente)
        }
    }
}

