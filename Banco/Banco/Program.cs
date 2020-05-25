using System;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta();

            Console.Write("Entre com o número da conta: ");
            int NConta = int.Parse(Console.ReadLine());
            Console.Write("Entre com o seu nome: ");
            string NomeTitular = Console.ReadLine();
            Console.Write("Deseja fazer um depósito inicial? ");
            string resposta = Console.ReadLine().ToUpper();

            if(resposta == "S")
            {
                Console.Write("Entre com o valor do depósito: ");
                double ValorInicial = double.Parse(Console.ReadLine());
                conta.Cadastro(NConta, NomeTitular, ValorInicial);
            }
            else
            {
                conta.Cadastro(NConta, NomeTitular);
            }

            Console.WriteLine(conta);

            Console.WriteLine("\nEntre com um valor para depósito: ");
            double val = double.Parse(Console.ReadLine());
            conta.Deposito(val);
            Console.WriteLine(conta);


            Console.WriteLine("\nEntre com um valor para saque: ");
            val = double.Parse(Console.ReadLine());
            conta.Saque(val);
            Console.WriteLine(conta);

            Console.ReadKey();
        }
    }
}
