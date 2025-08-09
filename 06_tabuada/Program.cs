using System;

namespace _06_tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero para ver a tabuada");
                int numero = int.Parse(Console.ReadLine());


            

            Console.WriteLine($"\nTabuada do {numero}:\n");

            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine($"{numero} x {i} = {numero * i}");

            }
            Console.WriteLine("\nPressione qualquer teclar para sair");
            Console.ReadKey();
           

        }
    }
}
