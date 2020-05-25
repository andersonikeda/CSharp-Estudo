using System;

namespace Aluguel
{
    class Program
    {
        static void Main(string[] args)
        {
            Quartos[] vet = new Quartos[10];

            Console.WriteLine("Digite o número de quartos para alugar: ");
            int q = int.Parse(Console.ReadLine());

            for(int i = 0; i<q; i++)
            {
                Console.WriteLine();
                Console.WriteLine("{0}º cadastro",i+1);
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                vet[quarto] = new Quartos (nome,email,quarto);
            }
            Console.WriteLine();
            for(int i = 0; i<10; i++)
            {
                if(vet[i] != null)
                {
                    Console.WriteLine("{0}: {1}, {2}",vet[i].nQuarto,vet[i].NomeEstudante, vet[i].EmailEstudante);
                }
            }

            Console.ReadKey();
        }
    }
}
