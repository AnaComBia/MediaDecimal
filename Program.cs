using System;

namespace MediaDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n---Média Decimal---\n");

            Console.Write("Digite a quantidade de números que você deseja: ");
            int quantidadeAparece = Convert.ToInt32(Console.ReadLine());

            decimal soma, media, maior, menor, NumeroUsuario;

            soma = 0;
            maior = 123.45M;
            menor = 678.91M;
            NumeroUsuario = 123.45M;

            int inicio = 0;

            while (quantidadeAparece > inicio)
            {
                inicio += 1;
                Console.Write($"\nNúmero #{inicio}: ");
                NumeroUsuario = Convert.ToDecimal(Console.ReadLine());

                soma = soma + NumeroUsuario;

                if (inicio == 1)
                {
                    maior = NumeroUsuario;
                    menor = NumeroUsuario;
                }
                else if (NumeroUsuario > maior)
                {
                    maior = NumeroUsuario;
                }
                else if (NumeroUsuario < menor)
                {
                    menor = NumeroUsuario;
                }

            }

            if (NumeroUsuario < 0)
           {
               Console.WriteLine($"o número {NumeroUsuario}, não é válido");
           }
           else
           {
               media = soma / quantidadeAparece;
            
               Console.WriteLine($"\nMédia = {media}");
               Console.WriteLine($"Soma = {soma}");
               Console.WriteLine($"Maior Número = {maior}");
               Console.WriteLine($"Menor Número = {menor}\n");


           }
            
            

            
        }
    }
}
