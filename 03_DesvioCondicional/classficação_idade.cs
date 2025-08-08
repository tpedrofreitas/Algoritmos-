using System;

class classficacao_idade
{
	static void Main()
	{
		Console.Write("Digite sua idade: ");
		 int idade = int.Parse(Console.ReadLine());

        if (idade <= 12)
            Console.WriteLine("Criança");
        else if (idade <= 17)
            Console.WriteLine("Adolescente");
        else if (idade <= 59)
            Console.WriteLine("Adulto");
        else
            Console.WriteLine("Idoso");
    }
}