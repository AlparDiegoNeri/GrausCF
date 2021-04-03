using System;

namespace GrausCF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vamos converter a temperatura °C para °F, para isso, digite: ");

            Console.WriteLine("Temperatura em °C: ");
            double c = Convert.ToDouble(Console.ReadLine());

            double multiplicacao = 1.8; 
            double soma = 32; 

            //Solução com a fórmula na interpolação
            Console.WriteLine($"A conversão do valor pra °F é: {c * multiplicacao + soma}º F");

            //Solução com a fórmula em variável
            double resultado = c * multiplicacao + soma;
            Console.WriteLine($"A conversão do valor pra °F é: {resultado}º F");            
        }
    }
}
