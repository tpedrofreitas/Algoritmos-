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
            //calculo verificação do primeiro digito
            int soma = 0;
            char[] CPFVetor = CPF.ToCharArray();

            for (int i = 0; i < 9; i++)
            {
                soma += int.Parse(CPFVetor[i].ToString()) * (10 - i);
            }
            int resto = soma % 11;

            int digX = 0;
            if(resto >= 2)
            {
            digX = 11 - resto;
            
            }
            //calculo verificação do segundo digito
            soma = 0;

            for (int i = 0;i < 10; i++)
            {
                soma += int.Parse(CPFVetor[i].ToString()) * (11 - i);
            }
               resto = soma % 11;
             
            int digY = 0;
            if (resto >= 2)
            {
                digY = 11 - resto;
            }
    
            //comparar os digitos
            if (
                int.Parse(CPF[9].ToString()) == digX &&
                int.Parse(CPF[10].ToString()) == digY
                )
            {
                Console.WriteLine("CPF VÁLIDO!");
            }
            else
            {
                Console.WriteLine("CPF INVÁLIDO!");
            }




        }

          









    }






}
    

