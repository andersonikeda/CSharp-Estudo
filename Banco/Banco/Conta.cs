using System;
using System.Collections.Generic;
using System.Text;

namespace Banco
{
    class Conta
    {
        public int NConta { get; private set; }
        public string NomeTitular { get;  set; }
        public double Saldo { get;  private set; }

        public void Cadastro(int nConta, string nome, double depositoInicial)
        {
            NConta = nConta;
            NomeTitular = nome;
            Deposito(depositoInicial);
        }

        public void Cadastro(int nConta, string nome)
        {
            NConta = nConta;
            NomeTitular = nome;
            Saldo = 0;
        }

        public void Deposito(double valor)
        {
            Saldo = Saldo + valor;
        }

        public void Saque(double valor)
        {
            Saldo = Saldo - (valor+5);
        }

        public override string ToString()
        {
            return "Dados da conta: \nConta: " + NConta + ", Titular: " + NomeTitular + ", Saldo: " + ValorInicial;
        }

    }
}
