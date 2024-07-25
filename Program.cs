using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, resultado;
            string operador;

            Console.WriteLine("Digite o primeiro número:");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo número (ou exponencial para potenciação):");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o operador (+, -, *, /, ^):");
            operador = Console.ReadLine();

            switch (operador)
            {
                case "+":
                    resultado = num1 + num2;
                    Console.WriteLine($"Resultado: {num1} + {num2} = {resultado}");
                    break;
                case "-":
                    resultado = num1 - num2;
                    Console.WriteLine($"Resultado: {num1} - {num2} = {resultado}");
                    break;
                case "*":
                    resultado = num1 * num2;
                    Console.WriteLine($"Resultado: {num1} * {num2} = {resultado}");
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                        Console.WriteLine($"Resultado: {num1} / {num2} = {resultado}");
                    }
                    else
                    {
                        Console.WriteLine("Erro: Divisão por zero não é permitida.");
                    }
                    break;
                case "^":
                    resultado = Math.Pow(num1, num2);
                    Console.WriteLine($"Resultado: {num1} ^ {num2} = {resultado}");
                    break;
                default:
                    Console.WriteLine("Operador inválido.");
                    break;
            }

            Console.WriteLine("Pressione qualquer tecla para sair.");
            Console.ReadKey();
        }
    }
}
