using System;

namespace ExercicioProp
{
    internal class ContaBancaria
    {
        public int Conta { get; private set; }
        public string Nome { get; private set; }
        public double ValorNaConta { get; private set; }

        public ContaBancaria()
        {
        }
        public ContaBancaria(int conta, string nome)
        {
            Conta = conta;
            Nome = nome;
        }

        public ContaBancaria (int conta, string nome, double valorNaConta) : this(conta, nome)
        {
            ValorNaConta = valorNaConta;
        }

        public void DepositoConta(double deposito)
        {
            ValorNaConta += deposito;
        }
        public void SaqueConta(double saque)
        {
            ValorNaConta = (ValorNaConta - saque) - 5.0;
        }

        public override string ToString()
        {
            return "Conta: "
                + Conta
                + ", "
                + "Tirular "
                + Nome
                + ", "
                + "Saldo: "
                + ValorNaConta;
        }


    }
}
