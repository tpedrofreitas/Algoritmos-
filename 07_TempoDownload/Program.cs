using System;

namespace _07_TempoDownload
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double TamanhoMB = 0, VelocidadeMpbs = 0,TempoSegundos = 0, TempoMinutos = 0;
            bool entradaVAlida = false;

            while (!entradaVAlida || TamanhoMB < 0)
            {
                Console.WriteLine("Informe o Tamanho do Arquivo (MB):");
                entradaVAlida = double.TryParse(Console.ReadLine(), out TamanhoMB);

                if (!entradaVAlida || TamanhoMB < 0) 
                    Console.WriteLine( "VAlor invalido tente novamente");

            }
            entradaVAlida = false;

            while (!entradaVAlida || VelocidadeMpbs < 0)
            {
                Console.WriteLine("Informe a Velocidade Da Internet (Mbps):");
                entradaVAlida = double.TryParse(Console.ReadLine(), out VelocidadeMpbs);

                if (!entradaVAlida || VelocidadeMpbs < 0)
                    Console.WriteLine("VAlor invalido tente novamente");
            }
            TempoSegundos = (TamanhoMB * 8)/VelocidadeMpbs;
            TempoMinutos = TempoSegundos / 60;

            Console.WriteLine($"Tempo aproximado Download:{TempoMinutos:F2} minutos");
            
        }
    }
}
