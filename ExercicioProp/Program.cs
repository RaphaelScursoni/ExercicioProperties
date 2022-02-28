using System.Globalization;

namespace ExercicioProp
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta = new ContaBancaria();

            Console.Write("Entre com o número da conta:");
            int num = int.Parse(Console.ReadLine());
            Console.Write("Entre com o títular da conta: ");
            string nome = Console.ReadLine();
            Console.Write("Haverá depósito inicial? (s/n): ");
            string depInicial = Console.ReadLine();

            if(depInicial == "s")
            {
                Console.Write("Digite o Valor do depósito: ");
                double valorNaConta = double.Parse(Console.ReadLine());
                conta = new ContaBancaria (num, nome, valorNaConta);
            }
            else
            {
                conta = new ContaBancaria(num, nome);
            }

            Console.Write("Dados da conta Bancária criada: " + conta);
            Console.WriteLine();
            Console.Write("Digite o Valor do depósito: ");
            double deposito = double.Parse(Console.ReadLine());
            conta.DepositoConta(deposito);
            Console.Write("Dados Atualizados: " + conta);
            Console.WriteLine();
            Console.Write("Digite o Valor do Saque: ");
            double saque = double.Parse(Console.ReadLine());
            conta.SaqueConta(saque);
            Console.Write("Dados Atualizados: " + conta);

        }
    }
}