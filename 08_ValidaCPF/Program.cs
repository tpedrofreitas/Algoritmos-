using System;
using System.Text.RegularExpressions;


namespace _08_ValidaCPF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite seu CPF (somente numeros): ");
            string CPF = Console.ReadLine();
            

            CPF = Regex.Replace(CPF, "[^ 0-9]", "");
            if (CPF.Length != 11)
            {
                Console.WriteLine("CPF inválido! Deve ter 11 numeros.");
                return;
            }
            bool todosIguais = true;
            for (int i = 1; i < CPF.Length; i++)
            {
                if (CPF[i] != CPF[0])

                {
                    todosIguais = false;
                    break;
                }
            }
            if (todosIguais)
            {
                Console.WriteLine("CPF inválido!Não pode ter  Todos os números são iguais.");
                return;
            }
            Console.WriteLine("CPF aceito: " + CPF);
        }












    }






}
    

