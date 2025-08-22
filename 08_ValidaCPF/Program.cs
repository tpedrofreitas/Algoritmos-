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

            //Eliminar caracteres não númericos
            //cpf.reaplace(" '.","");
            //cpf.reaplace(" '-","");
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
            int digX = CalculaDV(CPF, 9, 10);

            //calculo verificação do segundo digito
            int digY = CalculaDV(CPF, 9, 10);

            
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

         public static int CalculaDV(string cpf, int qtdeNumeros, int peso)
        {
            int soma = 0;
            char[] CPFVetor = cpf.ToCharArray();

            for (int i = 0; i < qtdeNumeros; i++)
            {
                soma += int.Parse(CPFVetor[i].ToString()) * (peso - i);
            }
            int resto = soma % 11;

            int digito = 0;
            if (resto >= 2)
            {
                digito = 11 - resto;

            }
            return digito;
        }      









    }






}
    

