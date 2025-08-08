using System;

 
class Program
{
    static void Main()
    {
        Console.Write("Digite um número: ");
        int numero = int.Parse(Console.ReadLine());
 
        if (numero % 2 == 0)
            Console.WriteLine("O número é PAR.");
        else
            Console.WriteLine("O número é ÍMPAR.");
    }
}