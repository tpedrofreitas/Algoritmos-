using System;

namespace _06_tabuada
{
    internal class Program
    {
        static void Main (string[] args)
        {
            int multiplicando = 0, produto;
            bool digitacaoValida = false;

            // ! negação: inverte o valor booleano
            // !false = true
            // !true = false
            // while ( digitacaoValida == false )

            while ( !digitacaoValida )
              {
                Console.WriteLine("Digite um numero inteiro");
                 digitacaoValida = int.TryParse(Console.ReadLine(), out multiplicando );
              }

            // Console.WriteLine("Tabuada do {0}",multiplicando;
            //Interpolação de String $

            Console.WriteLine($"Tabuada do {multiplicando}");

            for (int multiplicador = 1; multiplicador <= 10; multiplicador++)
            {
                produto = multiplicando * multiplicador;
                //Console.Write("{0} x {1} = {2} ", multiplicando,multiplicador, produto)

                Console.WriteLine($"{multiplicando} x {multiplicador} = {produto} ");
            }
       }
    }
 }          
           

        