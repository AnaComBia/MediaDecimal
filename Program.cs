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

            decimal soma, média, maior, menor, NumeroUsuario;

            int inicio = 0;

            while (quantidadeAparece < inicio)
            {
                inicio += 1;
                Console.Write($"Número #{inicio}: ");
                NumeroUsuario = Convert.ToDecimal(Console.ReadLine());

            }
           
            
            

            
        }
    }
}
