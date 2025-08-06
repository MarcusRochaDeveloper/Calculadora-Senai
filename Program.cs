using System;

namespace CalculadoraWeb
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            double num1, num2, resultado;

            do
            {
                Console.Clear();
                Console.WriteLine("===== Calculadora Colaborativa Web =====");
                Console.WriteLine("1 - Adição");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");
                Console.WriteLine("5 - Potenciação");
                Console.WriteLine("0 - Sair");
                Console.Write("Escolha uma opção: ");
                
                if (!int.TryParse(Console.ReadLine(), out opcao))
                {
                    Console.WriteLine("Opção inválida. Pressione Enter para tentar novamente.");
                    Console.ReadLine();
                    continue;
                }

                if (opcao == 0)
                    break;

                Console.Write("Digite o primeiro número: ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite o segundo número: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        resultado = Adicao(num1, num2);
                        Console.WriteLine($"Resultado: {resultado}");
                        break;
                    case 2:
                        resultado = Subtracao(num1, num2);
                        Console.WriteLine($"Resultado: {resultado}");
                        break;
                    case 3:
                        resultado = Multiplicacao(num1, num2);
                        Console.WriteLine($"Resultado: {resultado}");
                        break;
                    case 4:
                        if (num2 == 0)
                        {
                            Console.WriteLine("Erro: Divisão por zero.");
                        }
                        else
                        {
                            resultado = Divisao(num1, num2);
                            Console.WriteLine($"Resultado: {resultado}");
                        }
                        break;
                    case 5:
                        resultado = Potenciacao(num1, num2);
                        Console.WriteLine($"Resultado: {resultado}");
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }

                Console.WriteLine("\nPressione Enter para continuar...");
                Console.ReadLine();

            } while (opcao != 0);

            Console.WriteLine("Encerrando calculadora. Até a próxima!");
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
        public static double Potenciacao(double baseNumero, double expoente)
        {
            return Math.Pow(baseNumero, expoente);
        }
    }
}
